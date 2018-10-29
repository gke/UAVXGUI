using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml; 
using System.Net;
using System.Net.Sockets;


using System.Reflection;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace UAVXGUI
{   // UAVX by Prof. Greg Egan (C) 2010.
    // Mission editing based on that from UAVXNav by Andras Schaffer (EOSBandi) (C) 2014.
    // Avionics Instrument Controls written by Guillaume Chouteau.
    // Inspired by Jordi Mu�oz from ArduPilotConfigTool.

    // LogBrowser is based on ArduPlanner Mega code written by Michael Oborne http://www.diydrones.com 
    // UNUSED Video capture code is using Aforge.Net Framework http://www.aforgenet.com
    // UNUSED Graph parts are using ZedGraph control http://sourceforge.net/projects/zedgraph/

    public partial class NavForm : Form
    {
        const double DEFAULT_HOME_LAT = 0;
        const double DEFAULT_HOME_LON = 0;
        const double DEFAULT_LON_CORR = 1.0f;

        // ASCII Constants
        const byte NUL = 0;
        const byte SOH = 1;
        const byte EOT = 4;
        const byte ACK = 6;
        const byte HT = 9;
        const byte LF = 10;
        const byte CR = 13;
        const byte NAK = 21;
        const byte ESC = 27;

        const byte mWP = 0;
        const byte mLat = 1;
        const byte mLon = 2;
        const byte mAlt = 3;
        const byte mAltOff = 4;
        const byte mAltSL = 5;
        const byte mVel = 6;
        const byte mLoiter = 7;
        const byte mAction = 8;
        const byte mPR = 9;
        const byte mPV = 10;

        const byte mUp = 11;
        const byte mDown = 12;
        const byte mDEL = 13;

        const double RadToDeg = (double)(180.0 / Math.PI);
        const double DegToRad = (double)(1.0 / RadToDeg);
        const double MilliRadToDeg = (double)(RadToDeg * 0.001);

        //Routes on Map
        static GMapRoute GMRouteFlightPath;
        static GMapRoute GMRouteMission;

        //Map Overlays
        static GMapOverlay GMOverlayFlightPath;// static so can update from gcs
        static GMapOverlay GMOverlayWaypoints;
        static GMapOverlay GMOverlayMission;
        static GMapOverlay GMOverlayLiveData;
        static GMapOverlay GMOverlayPOI;

        static GMapProvider[] mapProviders;
        static PointLatLng copterPos;

        static bool isMouseDown = false;
        static bool isMouseDragging = false;

        //static bool bPosholdRecorded = false;
        //static bool bHomeRecorded = false;

        // markers
        GMarkerGoogle currentMarker;
        GMapMarkerRect CurrentRectMarker = null;
        GMapMarker center;
        GMapMarker markerGoToClick = new GMarkerGoogle(new PointLatLng(0.0, 0.0), GMarkerGoogleType.lightblue);

        List<PointLatLng> points = new List<PointLatLng>();

        PointLatLng GPS_pos;
        PointLatLng end;
        PointLatLng start;

     //   const double DefaultVelocity = 3.0f;
     //   const short DefaultLoiter = 10;
     //   const double DefaultOrbitRadius = 10.0f;
     //   const double DefaultOrbitGroundAltitude = 0.0f;
     //   const double DefaultOrbitVelocity = 1.5f;

        const short RCMaximum = 1000;
        const double OUTMaximumScale = 0.5; // 100/200 % for PWM at least

  
        byte UAVXOptions;

        bool GoToEnabled;

     //   static byte PrevWPT = 255;
     //   static short AirframeT = 4;

        short FenceRadius;
        double LongitudeCorrectionT = 1.0f;
        //bool WPInvalid = false;

        double nHomeAlt;

        string sLastLoaded;
        bool InOnlineMode = true;
        bool UseOverTerrainMode = false;
       // ModifyRegistry myRegistry = new ModifyRegistry();
        string separatorFormat = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public double Limit1(double v, double l)
        {
            if (v < -l) return (-l); else if (v > l) return (l); else return (v);
        }

        public NavForm()
        {
            InitializeComponent();

            GoToCheckBox.Checked = false; //  Properties.Settings.Default.GoToEnable;

            AltitudeOverTerrainCheckBox.Checked = Properties.Settings.Default.AltitudeOverTerrain;
        
            LocationAddress.Text = Properties.Settings.Default.SearchAddress;

            AltitudeOverTerrainCheckBox.Checked = Properties.Settings.Default.AltitudeOverTerrain;

            FormMain.Mission.OriginLatitude = 0; // zzz Convert.ToInt32(Properties.Settings.Default.HomeLatitude * 1e7);
            StartLat.Text = Convert.ToString(Properties.Settings.Default.HomeLatitude);

            FormMain.Mission.OriginLongitude = 0; // zzz Convert.ToInt32(Properties.Settings.Default.HomeLongitude * 1e7);
            StartLon.Text = Convert.ToString(Properties.Settings.Default.HomeLongitude);

            LongitudeCorrectionT = Math.Abs(Math.Cos(Math.PI / 180.0 * (double)Convert.ToInt32(Properties.Settings.Default.HomeLatitude * 1e7)));
         //zzz   LongitudeCorrection.Text = string.Format("{0:n2}", LongitudeCorrectionT);

            DefaultAltTextBox.Text = string.Format("{0:n0}", Properties.Settings.Default.Altitude);

            FormMain.Mission.ProximityRadius = Properties.Settings.Default.ProximityRadius;
            ProximityRadiusTextBox.Text = string.Format("{0:n0}", FormMain.Mission.ProximityRadius);

            FormMain.Mission.ProximityAltitude = Properties.Settings.Default.ProximityAltitude;
            ProximityAltTextBox.Text = string.Format("{0:n0}", FormMain.Mission.ProximityAltitude);

            FormMain.Mission.FenceRadius = Properties.Settings.Default.FenceRadius;
            FenceRadiusTextBox.Text = string.Format("{0:n0}", FormMain.Mission.FenceRadius);

            DefaultLoiterTextBox.Text = string.Format("{0:n0}", Properties.Settings.Default.LoiterTime);

            PerformLayout();

            // config map             
            MainMap.MinZoom = 1;
            MainMap.MaxZoom = 20;
            MainMap.Zoom = 16;

            MainMap.CacheLocation = Path.GetDirectoryName(Application.ExecutablePath) + "/mapcache/";

            mapProviders = new GMapProvider[7];
            mapProviders[0] = GMapProviders.BingHybridMap;
            mapProviders[1] = GMapProviders.BingSatelliteMap;
            mapProviders[2] = GMapProviders.GoogleSatelliteMap;
            mapProviders[3] = GMapProviders.GoogleHybridMap;
            mapProviders[4] = GMapProviders.OviSatelliteMap;
            mapProviders[5] = GMapProviders.OviHybridMap;

            for (int i = 0; i < 6; i++)
                MapProviderComboBox.Items.Add(mapProviders[i]);

            //MapProviderComboBox.SelectedIndex = gui_settings.iMapProviderSelectedIndex;
            MainMap.MapProvider = mapProviders[0];

            // black screen MainMap.ForceDoubleBuffer = true;
            MainMap.Manager.Mode = AccessMode.ServerAndCache;

            MainMap.Position = copterPos = new PointLatLng(Convert.ToDouble(StartLat.Text), Convert.ToDouble(StartLon.Text));
            currentMarker = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.red);

            // map events

            MainMap.OnPositionChanged += new PositionChanged(MainMap_OnCurrentPositionChanged);
            //MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
            MainMap.OnMapZoomChanged += new MapZoomChanged(MainMap_OnMapZoomChanged);
            MainMap.MouseMove += new MouseEventHandler(MainMap_MouseMove);
            MainMap.MouseDown += new MouseEventHandler(MainMap_MouseDown);
            MainMap.MouseUp += new MouseEventHandler(MainMap_MouseUp);
            MainMap.OnMarkerEnter += new MarkerEnter(MainMap_OnMarkerEnter);
            MainMap.OnMarkerLeave += new MarkerLeave(MainMap_OnMarkerLeave);

            Pen penRoute = new Pen(Color.Yellow, 3);
            Pen penScale = new Pen(Color.Blue, 3);

            MainMap.ScalePen = penScale;

            GMOverlayFlightPath = new GMapOverlay("flightpath");
            MainMap.Overlays.Add(GMOverlayFlightPath);

            GMOverlayMission = new GMapOverlay("missionroute");
            MainMap.Overlays.Add(GMOverlayMission);

            GMOverlayWaypoints = new GMapOverlay("waypoints");
            MainMap.Overlays.Add(GMOverlayWaypoints);

            GMOverlayLiveData = new GMapOverlay("livedata");
            MainMap.Overlays.Add(GMOverlayLiveData);

            GMOverlayPOI = new GMapOverlay("poi");
            MainMap.Overlays.Add(GMOverlayPOI);

            GMOverlayLiveData.Markers.Clear();
            GMOverlayLiveData.Markers.Add(new GMapMarkerCopter(copterPos, 0, 0, 0, 3));

            GMRouteFlightPath = new GMapRoute(points, "flightpath");
            GMRouteFlightPath.Stroke = penRoute;
            GMOverlayFlightPath.Routes.Add(GMRouteFlightPath);

            center = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.blue_dot);

            MainMap.Invalidate(false);
            //MainMap.Refresh();

            InOnlineMode = Stuff.PingNetwork("pingtest.com");
            if (!InOnlineMode)
            {
                MainMap.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OfflineMapLabel.Visible = true;
            }
            else
                OfflineMapLabel.Visible = false;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            MainMap.Invalidate(false);

            Version vrs = new Version(Application.ProductVersion);
            this.Text = this.Text + " V" + vrs.Major + "." + vrs.Minor + "." + vrs.Build;

            M.Columns[mAltOff].Visible = false;
            M.Columns[mAltSL].Visible = false;
            M.Columns[mUp].Visible = true;
            M.Columns[mDown].Visible = true;
            M.Columns[mDEL].Visible = true;


            Application.DoEvents();

           // need to make certain serial is open FormMain.SendRequestPacket(FormMain.UAVXMissionPacketTag, 0, 0);

            timer_updatemap.Enabled = true;
        } // Form1


        private void timer_updatemap_Tick(object sender, EventArgs e)
        {

            Application.DoEvents();

            if (FormMain.NewMissionAvailable)
            {
                FormMain.NewMissionAvailable = false;
                UAVXDownload();
            }

            UpdateLiveNav();

            updateMap();

            CurrentAltitude.Text = string.Format("{0:n1}", (float)FormMain.CurrAlt);

            WindDirectionTextBox.Text = string.Format("{0:n0}",FormMain.WindDirectionT * FormMain.MILLIRADDEG);
            WindSpeedTextBox.Text = string.Format("{0:n1}",FormMain.WindSpeedT * 0.01);

            Properties.Settings.Default.Save();
 
        } // timer_updatemap_Tick



        private void MenuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        } // MenuMain_ItemClicked


       

        private void UpdateLiveNav()
        {
            //Map update should be continous
            if (FormMain.GPSLatitudeT != 0)
            {
                GPS_pos.Lat = (double)FormMain.GPSLatitudeT * 1e-7;
                GPS_pos.Lng = (double)FormMain.GPSLongitudeT * 1e-7;
                GMRouteFlightPath.Points.Add(GPS_pos);
            }

            //Hack to force map update
            GMOverlayFlightPath.IsVisibile = false;
            GMOverlayFlightPath.IsVisibile = ShowFlightPathCheckBox.Checked;

            //Update markers
            if (FormMain.GPSLatitudeT != 0)
            {
                //Clear markers
                GMOverlayLiveData.Markers.Clear();

                //Display GPS position
                // lGPS_lat.Text = Convert.ToString((decimal)mw_gui.GPS_latitude / 10000000);
                // lGPS_lon.Text = Convert.ToString((decimal)mw_gui.GPS_longitude / 10000000);

                //Go to click marker display
                if (markerGoToClick != null) GMOverlayLiveData.Markers.Add(markerGoToClick);

                //Display HOME position marker
                if (FormMain.Mission.OriginLatitude != 0)
                {
                    PointLatLng GPS_home = new PointLatLng((double)FormMain.Mission.OriginLatitude * 1e-7, (double)FormMain.Mission.OriginLongitude * 1e-7);
                    GMOverlayLiveData.Markers.Add(new GMapMarkerHome(GPS_home));
                }

                //Display copter marker
                GMOverlayLiveData.Markers.Add(new GMapMarkerCopter(GPS_pos, (float)FormMain.HeadingT * 0.001f, (float)FormMain.GPSHeadingT * 0.001f, (float)FormMain.WPBearingT * 0.001f, Convert.ToByte(FormMain.AirframeT)));

                if (CentreCurrPositionCheckBox.Checked) {
                    MainMap.Position = GPS_pos;
                    StartLat.Text = String.Format("{0:0.000000}", MainMap.Position.Lat);
                    StartLon.Text = String.Format("{0:0.000000}", MainMap.Position.Lng);
                }

               

                MainMap.Invalidate(false);

            }

            //Highlight actual mission step
            for (int i = 0; i < M.RowCount; i++)
                M.Rows[i].DefaultCellStyle.BackColor = Color.White;

            if ((FormMain.StateT == FormMain.FlightStates.Flying) && (FormMain.CurrWPT > 0))
            {
                try
                {
                    if (M.RowCount >= FormMain.Mission.NoOfWayPoints) M.Rows[FormMain.CurrWPT - 1].DefaultCellStyle.BackColor = Color.Lime;
                }
                catch { }
            }

          
        } // UpdateLiveNav
        

        //_______________________________________________________________________________________


        public void dragMarkerCallback(string pointno, double Lat, double Lon, int alt)
        {
            if (pointno == "")
                return;

            int selectedrow = int.Parse(pointno) - 1;
            M.CurrentCell = M[mLat, selectedrow];
            M.Rows[selectedrow].Cells[mLat].Value = Lat.ToString("0.0000000");
            M.Rows[selectedrow].Cells[mLon].Value = Lon.ToString("0.0000000");
            M.Rows[selectedrow].DataGridView.EndEdit();

        } // dragMarkerCallback

        private void updateIndex()
        {
            for (int wp = 1; wp <= M.Rows.Count; wp++)
                M.Rows[wp - 1].Cells[mWP].Value = wp;
            M.EndEdit();

            FormMain.Mission.NoOfWayPoints = Convert.ToByte(M.Rows.Count);
 
        } // updateIndex

        /*
                        nDownloadedAlt = GetAltitudeData(nWPLat, nWPLon);

                        M[mWP, np].Value = Convert.ToString(M.Rows.Count);
                        M[mLat, np].Value = string.Format("{0:n6}", nWPLat);
                        M[mLon, np].Value = string.Format("{0:n6}", nWPLon);

                        double nAlt = AltitudeOverTerrainCheckBox.Checked ? nDownloadedAlt + nAltHold - nHomeAlt : nAltHold;
                        M[mAlt, np].Value = string.Format("{0:n2}", nAlt);

                        M[mAltOff, np].Value = string.Format("{0:n2}", nAltHold);
                        M[mAltSL, np].Value = string.Format("{0:n2}", nDownloadedAlt);
         */

        private void updateMap()
        {

            if (GMOverlayWaypoints != null) // hasnt been created yet
                GMOverlayWaypoints.Markers.Clear();

            if (GMRouteMission != null)
                GMRouteMission.Points.Clear();

            if (GMOverlayPOI != null)
                GMOverlayPOI.Markers.Clear();

            for (int a = 0; a < M.Rows.Count - 0; a++)
            {
                string sLat = M.Rows[a].Cells[mLat].Value.ToString(); // lat
                string sLon = M.Rows[a].Cells[mLon].Value.ToString(); // lng
                string sAlt = M.Rows[a].Cells[mAlt].Value.ToString(); // alt

                string sAction = M.Rows[a].Cells[mAction].Value.ToString();

                if (sLon != "0" && sLat != "0" && sLon != "?" && sLat != "?")
                    if (sAction == "POI") 
                        AddPOIMarker((a + 1).ToString(), double.Parse(sLon), double.Parse(sLat));
                    else
                        AddMarker((a + 1).ToString(), double.Parse(sLon), double.Parse(sLat),
                         (int)double.Parse(sAlt), null, Convert.ToByte(Array.IndexOf(FormMain.NavComNames, sAction)));
    //FindIndex(Convert.ToString(sAction)));
    
            }

            RegenerateMissionRoute();
            DistanceLabel.Text = String.Format("Mission total dist.:{0:n1}m", GMRouteMission.Distance * 1000);
        }

        //_______________________________________________________________________________________

        // General M Editing


        private void M_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrow = e.RowIndex;
            try
            {
                string sAction = M[mAction, selectedrow].Value.ToString();
                //change_datagrid_header(sAction);

            }
            catch { }
        }

        private void M_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrow = e.RowIndex;
            try
            {
                string sAction = M[mAction, selectedrow].Value.ToString();
                //     change_datagrid_header(sAction);

            }
            catch { }
        }

        private void M_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateMap();
            updateIndex();
        }

        private void M_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            if (e.ColumnIndex == DEL.Index && (e.RowIndex + 0) < M.RowCount) // delete
            {
                M.Rows.RemoveAt(e.RowIndex);
            }
            if (e.ColumnIndex == Up.Index && e.RowIndex != 0) // up
            {
                DataGridViewRow myrow = M.CurrentRow;
                M.Rows.Remove(myrow);
                M.Rows.Insert(e.RowIndex - 1, myrow);
            }
            if (e.ColumnIndex == Down.Index && e.RowIndex < M.RowCount - 1) // down
            {
                DataGridViewRow myrow = M.CurrentRow;
                M.Rows.Remove(myrow);
                M.Rows.Insert(e.RowIndex + 1, myrow);
            }

            updateMap();
            updateIndex();
        }

        //_______________________________________________________________________________________

        // General Parameter Dialogue 

        private void ShowMissionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GMOverlayMission.IsVisibile = ShowMissionCheckBox.Checked;
            MainMap.Invalidate(false);
        }

        private void ShowWPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GMOverlayWaypoints.IsVisibile = ShowWPCheckBox.Checked;
            GMOverlayPOI.IsVisibile = ShowWPCheckBox.Checked;
            MainMap.Invalidate(false);
        }

        private void ShowPosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //GMOverlayLiveData.IsVisibile = ShowPosCheckBox.Checked;
            MainMap.Invalidate(false);
        }

        private void ShowFlightPathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GMOverlayFlightPath.IsVisibile = ShowFlightPathCheckBox.Checked;
        }

        private void GoToCheckBox_CheckChanged(object sender, EventArgs e)
        {
            M.Rows.Clear();
            updateMap();

            if (GoToCheckBox.Checked)
            {
                GoToCheckBox.BackColor = Color.Red;
                GoToCheckBox.ForeColor = Color.White;
                GoToCheckBox.Text = "Go To Active";
                GoToEnabled = true;
            }
            else
            {
                GoToCheckBox.BackColor = Color.LightGray;
                GoToCheckBox.ForeColor = Color.Black;
                GoToCheckBox.Text = "Go To Inactive";
                GoToEnabled = false;
                GMOverlayLiveData.Markers.Remove(markerGoToClick);
                markerGoToClick = null;
            }

            Properties.Settings.Default.GoToEnable = GoToCheckBox.Checked;
   
        } // GoToCheckBox_CheckChanged

 
        private void optLocation_CheckedChanged() //object sender, EventArgs e)
        {
            CentreCurrPositionCheckBox.Checked = false;

           // StartLat.Text = String.Format("{0:0.000000}", MainMap.Position.Lat);
           // StartLon.Text = String.Format("{0:0.000000}", MainMap.Position.Lng);

            Properties.Settings.Default.HomeLatitude = Convert.ToDouble(StartLat.Text);
            Properties.Settings.Default.HomeLongitude = Convert.ToDouble(StartLon.Text);

            LongitudeCorrectionT = Math.Abs(Math.Cos(Math.PI / 180.0 * (double)Properties.Settings.Default.HomeLatitude * 1e-7));

            MainMap.Position = copterPos = new PointLatLng(Convert.ToDouble(StartLat.Text), Convert.ToDouble(StartLon.Text));

            FormMain.GPSLatitudeT = 0;

            MainMap.Invalidate(false);
            MapCentreButton.BackColor = System.Drawing.Color.Orange;

        } // optLocation_CheckedChanged


        private void SearchButton_Click(object sender, EventArgs e)
        {
            optLocation_CheckedChanged();
            MapCentreButton.BackColor = System.Drawing.Color.Green;
        } // SearchButton_Click


        private void SearchAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            //Registry.CreateSubKey("Software\\Remzibi OSD\\ArduPilot\\Settings");


        } // SearchAddressTextBox_TextChanged


        private void SearchAddressTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = MapCentreButton;

        } // SearchAddressTextBox_Enter



        private void FenceRadius_TextChanged(object sender, EventArgs e)
        {

            if (FenceRadiusTextBox.Text == "")
            {
                FenceRadius = -1;
                FenceRadiusTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                short outValue;
                short.TryParse(StartLat.Text, out outValue);
                FenceRadius = outValue;
                if (FenceRadius <= 50)
                    FenceRadiusTextBox.BackColor = System.Drawing.Color.White;
                else
                    if (FenceRadius <= 100)
                        FenceRadiusTextBox.BackColor = System.Drawing.Color.Lime;
                    else
                        if (FenceRadius <= 150)
                            FenceRadiusTextBox.BackColor = System.Drawing.Color.Orange;
                        else
                            FenceRadiusTextBox.BackColor = System.Drawing.Color.Red;
            }
            Properties.Settings.Default.FenceRadius = FormMain.Mission.FenceRadius = FenceRadius;
            UAVXWriteButton.BackColor = System.Drawing.Color.Orange;
 
        } // FenceRadius_TextChanged
  

        private void StartLat_Leave(object sender, EventArgs e)
        {
            double outValue;
            double.TryParse(StartLat.Text, out outValue);
            if (outValue != 0) {
                Properties.Settings.Default.HomeLatitude = Convert.ToDouble(StartLat.Text);
               //zzz FormMain.Mission.OriginLatitude = Convert.ToInt32(Properties.Settings.Default.HomeLatitude * 1e7);
            }

        } // StartLat_Leave

        private void StartLon_Leave(object sender, EventArgs e)
        {
            double outValue;

            double.TryParse(StartLon.Text, out outValue);
            if (outValue != 0) {
                Properties.Settings.Default.HomeLongitude = Convert.ToDouble(StartLon.Text);
                //zzzFormMain.Mission.OriginLongitude = Convert.ToInt32(Properties.Settings.Default.HomeLongitude * 1e7);//zzz
            }

        } // StartLon_Leave

        private void StartLon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                StartLon_Leave(sender, e);
        } // StartLon_KeyPress

        private void StartLat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                StartLat_Leave(sender, e);
        } // StartLat_KeyPress

        private void StartLat_TextChanged(object sender, EventArgs e)
        {
            UAVXWriteButton.BackColor = System.Drawing.Color.Orange;
        } // StartLat_TextChanged


        private void StartLon_TextChanged(object sender, EventArgs e)
        {
            UAVXWriteButton.BackColor = System.Drawing.Color.Orange;
        } // StartLon_TextChanged


        private void MapZoomNumericUpDown_Click(object sender, EventArgs e)
        {
            MainMap.Zoom = Convert.ToDouble(MapZoomNumericUpDown.Value);
            Properties.Settings.Default.MapZoom = Convert.ToInt16(MapZoomNumericUpDown.Text);
        } // MapZoomNumericUpDown_Click


        private void DefaultLoiterTextBox_TextChanged(object sender, EventArgs e)
        {
            short outValue;
            Properties.Settings.Default.LoiterTime = (short.TryParse(DefaultLoiterTextBox.Text, out outValue)) ?
                 (short)outValue : Properties.Settings.Default.LoiterTime;
        } // DefaultLoiterTextBox_TextChanged


        private void DefaultAltTextBox_TextChanged(object sender, EventArgs e)
        {
            short outValue;
            Properties.Settings.Default.Altitude = (short.TryParse(DefaultAltTextBox.Text, out outValue)) ?
                 (short)outValue : Properties.Settings.Default.ProximityAltitude;
        } // DefaultAltTextBox_TextChanged


        private void ProximityRadius_TextChanged(object sender, EventArgs e)
        {
            byte outValue;

            Properties.Settings.Default.ProximityRadius = (byte.TryParse(ProximityRadiusTextBox.Text, out outValue)) ?
                (byte)outValue : Properties.Settings.Default.ProximityRadius;
            UAVXWriteButton.BackColor = System.Drawing.Color.Orange;
  
        } // ProximityRadius_TextChanged

        private void ProximityAlt_TextChanged(object sender, EventArgs e)
        {
            byte outValue;

            Properties.Settings.Default.ProximityAltitude = (byte.TryParse(ProximityAltTextBox.Text, out outValue)) ?
                (byte)outValue : Properties.Settings.Default.ProximityAltitude;
            UAVXWriteButton.BackColor = System.Drawing.Color.Orange;
        } // ProximityAlt_TextChanged

        void MainMap_OnMapZoomChanged()
        {
            if (MainMap.Zoom > 0)
               center.Position = MainMap.Position;
        } // MainMap_OnMapZoomChanged

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //_______________________________________________________________________________________

        // Local Ground Altitude 

        private void AltitudeOverTerrainitudeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UseOverTerrainMode = AltitudeOverTerrainCheckBox.Checked;
            updateAltColumns();
            Properties.Settings.Default.AltitudeOverTerrain = AltitudeOverTerrainCheckBox.Checked;

            if (UseOverTerrainMode)
            {
                nHomeAlt = GetAltitudeData(Convert.ToDouble(StartLat.Text.Replace(
                    ".", separatorFormat)), Convert.ToDouble(StartLon.Text.Replace(
                    ".", separatorFormat)));
            }

            Cursor.Current = Cursors.Default;

        } // AltitudeOverTerrainitudeCheckBox_CheckedChanged

        private double GetAltitudeData(double latitude, double longitude)
        {
            try
            {
                if (!UseOverTerrainMode)
                    return 0;

                double nDoubleReturn;
                WebRequest myWebRequest = WebRequest.Create(
                    "http://gisdata.usgs.gov/XMLWebServices2/Elevation_Service.asmx/getElevation?X_Value=" +
                    Regex.Replace(longitude.ToString(), ",", ".") + "&Y_Value=" +
                    Regex.Replace(latitude.ToString(), ",", ".") +
                    "&Elevation_Units=METERS&Source_Layer=-1&Elevation_Only=True");

                WebResponse myWebResponse = myWebRequest.GetResponse();

                Stream ReceiveStream = myWebResponse.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader readStream = new StreamReader(ReceiveStream, encode);

                string strResponse = readStream.ReadToEnd();
                readStream.Close();
                myWebResponse.Close();

                strResponse = strResponse.Substring(strResponse.IndexOf(">") + 1);
                strResponse = strResponse.Substring(strResponse.IndexOf(">") + 1);
                strResponse = strResponse.Substring(0, strResponse.IndexOf("<"));
                double.TryParse(strResponse, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.GetCultureInfo("en-US"), out nDoubleReturn);

                return Convert.ToDouble(string.Format("{0:n0}", nDoubleReturn));
            }
            catch
            {
                return 0;
            }
        } // GetAltitudeData

        private void updateAltColumns()
        {
            int rowM;

            for (rowM = 0; rowM < M.Rows.Count; rowM++)
            {
                if (AltitudeOverTerrainCheckBox.Checked)
                {
                    M[mAltSL, rowM].Value = string.Format("{0:n0}",
                        GetAltitudeData(Convert.ToDouble(M[mLat, rowM].Value),
                        Convert.ToDouble(M[mLon, rowM].Value)));
                    M[mAlt, rowM].Value = string.Format("{0:n0}",
                        (Convert.ToDouble(M[mAltOff, rowM].Value) +
                        Convert.ToDouble(M[mAltSL, rowM].Value) - nHomeAlt));
                }
                else
                    M[mAlt, rowM].Value = string.Format("{0:n0}", (double)M[mAltOff, rowM].Value);
            }
        } // updateAltColumns
   


        //_______________________________________________________________________________________

        // WP Commands

        private void AddMarker(string tag, double lng, double lat, int alt, Color? color, byte markertype)
        {
            PointLatLng point = new PointLatLng(lat, lng);

            GMapMarker m = new GMapMarkerMissionStep(point, Convert.ToByte(tag), (byte)markertype);
            m.Tag = tag;

            GMapMarkerRect mBorders = new GMapMarkerRect(point);
            {
                mBorders.InnerMarker = m;
                mBorders.wprad = (int)FormMain.Mission.ProximityRadius / 100;
                mBorders.MainMap = MainMap;
                if (color.HasValue)
                    mBorders.Color = color.Value;
            }

            GMOverlayWaypoints.Markers.Add(m);
            GMOverlayWaypoints.Markers.Add(mBorders);
        }

        private void AddPOIMarker(string tag, double lng, double lat)
        {
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker m = new GMapMarkerMissionStep(point, Convert.ToByte(tag), (byte)FormMain.NavComs.navPOI);
            m.Tag = tag;

            GMapMarkerRect mBorders = new GMapMarkerRect(point);
            {
                mBorders.InnerMarker = m;
                mBorders.wprad = (int)FormMain.Mission.ProximityRadius / 100;
                mBorders.MainMap = MainMap;
            }

            GMOverlayPOI.Markers.Add(m);
            GMOverlayPOI.Markers.Add(mBorders);
        }

        private void ViaContextMenuItem_Click(object sender, EventArgs e)
        {
            if (!GoToEnabled)
                addWP(FormMain.NavComNames[(byte)FormMain.NavComs.navVia], start.Lat, start.Lng, 
                    Properties.Settings.Default.Altitude, Properties.Settings.Default.Velocity, 
                    Convert.ToInt32(DefaultLoiterTextBox.Text), Properties.Settings.Default.OrbitRadius, 
                    Properties.Settings.Default.OrbitVelocity, 25);
        } // ViaContextMenuItem_Click

        private void OrbitContextMenuItem_Click(object sender, EventArgs e)
        {
            if (!GoToEnabled) addWP(FormMain.NavComNames[(byte)FormMain.NavComs.navOrbit], start.Lat, start.Lng,
                Properties.Settings.Default.Altitude, Properties.Settings.Default.Velocity, 30, 
                Properties.Settings.Default.OrbitRadius, Properties.Settings.Default.OrbitVelocity, 25);
        } // OrbitContextMenuItem_Click

        private void PerchContextMenuItem_Click(object sender, EventArgs e)
        {
            if (!GoToEnabled) addWP(FormMain.NavComNames[(byte)FormMain.NavComs.navPerch], start.Lat, start.Lng, 
                Properties.Settings.Default.Altitude, Properties.Settings.Default.Velocity, -1, 0, 0, 0);
        } // PerchContextMenuItem_Click

        private void GotoWP()
        {
            M.Rows.Clear();
            updateMap();
            addWP(FormMain.NavComNames[(byte)FormMain.NavComs.navVia], start.Lat, start.Lng, 
                Properties.Settings.Default.Altitude, Properties.Settings.Default.Velocity, 600, 0, 0, 0);
        } // GoToWP


        private void POIContextMenuItem_Click(object sender, EventArgs e)
        {
            if (!GoToEnabled)
            addWP(FormMain.NavComNames[(byte)FormMain.NavComs.navPOI], start.Lat, start.Lng, 
                Properties.Settings.Default.Altitude, 0, 0, 0, 0, 0);
        } // POIContextMenuItem_Click


        private void ClearMissionContextMenuItem_Click(object sender, EventArgs e)
        {
            M.Rows.Clear();
            updateMap();
        } // ClearMissionContextMenuItem_Click

        private void contextMenuStripMap_Opening(object sender, CancelEventArgs e)
        {
            if (GoToEnabled) e.Cancel = true;
            return;
        }

        private void WPDeleteContextMenuItem_Click(object sender, EventArgs e) //  
        {

            int no = 0;
            if (CurrentRectMarker != null)
            {
                if (int.TryParse(CurrentRectMarker.InnerMarker.Tag.ToString(), out no))
                {
                    try
                    {
                        M.Rows.RemoveAt(no - 1); // home is 0
                        updateMap();
                        updateIndex();
                    }
                    catch { MessageBox.Show("error selecting wp, please try again."); }
                }
            }

            if (currentMarker != null)
                CurrentRectMarker = null;
        } // WPDeleteContextMenuItem_Click


        public bool BeyondFenceRadius(double Lat, double Lon)
        {
            double Distance;

            if (FenceRadius > 0) {
                Distance = MainMap.MapProvider.Projection.GetDistance(
                new PointLatLng(FormMain.Mission.OriginLatitude * 1e-7, FormMain.Mission.OriginLongitude * 1e-7), 
                new PointLatLng(Lat, Lon)
                ) * 1000.0;
            return(Distance > (double)FenceRadius);
        } else
        return(false);
    
        } // BeyondFenceRadius


        private void addWP(string action, double Lat, double Lon, int Alt, double Vel, int Loiter, double P1, double P2, double P3)
        {
            if (M.Rows.Count >= FormMain.MaxWayPoints)
                MessageBox.Show("Too many waypoints. Limit " + Convert.ToString(FormMain.MaxWayPoints), "Max waypoints reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
               
            {
                 if (BeyondFenceRadius(Lat, Lon) || (FormMain.CurrAlt > FormMain.MaximumAltitudeLimit))
                     MessageBox.Show("Waypoint is beyond your range limit setting of " + Convert.ToString(FenceRadius)
                         + "m away or above " + FormMain.MaximumAltitudeLimit + "m  (FAA/CASA/etc).", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int selectedrow = M.Rows.Add();
                M.Rows[selectedrow].Cells[mWP].Value = selectedrow + 1;
                M.Rows[selectedrow].Cells[mLat].Value = Lat.ToString("0.0000000");
                M.Rows[selectedrow].Cells[mLon].Value = Lon.ToString("0.0000000");
                M.Rows[selectedrow].Cells[mAlt].Value = Alt;
                M.Rows[selectedrow].Cells[mAltOff].Value = 0;
                M.Rows[selectedrow].Cells[mAltSL].Value = GetAltitudeData(Lat, Lon);
                M.Rows[selectedrow].Cells[mVel].Value = Vel;
                M.Rows[selectedrow].Cells[mLoiter].Value = Loiter;
                M.Rows[selectedrow].Cells[mAction].Value = action;
                M.Rows[selectedrow].Cells[mPR].Value = P1;
                M.Rows[selectedrow].Cells[mPV].Value = P2;

                M.Rows[selectedrow].DataGridView.EndEdit();

                updateMap();
            }

        } // addWP

  
        void RegenerateMissionRoute()
        {
            List<PointLatLng> polygonPoints = new List<PointLatLng>();

            if (GMOverlayWaypoints == null)
                return;

            foreach (GMapMarker m in GMOverlayWaypoints.Markers)
            {
                if (m is GMapMarkerRect)
                {
                    m.Tag = polygonPoints.Count;
                    polygonPoints.Add(m.Position);
                }
            }
            if (GMRouteMission == null)
            {
                GMRouteMission = new GMapRoute(polygonPoints, "wp route");
                GMRouteMission.Stroke = new Pen(Color.Aquamarine, 3);

                GMOverlayMission.Routes.Add(GMRouteMission);
            }
            else
            {
                GMRouteMission.Points.Clear();
                GMRouteMission.Points.AddRange(polygonPoints);

                if (GMOverlayMission.Routes.Count == 0)
                    GMOverlayMission.Routes.Add(GMRouteMission);
                else
                    MainMap.UpdateRouteLocalPosition(GMRouteMission);
            }
            GMOverlayMission.IsVisibile = false;
            MainMap.Invalidate(false);
            GMOverlayMission.IsVisibile = ShowMissionCheckBox.Checked;
            MainMap.Invalidate(false);

        } // RegenerateMissionRoute


        void MainMap_OnCurrentPositionChanged(PointLatLng point)
        {
            point.Lat = Limit1(point.Lat, 90);
            point.Lng = Limit1(point.Lng, 180);
            center.Position = point;
            MousePosLabel.Text = "Lat:" + String.Format("{0:0.000000}", point.Lat) + " Lon:" + String.Format("{0:0.000000}", point.Lng);

        } // MainMap_OnCurrentPositionChanged

        void MainMap_OnMarkerLeave(GMapMarker item)
        {
            if (!isMouseDown)
                if (item is GMapMarkerRect)
                {
                    CurrentRectMarker = null;

                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Blue;
                    MainMap.Invalidate(false);
                }
        } // MainMap_OnMarkerLeave

        void MainMap_OnMarkerEnter(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarkerRect)
                {
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Green;
                    MainMap.Invalidate(false);
                    CurrentRectMarker = rc;
                    int answer;
                    if (item.Tag != null && rc.InnerMarker != null && int.TryParse(rc.InnerMarker.Tag.ToString(), out answer))
                    {
                        try
                        {
                            M.CurrentCell = M[mWP, answer - 1];
                            item.ToolTipText = "Altitude: " + M[mAlt, answer - 1].Value.ToString() + "m";
                            item.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        }
                        catch { }
                    }

                }
            }
        } // MainMap_OnMarkerEnter


        //_______________________________________________________________________________________

        // Mouse

        void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            end = MainMap.FromLocalToLatLng(e.X, e.Y);

            if (e.Button == MouseButtons.Right && GoToEnabled) // Right Click is the click to is enabled
            {
                PointLatLng pointClickToGo = new PointLatLng(end.Lat, end.Lng);
                GMOverlayLiveData.Markers.Remove(markerGoToClick);
                markerGoToClick = new GMapMarkerFlyHere(pointClickToGo);
                GMOverlayLiveData.Markers.Add(markerGoToClick);

                GotoWP();

                return;
            }

            if (isMouseDown) // mouse down on some other object and dragged to here.
            {
                if (e.Button == MouseButtons.Left)
                    isMouseDown = false;

                if (!isMouseDragging)
                    if (CurrentRectMarker != null)
                    {
                        // can't add WP in existing rect
                    }
                    else
                    {
                        if ((Control.ModifierKeys == Keys.Control) && (!GoToEnabled))
                            addWP(FormMain.NavComNames[(byte)FormMain.NavComs.navVia], currentMarker.Position.Lat, currentMarker.Position.Lng,
                                Properties.Settings.Default.Altitude, Properties.Settings.Default.Velocity, Properties.Settings.Default.LoiterTime, 0, 0, 0);
                    }
                else
                {
                    if (CurrentRectMarker != null)
                        dragMarkerCallback(CurrentRectMarker.InnerMarker.Tag.ToString(), currentMarker.Position.Lat, currentMarker.Position.Lng, -1);
                }
            }

            isMouseDragging = false;
        }

        void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            start = MainMap.FromLocalToLatLng(e.X, e.Y);

            if (e.Button == MouseButtons.Right)
                contextMenuStripMap.Show(this, new Point(e.X, e.Y));

            if (e.Button == MouseButtons.Left && Control.ModifierKeys != Keys.Alt)
            {
                isMouseDown = true;
                isMouseDragging = false;

                if (currentMarker.IsVisible)
                    currentMarker.Position = MainMap.FromLocalToLatLng(e.X, e.Y);
            }
        }

        void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = MainMap.FromLocalToLatLng(e.X, e.Y);

            currentMarker.Position = point;

            if (!isMouseDown)
            {
                MousePosLabel.Text = "Lat:" + String.Format("{0:0.000000}", point.Lat) + " Lon:" + String.Format("{0:0.000000}", point.Lng);
                if (GMRouteMission != null)
                {
                    if (GMRouteMission.Points.Count >= 1)
                    {
                        double dist_from_last = MainMap.MapProvider.Projection.GetDistance(GMRouteMission.Points[GMRouteMission.Points.Count - 1], point);
                       // lDistLastWP.Text = String.Format("Dist. from last WP:{0:n1}m", dist_from_last * 1000);
                    }
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
            {
                return;
            }

            //dragging
            if (e.Button == MouseButtons.Left && isMouseDown && Control.ModifierKeys == Keys.None)
            {
                isMouseDragging = true;
                if (CurrentRectMarker == null) // left click pan
                {
                    double latdif = start.Lat - point.Lat;
                    double lngdif = start.Lng - point.Lng;
                    MainMap.Position = new PointLatLng(center.Position.Lat + latdif, center.Position.Lng + lngdif);
                    StartLat.Text = String.Format("{0:0.000000}", MainMap.Position.Lat); // zzz
                    StartLon.Text = String.Format("{0:0.000000}", MainMap.Position.Lng);
                }
                else
                {
                    PointLatLng pnew = MainMap.FromLocalToLatLng(e.X, e.Y);

                    int? pIndex = (int?)CurrentRectMarker.Tag;
                    if (pIndex.HasValue)
                    {
                        if (pIndex < GMRouteMission.Points.Count)
                        {
                            GMRouteMission.Points[pIndex.Value] = pnew;
                            MainMap.UpdateRouteLocalPosition(GMRouteMission);
                            DistanceLabel.Text = String.Format("Mission total dist.:{0:n1}m", GMRouteMission.Distance * 1000);

                            if (pIndex == 0) //Dragging the first marker
                            {
                                if (GMRouteMission.Points.Count > 1)  //We have more than 1 WP
                                {
                                    double dist_from_last = MainMap.MapProvider.Projection.GetDistance(GMRouteMission.Points[1], point);
                                //    lDistLastWP.Text = String.Format("Dist. from last WP:{0:n1}m", dist_from_last * 1000);
                                }
                            }
                            else //Drag some other marker
                            {
                                double dist_from_last = MainMap.MapProvider.Projection.GetDistance(GMRouteMission.Points[Convert.ToInt32(pIndex - 1)], point);
                              //  lDistLastWP.Text = String.Format("Dist. from prev. WP:{0:n1}m", dist_from_last * 1000);
                            }
                        }
                    }

                    if (currentMarker.IsVisible)
                        currentMarker.Position = pnew;

                    CurrentRectMarker.Position = pnew;

                    if (CurrentRectMarker.InnerMarker != null)
                        CurrentRectMarker.InnerMarker.Position = pnew;
                }
            }

        }

        private void MapProviderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            //MainMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            MainMap.MapProvider = (GMapProvider)MapProviderComboBox.SelectedItem;
            MainMap.MinZoom = 5;
            MainMap.MaxZoom = 20;
            MainMap.Zoom = 18;
            MainMap.Invalidate(false);
            //zzz   gui_settings.iMapProviderSelectedIndex = MapProviderComboBox.SelectedIndex;
            //zzz   gui_settings.save_to_xml(sGuiSettingsFilename);

            this.Cursor = Cursors.Default;

        }

        //_______________________________________________________________________________________

        // Fetch Map

        private void FetchMapTilesContextMenuItem_Click(object sender, EventArgs e)
        {
            fetch_map();
        }

        private void fetch_map()
        {
            RectLatLng area = MainMap.SelectedArea;
            if (area.IsEmpty)
            {
                DialogResult res = MessageBox.Show("No rip area defined, ripp displayed on screen?", "Rip", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    area = MainMap.ViewArea;
                }
            }

            if (!area.IsEmpty)
            {
                DialogResult res = MessageBox.Show("Ready rip at Zoom = " + (int)MainMap.Zoom + " ?", "GMap.NET", MessageBoxButtons.YesNo);

                for (int i = 1; i <= MainMap.MaxZoom; i++)
                {
                    if (res == DialogResult.Yes)
                    {
                        TilePrefetcher obj = new TilePrefetcher();
                        obj.ShowCompleteMessage = false;
                        obj.Start(area, i, MainMap.MapProvider, 100, 0);

                    }
                    else if (res == DialogResult.No)
                    {
                        continue;
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select map area holding ALT", "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        } // fetch_map


        //_______________________________________________________________________________________

        // GMap Classes

        public class GMapMarkerRect : GMapMarker
        {
            public Pen Pen = new Pen(Brushes.White, 2);
            public Color Color { get { return Pen.Color; } set { Pen.Color = value; } }
            public GMapMarker InnerMarker;
            public int wprad = 0;
            public GMapControl MainMap;

            public GMapMarkerRect(PointLatLng p)
                : base(p)
            {
                Pen.DashStyle = DashStyle.Dot;
                Size = new System.Drawing.Size(50, 50);
                Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2 - 20);
            }

            public override void OnRender(Graphics g)
            {
                base.OnRender(g);

                if (wprad == 0 || MainMap == null)
                    return;

                // undo autochange in mouse over
                if (Pen.Color == Color.Blue)
                    Pen.Color = Color.White;

                double width = (MainMap.MapProvider.Projection.GetDistance(MainMap.FromLocalToLatLng(0, 0), MainMap.FromLocalToLatLng(MainMap.Width, 0)) * 1000.0);
                double height = (MainMap.MapProvider.Projection.GetDistance(MainMap.FromLocalToLatLng(0, 0), MainMap.FromLocalToLatLng(MainMap.Height, 0)) * 1000.0);
                double m2pixelwidth = MainMap.Width / width;
                double m2pixelheight = MainMap.Height / height;

                GPoint loc = new GPoint((int)(LocalPosition.X - (m2pixelwidth * wprad * 2)), LocalPosition.Y);// MainMap.FromLatLngToLocal(wpradposition);
                try
                {
                    g.DrawArc(Pen, new System.Drawing.Rectangle((int)(LocalPosition.X - Offset.X - (Math.Abs(loc.X - LocalPosition.X) / 2)), (int)(LocalPosition.Y - Offset.Y - Math.Abs(loc.X - LocalPosition.X) / 2), (int)(Math.Abs(loc.X - LocalPosition.X)), (int)(Math.Abs(loc.X - LocalPosition.X))), 0, 360);
                }
                catch
                {
                    MessageBox.Show("OnRender", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }

            }
        }


        public class GMapMarkerCopter : GMapMarker
        {

            static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(Properties.Resources.marker_quadx.Width, Properties.Resources.marker_quadx.Height);
            float Heading = 0;
            float CourseOverGround = -1;
            float WPBearing = -1;
            byte coptertype;

            public GMapMarkerCopter(PointLatLng p, float Heading, float CourseOverGround, float WPBearing, byte coptertype)
                : base(p)
            {
                this.Heading = Heading;
                this.CourseOverGround = CourseOverGround;
                this.WPBearing = WPBearing;
                this.coptertype = coptertype;
                Size = SizeSt;
            }

            public override void OnRender(Graphics g)
            {
                Matrix PrevTransform = g.Transform;
                g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
                double v;
                Image pic;

                /*
                 * 
                 *   "Tricopter",
            "Coax Tri (Y6)",
            "VTail (Y4)",
            "Quadcopter",
            "X Quadcopter",
            "Coax Quad",
            "X Coax Quad",
            "Hexacopter",
            "X Hexacopter",
            "Octocopter",9
            "X Octocopter",10
            "Heli 90", 11
            "Heli 120", 12
            "Flying Wing",13
            "Aircraft",14
            "VTOL",15
            "Gimbal",16
            "Unknown" };
                 * */

                switch (FormMain.AirframeT)
                {
                 case 0:
                        pic = Properties.Resources.marker_tri;
                        break;
                    case 1:
                        pic = Properties.Resources.marker_tri;
                        break;

                   case 2:
                        pic = Properties.Resources.marker_vtail4;
                        break;
 
                    case 3:
                        pic = Properties.Resources.marker_quadp;
                        break;
                    case 4:
                        pic = Properties.Resources.marker_quadx;
                        break;

                    case 5:
                        pic = Properties.Resources.marker_quadp;
                        break;
                    case 6:
                        pic = Properties.Resources.marker_quadx;
                        break;

                    case 7:
                        pic = Properties.Resources.marker_hex6p;
                        break;
                    case 8:
                        pic = Properties.Resources.marker_hex6x;
                        break;

                    case 9:
                        pic = Properties.Resources.marker_oktoflatp;
                        break;
              //      case 10:
              //          pic = Properties.Resources.marker_oktoflatx;
              //          break;

                    case 11:
                        pic = Properties.Resources.marker_heli;
                        break;
                    case 12:
                        pic = Properties.Resources.marker_heli;
                        break;

                    case 13:
                        pic = Properties.Resources.marker_fwing;
                        break;
                    case 14:
                        pic = Properties.Resources.marker_airplane;
                        break;

                    case 15:
                        pic = Properties.Resources.marker_bi;
                        break;

                    default:
                        pic = Properties.Resources.marker_quadx;
                        break;
                }
            /*  
                if ((byte)AirframeT == 4)
                    pic = Properties.Resources.marker_quadx;
                else
                    pic = Properties.Resources.marker_airplane;
*/
                int length = 100;
                // anti NaN
                v = Heading - 90.0 * DegToRad;
                g.DrawLine(new Pen(Color.Red, 2), 0.0f, 0.0f, (float)Math.Cos(v) * length, (float)Math.Sin(v) * length);

                //g.DrawLine(new Pen(Color.Black, 2), 0.0f, 0.0f, (float)Math.Cos(CourseOverGround - 90.0 * DegToRad) * length, (float)Math.Sin((CourseOverGround - 90) * DegToRad) * length);

                //if (WPDistance > 2.5)
                {
                    v = WPBearing - 90.0 * DegToRad;
                    g.DrawLine(new Pen(Color.Orange, 2), 0.0f, 0.0f, (float)Math.Cos(v) * length, (float)Math.Sin(v) * length);
                }

                // anti NaN
                g.RotateTransform(Heading * (float)RadToDeg);
                g.DrawImage(pic, pic.Width / -2, pic.Height / -2, pic.Width, pic.Height);

                //g.DrawImageUnscaled(pic, pic.Width / -2, pic.Height / -2);

                g.Transform = PrevTransform; // restore transform
            }
        }
        public class GMapMarkerFlyHere : GMapMarker
        {
            static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(Properties.Resources.home_marker.Width, Properties.Resources.home_marker.Height);

            public GMapMarkerFlyHere(PointLatLng p)
                : base(p)
            {
                Size = SizeSt;
            }

            public override void OnRender(Graphics g)
            {
                Matrix PrevTransform = g.Transform;
                g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
                Image pic = Properties.Resources.flight_here;
                g.DrawImageUnscaled(pic, pic.Width / -2 - 4, -pic.Height - 14);
                g.Transform = PrevTransform;

            }
        }

        public class GMapMarkerHome : GMapMarker
        {
            static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(Properties.Resources.home_marker.Width, Properties.Resources.home_marker.Height);

            public GMapMarkerHome(PointLatLng p)
                : base(p)
            {
                Size = SizeSt;
            }

            public override void OnRender(Graphics g)
            {
                Matrix PrevTransform = g.Transform;
                g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
                Image pic = Properties.Resources.home_marker;
                g.DrawImageUnscaled(pic, pic.Width / -2 - 4, -pic.Height - 14);
                g.Transform = PrevTransform;

            }
        }

        public class GMapMarkerMissionStep : GMapMarker
        {
            static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(Properties.Resources.marker_poi.Width, Properties.Resources.marker_poi.Height);
            private byte number;
            private FormMain.NavComs markertype;
            public GMapMarkerMissionStep(PointLatLng p, byte id, byte type)
                : base(p)
            {
                Size = SizeSt;
                number = id;
                markertype = (FormMain.NavComs)type;
            }

            public override void OnRender(Graphics g)
            {
                Image pic;
                Matrix PrevTransform = g.Transform;
                g.TranslateTransform(LocalPosition.X, LocalPosition.Y);


                System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericMonospace, 9.0F, FontStyle.Bold);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
             
                // Set graphics
                switch ((FormMain.NavComs)markertype)
                {
                    case FormMain.NavComs.navVia:
                        pic = Properties.Resources.timed_marker;
                        drawBrush.Color = Color.Yellow;
                        g.DrawString("VIA", drawFont, drawBrush, -12, -51);
                        drawBrush.Color = Color.White;
                        break;
                    case FormMain.NavComs.navOrbit:
                        pic = Properties.Resources.timed_marker;
                        drawBrush.Color = Color.Yellow;
                        g.DrawString("ORB", drawFont, drawBrush, -12, -51);
                        drawBrush.Color = Color.White;
                        break;
                    case FormMain.NavComs.navPOI:
                        pic = Properties.Resources.marker_poi;
                        break;
                    case FormMain.NavComs.navLand:
                        pic = Properties.Resources.marker_land;
                        drawBrush.Color = Color.Yellow;
                        g.DrawString("LND", drawFont, drawBrush, -12, -51);
                        drawBrush.Color = Color.White;
                        break;
                    case FormMain.NavComs.navPerch:
                        pic = Properties.Resources.marker_land;
                        drawBrush.Color = Color.Yellow;
                        g.DrawString("PCH", drawFont, drawBrush, -12, -51);
                        drawBrush.Color = Color.White;
                        break;
                    default:
                        pic = Properties.Resources.timed_marker;
                        break;
                }

                g.DrawImageUnscaled(pic, pic.Width / -2 - 4, -pic.Height - 14);

                if (number < 10) g.DrawString(String.Format("{0:0}", number), drawFont, drawBrush, -5, -40);
                if (number < 100 && number > 9) g.DrawString(String.Format("{0:0}", number), drawFont, drawBrush, -8, -40);
                if (number > 100) g.DrawString(String.Format("{0:0}", number), drawFont, drawBrush, -12, -40);

                g.Transform = PrevTransform;

            }
        }

        public class Stuff
        {
            public static bool PingNetwork(string hostNameOrAddress)
            {
                bool pingStatus = false;

                using (Ping p = new Ping())
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                    int timeout = 4444; // 4s

                    try
                    {
                        PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                        pingStatus = (reply.Status == IPStatus.Success);
                    }
                    catch (Exception)
                    {
                        pingStatus = false;
                    }
                }

                return pingStatus;
            }
        }

        //_______________________________________________________________________________________

        // Mission Load & Save to file

        private void SaveMissionButton_Click(object sender, EventArgs e)
        {
            int rowM;

            timer_updatemap.Enabled = false;

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = ""; // "Mission Files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.InitialDirectory = Properties.Settings.Default.MissionDirectory;

            dlg.FileName = "Mission_" +
              DateTime.Now.Year + "_" +
              DateTime.Now.Month + "_" +
              DateTime.Now.Day + "_" +
              DateTime.Now.Hour + "_" +
              DateTime.Now.Minute;


/*
            string path = Path.GetTempPath() + Path.GetRandomFileName() + @".png";
            _tmpImage = View.g.ToImage();
            if (_tmpImage == null) return;
            _tmpImage.Save(path);

            PrintDocument doc = new PrintDocument { DocumentName = "Map printing file" };
            doc.PrintPage += DocOnPrintPage;
            PrintDialog dialog = new PrintDialog { Document = doc };
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) doc.Print();
*/
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(MainMap.Width, MainMap.Height);
                MainMap.DrawToBitmap(bmp, MainMap.Bounds);
                bmp.Save(dlg.FileName + ".bmp");

                System.IO.FileStream MissionFileStream = new System.IO.FileStream(dlg.FileName + ".txt", System.IO.FileMode.Create);
                System.IO.StreamWriter MissionFileStreamWriter = new System.IO.StreamWriter(MissionFileStream, System.Text.Encoding.ASCII);

                MissionFileStreamWriter.WriteLine("OPTIONS:" + ProximityRadiusTextBox.Text
                    + "," + ProximityAltTextBox.Text
                    + "," + FenceRadiusTextBox.Text
                    + "," + AltitudeOverTerrainCheckBox.Checked
                    + "," + MapZoomNumericUpDown.Value.ToString());

                MissionFileStreamWriter.WriteLine("HOME:"
                    + StartLat.Text
                    + "," + StartLon.Text
                    );

                for (rowM = 0; rowM < M.Rows.Count; rowM++)
                    MissionFileStreamWriter.WriteLine(
                    rowM - 1
                    +"," + M[mLat, rowM].Value
                    + "," + M[mLon, rowM].Value
                    + "," + M[mAlt, rowM].Value
                    + "," + M[mAltOff, rowM].Value
                    + "," + M[mAltSL, rowM].Value
                    + "," + M[mVel, rowM].Value
                    + "," + M[mLoiter, rowM].Value // Loiter
                    + "," + M[mAction, rowM].Value // Action
                    + "," + M[mPR, rowM].Value // OrbitRadius
                    + "," + M[mPV, rowM].Value // OrbitVelocitydMpS
                    );

                MissionFileStreamWriter.Flush();
                MissionFileStreamWriter.Close();
              //zzz  MissionFileStream.Close();

                Application.DoEvents();
                //      Bitmap b = new Bitmap(webBrowser1.ClientSize.Width, webBrowser1.ClientSize.Height);
                //       Graphics g = Graphics.FromImage(b);
                //        g.CopyFromScreen(webBrowser1.Parent.PointToScreen(webBrowser1.Location),
                //           new Point(0, 0), webBrowser1.ClientSize);
                //       b.Save(dlg.FileName.Substring(0, dlg.FileName.Length - 3) + "png");

             Properties.Settings.Default.LastMissionLoaded = dlg.FileName;
            }

            timer_updatemap.Enabled = true;

        } // MenuSaveMission_Click


        private void LoadMissionButton_Click(object sender, EventArgs e)
        {
            string sLinesFromFile;
            string sValue;
            int rowM;
            char[] newline = { '\n' };
            char[] comma = { ',' };

            timer_updatemap.Enabled = false;
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = "txt";
            dlg.InitialDirectory = Properties.Settings.Default.ParamDirectory;
            dlg.Multiselect = false;
            dlg.CheckFileExists = true;
            dlg.Title = "Load Mission File";
            dlg.AddExtension = true;
            dlg.Filter = "Mission Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                M.Rows.Clear();

                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                try
                {
                    sLastLoaded = dlg.FileName;
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] bytes = new byte[fileStream.Length];
                    int numBytesToRead = (int)fileStream.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fileStream.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                    sLinesFromFile = enc.GetString(bytes);
                    string[] values = sLinesFromFile.Split('\n');
                    string sObjType;
                    double nLat;
                    double nLon;

                    for (rowM = 0; rowM < values.Length - 1; rowM++)
                    {
                        //rowM = wp - 1;
                        sValue = values[rowM].Substring(values[rowM].IndexOf(":") + 1);
                        sValue = sValue.Substring(0, sValue.Length - 1);

                        string[] sParam = sValue.Split(comma);
                        sObjType = "";
                        if (values[rowM].IndexOf(":") != -1)
                            sObjType = values[rowM].Substring(0, values[rowM].IndexOf(":"));

                        if (rowM % 1 == 0)
                            Application.DoEvents();

                        switch (sObjType)
                        {
                            case "OPTIONS":
                                ProximityRadiusTextBox.Text = string.Format("{0:n0}", Convert.ToInt16(sParam[0]));
                                ProximityAltTextBox.Text = string.Format("{0:n0}", Convert.ToInt16(sParam[1]));
                                FenceRadiusTextBox.Text = string.Format("{0:n0}", Convert.ToInt16(sParam[2]));
                                AltitudeOverTerrainCheckBox.Checked = Convert.ToBoolean(sParam[3]);
                 
                                if (sParam.GetUpperBound(0) >= 4)
                                    MapZoomNumericUpDown.Value = Convert.ToInt32(sParam[4]);

                                Properties.Settings.Default.ProximityRadius = Convert.ToByte(sParam[0]);
                                Properties.Settings.Default.ProximityAltitude = Convert.ToByte(sParam[1]);
                                Properties.Settings.Default.FenceRadius = Convert.ToInt16(sParam[2]);
                                Properties.Settings.Default.AltitudeOverTerrain = AltitudeOverTerrainCheckBox.Checked;

                                break;
                            case "HOME":
                                double.TryParse(sParam[0], System.Globalization.NumberStyles.Float,
                                     System.Globalization.CultureInfo.GetCultureInfo("en-US"), out nLat);
                                double.TryParse(sParam[1], System.Globalization.NumberStyles.Float,
                                    System.Globalization.CultureInfo.GetCultureInfo("en-US"), out nLon);
                                StartLat.Text = Convert.ToString(nLat);
                                StartLon.Text = Convert.ToString(nLon);
                                break;
                            default:
                                if (M.Rows.Count <= FormMain.MaxWayPoints - 1)
                                {
                                    double.TryParse(sParam[1], System.Globalization.NumberStyles.Float,
                                        System.Globalization.CultureInfo.GetCultureInfo("en-US"), out nLat);
                                    double.TryParse(sParam[2], System.Globalization.NumberStyles.Float,
                                        System.Globalization.CultureInfo.GetCultureInfo("en-US"), out nLon);

                                    ClickMapLabel.Visible = false;
                                    M.Rows.Add();

                                    int np = M.Rows.Count - 1;
                                    M[mWP, np].Value = M.Rows.Count;
                                    M[mLat, np].Value = Convert.ToString(nLat);
                                    M[mLon, np].Value = Convert.ToString(nLon);
                                    M[mAlt, np].Value = string.Format("{0:n0}", Convert.ToDouble(sParam[mAlt]));
                                    M[mAltOff, np].Value = string.Format("{0:n0}", Convert.ToDouble((sParam[mAltOff])));
                                    M[mAltSL, np].Value = string.Format("{0:n0}", sParam[mAltSL]);
                                    M[mVel, np].Value = string.Format("{0:n1}", sParam[mVel]);
                                    M[mLoiter, np].Value = string.Format("{0:n0}", sParam[mLoiter]);
                                    M[mAction, np].Value = sParam[mAction];
                                    M[mPR, np].Value = string.Format("{0:n0}", sParam[mPR]);
                                    M[mPV, np].Value = string.Format("{0:n1}", sParam[mPV]);
                                }
                                else
                                {
                                    MessageBox.Show("Too many WP selected.\nUAVX can currently can handle up to " +
                                    FormMain.MaxWayPoints.ToString() + " WP.", "Max WP",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    timer_updatemap.Enabled = true;
                                }
                                break;
                        }
                    }
                }
                finally
                {
                    timer_updatemap_Tick(sender, e);
                    fileStream.Close();
                    FormMain.Mission.NoOfWayPoints = Convert.ToByte(M.Rows.Count);
                }
            }

            timer_updatemap.Enabled = true;

        } // MenuLoadMission_Click


        //_______________________________________________________________________________________

        // UAVX Download & Upload Current Mission

        private void UAVXReadButton_Click(object sender, EventArgs e)
        {
            timer_updatemap.Enabled = false;
            UAVXDownloadMission();
            timer_updatemap.Enabled = true;
        } // MenuRead_Click

        private void UAVXWriteButton_Click(object sender, EventArgs e)
        {
            timer_updatemap.Enabled = false;
            CreateUploadMission();
            FormMain.SendMission();
            timer_updatemap.Enabled = true;

        } // MenuWrite_Click

        void UAVXDownloadMission()
        {
           FormMain.SendRequestPacket(FormMain.UAVXMissionPacketTag, 0, 0);
           UAVXReadButton.BackColor = System.Drawing.Color.Orange;
        } // UAVXDownloadMission


        void UAVXDownload()
        {
            int wp, rowM;


            ProximityRadiusTextBox.Text = string.Format("{0:n0}", FormMain.Mission.ProximityRadius);
            ProximityAltTextBox.Text = string.Format("{0:n0}", FormMain.Mission.ProximityAltitude);
            FenceRadiusTextBox.Text = string.Format("{0:n0}", FormMain.Mission.FenceRadius);

            double nLat, nLon;

            double.TryParse(Convert.ToString((double)FormMain.Mission.OriginLatitude * 1e-7),
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.GetCultureInfo("en-US"), out nLat);
            double.TryParse(Convert.ToString((double)FormMain.Mission.OriginLongitude * 1e-7),
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.GetCultureInfo("en-US"), out nLon);

            if (nLat != 0)
                StartLat.Text = nLat.ToString();

            if (nLon != 0)
                StartLon.Text = nLon.ToString();

            StartLat_Leave(null, null);
            StartLon_Leave(null, null);

            M.Rows.Clear();
            for (wp = 1; wp <= FormMain.Mission.NoOfWayPoints; wp++)
            {
                rowM = wp - 1;
                nLat = (double)FormMain.WP[wp].LatitudeRaw * (double)1e-7;
                nLon = (double)FormMain.WP[wp].LongitudeRaw * (double)1e-7;
                ClickMapLabel.Visible = false;
                M.Rows.Add();
                M[mWP, rowM].Value = Convert.ToString(wp);
                M[mLat, rowM].Value = Convert.ToString((double)FormMain.WP[wp].LatitudeRaw * (double)1e-7);
                M[mLon, rowM].Value = Convert.ToString((double)FormMain.WP[wp].LongitudeRaw * (double)1e-7);

                M[mAlt, rowM].Value = string.Format("{0:n0}", FormMain.WP[wp].Altitude);
                M[mAltSL, rowM].Value = Convert.ToString(GetAltitudeData(nLat, nLon));
                M[mAltOff, rowM].Value = string.Format("{0:n0}", FormMain.WP[wp].Altitude - Convert.ToDouble(M[mAltOff, rowM].Value));

                M[mVel, rowM].Value = string.Format("{0:n1}", FormMain.WP[wp].Velocity);
                M[mLoiter, rowM].Value = string.Format("{0:n0}", FormMain.WP[wp].Loiter);
                M[mAction, rowM].Value = string.Format("{0:n0}", FormMain.NavComNames[FormMain.WP[wp].Action]);
                M[mPR, rowM].Value = string.Format("{0:n0}", FormMain.WP[wp].OrbitRadius);
                M[mPV, rowM].Value = string.Format("{0:n1}", FormMain.WP[wp].OrbitVelocity);
            }

            UAVXWriteButton.BackColor = UAVXReadButton.BackColor = System.Drawing.Color.Green;

        } // UAVXDownload


        void CreateUploadMission()
        {
            int UAVXWPLat, UAVXWPLon;
            short UAVXWPAlt;
            int wp, rowM;

            try
            {
                Properties.Settings.Default.LastMissionLoaded = sLastLoaded;

                //COnverting general variables
                FormMain.Mission.ProximityRadius = Convert.ToByte(Convert.ToDouble(ProximityRadiusTextBox.Text));
                FormMain.Mission.ProximityAltitude = Convert.ToByte(Convert.ToDouble(ProximityAltTextBox.Text));
                FormMain.Mission.FenceRadius = Convert.ToInt16(Convert.ToDouble(FenceRadiusTextBox.Text));

                UAVXOptions &= 0;

                FormMain.Mission.NoOfWayPoints = (byte)M.Rows.Count;

                for (wp = 1; wp <= FormMain.Mission.NoOfWayPoints; wp++)
                {
                    rowM = wp - 1;
                    UAVXWPLat = (int)(Convert.ToDouble(M[mLat, rowM].Value) * (double)1e7);
                    UAVXWPLon = (int)(Convert.ToDouble(M[mLon, rowM].Value) * (double)1e7);
                    UAVXWPAlt = (short)Convert.ToDouble(M[mAlt, rowM].Value);

                    FormMain.WP[wp].LatitudeRaw = UAVXWPLat;
                    FormMain.WP[wp].LongitudeRaw = UAVXWPLon;
                    FormMain.WP[wp].Altitude = (short)UAVXWPAlt;

                    FormMain.WP[wp].Velocity = Convert.ToDouble(M[mVel, rowM].Value);
                    FormMain.WP[wp].Loiter = Convert.ToInt16(M[mLoiter, rowM].Value);

                    FormMain.WP[wp].Action = Convert.ToByte(Array.IndexOf(FormMain.NavComNames, Convert.ToString(M[mAction, rowM].Value)));
                    //FindIndex(Convert.ToString(M[mAction, rowM].Value));

                    FormMain.WP[wp].OrbitRadius = Convert.ToInt16(M[mPR, rowM].Value);
                    FormMain.WP[wp].OrbitVelocity = Convert.ToDouble(M[mPV, rowM].Value);
                }

            }
            catch (Exception er)
            {
                //MessageBox.Show(Convert.ToString(er.Message));
                //RxLabel.Text = Convert.ToString(er.Message);
            }
        } // UAVXUploadMission

        private byte FindIndex(string a)
        { // clumsy - must be a function that returns index for a combobox?
            int index = -1;
            do { } while (FormMain.NavComNames[++index] != a);

            return (Convert.ToByte(index));
        } // FindIndex

        private void NavForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // if (false) //serialPort1.IsOpen)
           // {
              //  e.Cancel = true; //cancel the fom closing
              //  Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit)); //close port in new thread to avoid hang
              //  CloseDown.Start(); //close port in new thread to avoid hang
          //  }
          //  else
          //      this.Close();
        }

        private void CloseSerialOnExit()
        {
            try
            {
                // serialPort1.Close(); //close the serial port
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //catch any serial port closing error messages
            }
            this.Invoke(new EventHandler(NowClose)); //now close back in the main thread
        }

        private void NowClose(object sender, EventArgs e)
        {
           // this.Close(); //now close the form
        }


    }

}