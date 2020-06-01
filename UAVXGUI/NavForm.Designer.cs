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
using System.Xml; // config file
using System.Net;
using System.Net.Sockets;

using System.Security.Cryptography.X509Certificates;
//zzzusing ZedGraph; // Graphs
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;


namespace UAVXGUI
{
    partial class NavForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support-do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavForm));
            this.SaveLogFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.OriginGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowMissionCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowFlightPathCheckBox = new System.Windows.Forms.CheckBox();
            this.MapCentreButton = new System.Windows.Forms.Button();
            this.MapProviderComboBox = new System.Windows.Forms.ComboBox();
            this.ShowWPCheckBox = new System.Windows.Forms.CheckBox();
            this.StartLonLabel = new System.Windows.Forms.Label();
            this.StartLatLabel = new System.Windows.Forms.Label();
            this.StartLat = new System.Windows.Forms.TextBox();
            this.CentreCurrPositionCheckBox = new System.Windows.Forms.CheckBox();
            this.StartLon = new System.Windows.Forms.TextBox();
            this.MapZoomLabel = new System.Windows.Forms.Label();
            this.MapZoomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AltitudeOverTerrainCheckBox = new System.Windows.Forms.CheckBox();
            this.DefAltitudeLabel = new System.Windows.Forms.Label();
            this.LocationAddress = new System.Windows.Forms.TextBox();
            this.LoiterTimeLabel = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hidden_Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeaLevelAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OrbitRad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrbitVel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PulseWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PulsePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.GoToCheckBox = new System.Windows.Forms.CheckBox();
            this.ProxRadiusLabel = new System.Windows.Forms.Label();
            this.ProximityRadiusTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UAVXWriteButton = new System.Windows.Forms.Button();
            this.UAVXReadButton = new System.Windows.Forms.Button();
            this.ProximityAltTextBox = new System.Windows.Forms.TextBox();
            this.ClickMapLabel = new System.Windows.Forms.Label();
            this.FenceRadiusLabel = new System.Windows.Forms.Label();
            this.FenceRadiusTextBox = new System.Windows.Forms.TextBox();
            this.ProximityAltLabel = new System.Windows.Forms.Label();
            this.PerchContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViaContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrbitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.POIContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TMRContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.WPDeleteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMissionContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FetchMapTilesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MousePosLabel = new System.Windows.Forms.Label();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OfflineMapLabel = new System.Windows.Forms.Label();
            this.WPDefaultsGroupBox = new System.Windows.Forms.GroupBox();
            this.DefaultLoiterTextBox = new System.Windows.Forms.TextBox();
            this.DefaultAltTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer_updatemap = new System.Windows.Forms.Timer(this.components);
            this.LoadMissionButton = new System.Windows.Forms.Button();
            this.SaveMissionButton = new System.Windows.Forms.Button();
            this.CurrentAltitude = new System.Windows.Forms.TextBox();
            this.WindDirectionTextBox = new System.Windows.Forms.TextBox();
            this.WindSpeedTextBox = new System.Windows.Forms.TextBox();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.WindDirectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.OriginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapZoomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).BeginInit();
            this.contextMenuStripMap.SuspendLayout();
            this.WPDefaultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(7, 31);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 20;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(956, 476);
            this.MainMap.TabIndex = 163;
            this.MainMap.Zoom = 0D;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceLabel.ForeColor = System.Drawing.Color.Black;
            this.DistanceLabel.Location = new System.Drawing.Point(15, 38);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(53, 19);
            this.DistanceLabel.TabIndex = 177;
            this.DistanceLabel.Text = "Distance";
            this.DistanceLabel.UseCompatibleTextRendering = true;
            // 
            // OriginGroupBox
            // 
            this.OriginGroupBox.Controls.Add(this.ShowMissionCheckBox);
            this.OriginGroupBox.Controls.Add(this.ShowFlightPathCheckBox);
            this.OriginGroupBox.Controls.Add(this.MapCentreButton);
            this.OriginGroupBox.Controls.Add(this.MapProviderComboBox);
            this.OriginGroupBox.Controls.Add(this.ShowWPCheckBox);
            this.OriginGroupBox.Controls.Add(this.StartLonLabel);
            this.OriginGroupBox.Controls.Add(this.StartLatLabel);
            this.OriginGroupBox.Controls.Add(this.StartLat);
            this.OriginGroupBox.Controls.Add(this.CentreCurrPositionCheckBox);
            this.OriginGroupBox.Controls.Add(this.StartLon);
            this.OriginGroupBox.Controls.Add(this.MapZoomLabel);
            this.OriginGroupBox.Controls.Add(this.MapZoomNumericUpDown);
            this.OriginGroupBox.Location = new System.Drawing.Point(7, 513);
            this.OriginGroupBox.Name = "OriginGroupBox";
            this.OriginGroupBox.Size = new System.Drawing.Size(218, 142);
            this.OriginGroupBox.TabIndex = 24;
            this.OriginGroupBox.TabStop = false;
            this.OriginGroupBox.Text = "Locate";
            // 
            // ShowMissionCheckBox
            // 
            this.ShowMissionCheckBox.AutoSize = true;
            this.ShowMissionCheckBox.Checked = true;
            this.ShowMissionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowMissionCheckBox.Location = new System.Drawing.Point(9, 95);
            this.ShowMissionCheckBox.Name = "ShowMissionCheckBox";
            this.ShowMissionCheckBox.Size = new System.Drawing.Size(61, 17);
            this.ShowMissionCheckBox.TabIndex = 171;
            this.ShowMissionCheckBox.Text = "Mission";
            this.ShowMissionCheckBox.UseVisualStyleBackColor = true;
            this.ShowMissionCheckBox.CheckedChanged += new System.EventHandler(this.ShowMissionCheckBox_CheckedChanged);
            // 
            // ShowFlightPathCheckBox
            // 
            this.ShowFlightPathCheckBox.AutoSize = true;
            this.ShowFlightPathCheckBox.Checked = true;
            this.ShowFlightPathCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowFlightPathCheckBox.Location = new System.Drawing.Point(76, 96);
            this.ShowFlightPathCheckBox.Name = "ShowFlightPathCheckBox";
            this.ShowFlightPathCheckBox.Size = new System.Drawing.Size(54, 17);
            this.ShowFlightPathCheckBox.TabIndex = 174;
            this.ShowFlightPathCheckBox.Text = "Track";
            this.ShowFlightPathCheckBox.UseVisualStyleBackColor = true;
            this.ShowFlightPathCheckBox.CheckedChanged += new System.EventHandler(this.ShowFlightPathCheckBox_CheckedChanged);
            // 
            // MapCentreButton
            // 
            this.MapCentreButton.Location = new System.Drawing.Point(132, 12);
            this.MapCentreButton.Name = "MapCentreButton";
            this.MapCentreButton.Size = new System.Drawing.Size(74, 23);
            this.MapCentreButton.TabIndex = 48;
            this.MapCentreButton.Text = "Map Centre";
            this.MapCentreButton.UseVisualStyleBackColor = true;
            this.MapCentreButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MapProviderComboBox
            // 
            this.MapProviderComboBox.FormattingEnabled = true;
            this.MapProviderComboBox.Location = new System.Drawing.Point(9, 69);
            this.MapProviderComboBox.Name = "MapProviderComboBox";
            this.MapProviderComboBox.Size = new System.Drawing.Size(197, 21);
            this.MapProviderComboBox.TabIndex = 53;
            this.MapProviderComboBox.Text = "BingHybridMap";
            this.MapProviderComboBox.SelectedIndexChanged += new System.EventHandler(this.MapProviderComboBox_SelectedIndexChanged);
            // 
            // ShowWPCheckBox
            // 
            this.ShowWPCheckBox.AutoSize = true;
            this.ShowWPCheckBox.Checked = true;
            this.ShowWPCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowWPCheckBox.Location = new System.Drawing.Point(9, 115);
            this.ShowWPCheckBox.Name = "ShowWPCheckBox";
            this.ShowWPCheckBox.Size = new System.Drawing.Size(49, 17);
            this.ShowWPCheckBox.TabIndex = 172;
            this.ShowWPCheckBox.Text = "WPs";
            this.ShowWPCheckBox.UseVisualStyleBackColor = true;
            this.ShowWPCheckBox.CheckedChanged += new System.EventHandler(this.ShowWPCheckBox_CheckedChanged);
            // 
            // StartLonLabel
            // 
            this.StartLonLabel.AutoSize = true;
            this.StartLonLabel.Location = new System.Drawing.Point(6, 43);
            this.StartLonLabel.Name = "StartLonLabel";
            this.StartLonLabel.Size = new System.Drawing.Size(31, 13);
            this.StartLonLabel.TabIndex = 27;
            this.StartLonLabel.Text = "Lon.:";
            // 
            // StartLatLabel
            // 
            this.StartLatLabel.AutoSize = true;
            this.StartLatLabel.Location = new System.Drawing.Point(5, 17);
            this.StartLatLabel.Name = "StartLatLabel";
            this.StartLatLabel.Size = new System.Drawing.Size(28, 13);
            this.StartLatLabel.TabIndex = 26;
            this.StartLatLabel.Text = "Lat.:";
            // 
            // StartLat
            // 
            this.StartLat.Location = new System.Drawing.Point(39, 14);
            this.StartLat.Name = "StartLat";
            this.StartLat.Size = new System.Drawing.Size(87, 20);
            this.StartLat.TabIndex = 3;
            this.StartLat.Text = "0.000000";
            this.StartLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartLat.TextChanged += new System.EventHandler(this.StartLat_TextChanged);
            this.StartLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartLat_KeyPress);
            this.StartLat.Leave += new System.EventHandler(this.StartLat_Leave);
            // 
            // CentreCurrPositionCheckBox
            // 
            this.CentreCurrPositionCheckBox.AutoSize = true;
            this.CentreCurrPositionCheckBox.Checked = true;
            this.CentreCurrPositionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CentreCurrPositionCheckBox.Location = new System.Drawing.Point(76, 115);
            this.CentreCurrPositionCheckBox.Name = "CentreCurrPositionCheckBox";
            this.CentreCurrPositionCheckBox.Size = new System.Drawing.Size(93, 17);
            this.CentreCurrPositionCheckBox.TabIndex = 183;
            this.CentreCurrPositionCheckBox.Text = "Centre Aircraft";
            this.CentreCurrPositionCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartLon
            // 
            this.StartLon.Location = new System.Drawing.Point(39, 40);
            this.StartLon.Name = "StartLon";
            this.StartLon.Size = new System.Drawing.Size(89, 20);
            this.StartLon.TabIndex = 4;
            this.StartLon.Text = "0.000000";
            this.StartLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartLon.TextChanged += new System.EventHandler(this.StartLon_TextChanged);
            this.StartLon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartLon_KeyPress);
            this.StartLon.Leave += new System.EventHandler(this.StartLon_Leave);
            // 
            // MapZoomLabel
            // 
            this.MapZoomLabel.AutoSize = true;
            this.MapZoomLabel.Location = new System.Drawing.Point(129, 43);
            this.MapZoomLabel.Name = "MapZoomLabel";
            this.MapZoomLabel.Size = new System.Drawing.Size(34, 13);
            this.MapZoomLabel.TabIndex = 183;
            this.MapZoomLabel.Text = "Zoom";
            // 
            // MapZoomNumericUpDown
            // 
            this.MapZoomNumericUpDown.Location = new System.Drawing.Point(166, 40);
            this.MapZoomNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MapZoomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MapZoomNumericUpDown.Name = "MapZoomNumericUpDown";
            this.MapZoomNumericUpDown.ReadOnly = true;
            this.MapZoomNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.MapZoomNumericUpDown.TabIndex = 44;
            this.MapZoomNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MapZoomNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.MapZoomNumericUpDown.TextChanged += new System.EventHandler(this.MapZoomNumericUpDown_Click);
            this.MapZoomNumericUpDown.Click += new System.EventHandler(this.MapZoomNumericUpDown_Click);
            // 
            // AltitudeOverTerrainCheckBox
            // 
            this.AltitudeOverTerrainCheckBox.AutoSize = true;
            this.AltitudeOverTerrainCheckBox.Location = new System.Drawing.Point(161, 387);
            this.AltitudeOverTerrainCheckBox.Name = "AltitudeOverTerrainCheckBox";
            this.AltitudeOverTerrainCheckBox.Size = new System.Drawing.Size(85, 17);
            this.AltitudeOverTerrainCheckBox.TabIndex = 30;
            this.AltitudeOverTerrainCheckBox.Text = "Over Terrain";
            this.AltitudeOverTerrainCheckBox.UseVisualStyleBackColor = true;
            this.AltitudeOverTerrainCheckBox.Visible = false;
            this.AltitudeOverTerrainCheckBox.CheckedChanged += new System.EventHandler(this.AltitudeOverTerrainitudeCheckBox_CheckedChanged);
            // 
            // DefAltitudeLabel
            // 
            this.DefAltitudeLabel.AutoSize = true;
            this.DefAltitudeLabel.Location = new System.Drawing.Point(6, 43);
            this.DefAltitudeLabel.Name = "DefAltitudeLabel";
            this.DefAltitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.DefAltitudeLabel.TabIndex = 188;
            this.DefAltitudeLabel.Text = "Def. Alt.";
            // 
            // LocationAddress
            // 
            this.LocationAddress.Location = new System.Drawing.Point(317, 414);
            this.LocationAddress.Name = "LocationAddress";
            this.LocationAddress.Size = new System.Drawing.Size(206, 20);
            this.LocationAddress.TabIndex = 46;
            this.LocationAddress.Visible = false;
            this.LocationAddress.TextChanged += new System.EventHandler(this.SearchAddressTextBox_TextChanged);
            this.LocationAddress.Enter += new System.EventHandler(this.SearchAddressTextBox_Enter);
            // 
            // LoiterTimeLabel
            // 
            this.LoiterTimeLabel.AutoSize = true;
            this.LoiterTimeLabel.Location = new System.Drawing.Point(6, 69);
            this.LoiterTimeLabel.Name = "LoiterTimeLabel";
            this.LoiterTimeLabel.Size = new System.Drawing.Size(56, 13);
            this.LoiterTimeLabel.TabIndex = 186;
            this.LoiterTimeLabel.Text = "Def. Loiter";
            // 
            // M
            // 
            this.M.AllowUserToAddRows = false;
            this.M.AllowUserToDeleteRows = false;
            this.M.AllowUserToResizeRows = false;
            this.M.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.M.BackgroundColor = System.Drawing.Color.White;
            this.M.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.M.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Lat,
            this.Lon,
            this.Altitude,
            this.Hidden_Alt,
            this.SeaLevelAlt,
            this.Velocity,
            this.Loiter,
            this.Action,
            this.OrbitRad,
            this.OrbitVel,
            this.PulseWidth,
            this.PulsePeriod,
            this.Up,
            this.Down,
            this.DEL});
            this.M.Location = new System.Drawing.Point(421, 518);
            this.M.Name = "M";
            this.M.RowHeadersVisible = false;
            this.M.Size = new System.Drawing.Size(542, 140);
            this.M.TabIndex = 1;
            this.M.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.M_CellContentClick);
            this.M.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.M_CellEndEdit);
            // 
            // Number
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number.DefaultCellStyle = dataGridViewCellStyle1;
            this.Number.Frozen = true;
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 20;
            // 
            // Lat
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Lat.DefaultCellStyle = dataGridViewCellStyle2;
            this.Lat.HeaderText = "Lat.";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lat.Width = 31;
            // 
            // Lon
            // 
            this.Lon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Lon.DefaultCellStyle = dataGridViewCellStyle3;
            this.Lon.HeaderText = "Lon.";
            this.Lon.Name = "Lon";
            this.Lon.ReadOnly = true;
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lon.Width = 34;
            // 
            // Altitude
            // 
            this.Altitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Altitude.DefaultCellStyle = dataGridViewCellStyle4;
            this.Altitude.HeaderText = "Alt";
            this.Altitude.Name = "Altitude";
            this.Altitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Altitude.Width = 25;
            // 
            // Hidden_Alt
            // 
            this.Hidden_Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.Hidden_Alt.DefaultCellStyle = dataGridViewCellStyle5;
            this.Hidden_Alt.HeaderText = "AOff";
            this.Hidden_Alt.Name = "Hidden_Alt";
            this.Hidden_Alt.ReadOnly = true;
            this.Hidden_Alt.Visible = false;
            // 
            // SeaLevelAlt
            // 
            this.SeaLevelAlt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            this.SeaLevelAlt.DefaultCellStyle = dataGridViewCellStyle6;
            this.SeaLevelAlt.HeaderText = "ASL";
            this.SeaLevelAlt.Name = "SeaLevelAlt";
            this.SeaLevelAlt.ReadOnly = true;
            this.SeaLevelAlt.Width = 52;
            // 
            // Velocity
            // 
            this.Velocity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Velocity.HeaderText = "V";
            this.Velocity.Name = "Velocity";
            this.Velocity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Velocity.Width = 20;
            // 
            // Loiter
            // 
            this.Loiter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Loiter.DefaultCellStyle = dataGridViewCellStyle7;
            this.Loiter.HeaderText = "T";
            this.Loiter.Name = "Loiter";
            this.Loiter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Loiter.Width = 20;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "Via",
            "Orbit",
            "Perch",
            "POI",
            "Survey"});
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.Width = 43;
            // 
            // OrbitRad
            // 
            this.OrbitRad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrbitRad.HeaderText = "R";
            this.OrbitRad.Name = "OrbitRad";
            this.OrbitRad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrbitRad.Width = 21;
            // 
            // OrbitVel
            // 
            this.OrbitVel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrbitVel.HeaderText = "V";
            this.OrbitVel.Name = "OrbitVel";
            this.OrbitVel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrbitVel.Width = 20;
            // 
            // PulseWidth
            // 
            this.PulseWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PulseWidth.HeaderText = "Width";
            this.PulseWidth.Name = "PulseWidth";
            this.PulseWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PulseWidth.Width = 41;
            // 
            // PulsePeriod
            // 
            this.PulsePeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PulsePeriod.HeaderText = "Period";
            this.PulsePeriod.Name = "PulsePeriod";
            this.PulsePeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PulsePeriod.Width = 43;
            // 
            // Up
            // 
            this.Up.HeaderText = "";
            this.Up.Image = global::UAVXGUI.Properties.Resources.up_btn;
            this.Up.Name = "Up";
            this.Up.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Up.Width = 5;
            // 
            // Down
            // 
            this.Down.HeaderText = "";
            this.Down.Image = global::UAVXGUI.Properties.Resources.down_btn;
            this.Down.Name = "Down";
            this.Down.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Down.Width = 5;
            // 
            // DEL
            // 
            this.DEL.HeaderText = "";
            this.DEL.Image = global::UAVXGUI.Properties.Resources.del_btn;
            this.DEL.Name = "DEL";
            this.DEL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DEL.Width = 5;
            // 
            // MenuMain
            // 
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(963, 24);
            this.MenuMain.TabIndex = 13;
            this.MenuMain.Text = "menuStrip1";
            this.MenuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuMain_ItemClicked);
            // 
            // GoToCheckBox
            // 
            this.GoToCheckBox.AutoSize = true;
            this.GoToCheckBox.Location = new System.Drawing.Point(312, 337);
            this.GoToCheckBox.Name = "GoToCheckBox";
            this.GoToCheckBox.Size = new System.Drawing.Size(112, 17);
            this.GoToCheckBox.TabIndex = 182;
            this.GoToCheckBox.Text = "Deactivate GOTO";
            this.GoToCheckBox.UseVisualStyleBackColor = true;
            this.GoToCheckBox.Visible = false;
            this.GoToCheckBox.CheckedChanged += new System.EventHandler(this.GoToCheckBox_CheckChanged);
            // 
            // ProxRadiusLabel
            // 
            this.ProxRadiusLabel.AutoSize = true;
            this.ProxRadiusLabel.Location = new System.Drawing.Point(158, 364);
            this.ProxRadiusLabel.Name = "ProxRadiusLabel";
            this.ProxRadiusLabel.Size = new System.Drawing.Size(67, 13);
            this.ProxRadiusLabel.TabIndex = 55;
            this.ProxRadiusLabel.Text = "Prox. Radius";
            this.ProxRadiusLabel.Visible = false;
            // 
            // ProximityRadiusTextBox
            // 
            this.ProximityRadiusTextBox.Location = new System.Drawing.Point(234, 361);
            this.ProximityRadiusTextBox.Name = "ProximityRadiusTextBox";
            this.ProximityRadiusTextBox.ReadOnly = true;
            this.ProximityRadiusTextBox.Size = new System.Drawing.Size(33, 20);
            this.ProximityRadiusTextBox.TabIndex = 53;
            this.ProximityRadiusTextBox.Text = "10";
            this.ProximityRadiusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProximityRadiusTextBox.Visible = false;
            this.ProximityRadiusTextBox.TextChanged += new System.EventHandler(this.ProximityRadius_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 646);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 9);
            this.label8.TabIndex = 28;
            // 
            // UAVXWriteButton
            // 
            this.UAVXWriteButton.Location = new System.Drawing.Point(362, 551);
            this.UAVXWriteButton.Name = "UAVXWriteButton";
            this.UAVXWriteButton.Size = new System.Drawing.Size(53, 20);
            this.UAVXWriteButton.TabIndex = 20;
            this.UAVXWriteButton.Text = "Write";
            this.UAVXWriteButton.UseVisualStyleBackColor = true;
            this.UAVXWriteButton.Click += new System.EventHandler(this.UAVXWriteButton_Click);
            // 
            // UAVXReadButton
            // 
            this.UAVXReadButton.Location = new System.Drawing.Point(362, 527);
            this.UAVXReadButton.Name = "UAVXReadButton";
            this.UAVXReadButton.Size = new System.Drawing.Size(53, 20);
            this.UAVXReadButton.TabIndex = 19;
            this.UAVXReadButton.Text = "Read";
            this.UAVXReadButton.UseVisualStyleBackColor = true;
            this.UAVXReadButton.Click += new System.EventHandler(this.UAVXReadButton_Click);
            // 
            // ProximityAltTextBox
            // 
            this.ProximityAltTextBox.Location = new System.Drawing.Point(235, 338);
            this.ProximityAltTextBox.Name = "ProximityAltTextBox";
            this.ProximityAltTextBox.ReadOnly = true;
            this.ProximityAltTextBox.Size = new System.Drawing.Size(33, 20);
            this.ProximityAltTextBox.TabIndex = 56;
            this.ProximityAltTextBox.Text = "2";
            this.ProximityAltTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProximityAltTextBox.Visible = false;
            this.ProximityAltTextBox.TextChanged += new System.EventHandler(this.ProximityAlt_TextChanged);
            // 
            // ClickMapLabel
            // 
            this.ClickMapLabel.AutoSize = true;
            this.ClickMapLabel.BackColor = System.Drawing.Color.White;
            this.ClickMapLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickMapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickMapLabel.ForeColor = System.Drawing.Color.Blue;
            this.ClickMapLabel.Location = new System.Drawing.Point(201, 180);
            this.ClickMapLabel.Name = "ClickMapLabel";
            this.ClickMapLabel.Size = new System.Drawing.Size(155, 18);
            this.ClickMapLabel.TabIndex = 46;
            this.ClickMapLabel.Text = "Click Map to Add WP";
            this.ClickMapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FenceRadiusLabel
            // 
            this.FenceRadiusLabel.AutoSize = true;
            this.FenceRadiusLabel.Location = new System.Drawing.Point(6, 18);
            this.FenceRadiusLabel.Name = "FenceRadiusLabel";
            this.FenceRadiusLabel.Size = new System.Drawing.Size(73, 13);
            this.FenceRadiusLabel.TabIndex = 59;
            this.FenceRadiusLabel.Text = "Range Check";
            // 
            // FenceRadiusTextBox
            // 
            this.FenceRadiusTextBox.Location = new System.Drawing.Point(82, 15);
            this.FenceRadiusTextBox.Name = "FenceRadiusTextBox";
            this.FenceRadiusTextBox.Size = new System.Drawing.Size(33, 20);
            this.FenceRadiusTextBox.TabIndex = 58;
            this.FenceRadiusTextBox.Text = "200";
            this.FenceRadiusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FenceRadiusTextBox.TextChanged += new System.EventHandler(this.FenceRadius_TextChanged);
            // 
            // ProximityAltLabel
            // 
            this.ProximityAltLabel.AutoSize = true;
            this.ProximityAltLabel.Location = new System.Drawing.Point(158, 341);
            this.ProximityAltLabel.Name = "ProximityAltLabel";
            this.ProximityAltLabel.Size = new System.Drawing.Size(69, 13);
            this.ProximityAltLabel.TabIndex = 57;
            this.ProximityAltLabel.Text = "Prox. Altitude";
            this.ProximityAltLabel.Visible = false;
            // 
            // PerchContextMenuItem
            // 
            this.PerchContextMenuItem.Name = "PerchContextMenuItem";
            this.PerchContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.PerchContextMenuItem.Text = "Perch";
            this.PerchContextMenuItem.ToolTipText = "Land for a period.";
            this.PerchContextMenuItem.Click += new System.EventHandler(this.PerchContextMenuItem_Click);
            // 
            // ViaContextMenuItem
            // 
            this.ViaContextMenuItem.Name = "ViaContextMenuItem";
            this.ViaContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ViaContextMenuItem.Text = "Via";
            this.ViaContextMenuItem.ToolTipText = "Pass through this waypoint loitering if desired.";
            this.ViaContextMenuItem.Click += new System.EventHandler(this.ViaContextMenuItem_Click);
            // 
            // OrbitContextMenuItem
            // 
            this.OrbitContextMenuItem.Name = "OrbitContextMenuItem";
            this.OrbitContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.OrbitContextMenuItem.Text = "Orbit";
            this.OrbitContextMenuItem.ToolTipText = "Orbit at a radius heading towards the waypoint.";
            this.OrbitContextMenuItem.Click += new System.EventHandler(this.OrbitContextMenuItem_Click);
            // 
            // POIContextMenuItem
            // 
            this.POIContextMenuItem.Name = "POIContextMenuItem";
            this.POIContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.POIContextMenuItem.Text = "Set POI";
            this.POIContextMenuItem.Click += new System.EventHandler(this.POIContextMenuItem_Click);
            // 
            // TMRContextMenuItem
            // 
            this.TMRContextMenuItem.Name = "TMRContextMenuItem";
            this.TMRContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.TMRContextMenuItem.Text = "Set Survey";
            this.TMRContextMenuItem.Click += new System.EventHandler(this.TMRContextMenuItem_Click);
            // 
            // ContextMenuSeparator1
            // 
            this.ContextMenuSeparator1.Name = "ContextMenuSeparator1";
            this.ContextMenuSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // WPDeleteContextMenuItem
            // 
            this.WPDeleteContextMenuItem.Name = "WPDeleteContextMenuItem";
            this.WPDeleteContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.WPDeleteContextMenuItem.Text = "Delete WP";
            this.WPDeleteContextMenuItem.Click += new System.EventHandler(this.WPDeleteContextMenuItem_Click);
            // 
            // ClearMissionContextMenuItem
            // 
            this.ClearMissionContextMenuItem.Name = "ClearMissionContextMenuItem";
            this.ClearMissionContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ClearMissionContextMenuItem.Text = "Clear Mission";
            this.ClearMissionContextMenuItem.ToolTipText = "Clears the mission (only in the WinGUI!)";
            this.ClearMissionContextMenuItem.Click += new System.EventHandler(this.ClearMissionContextMenuItem_Click);
            // 
            // ContextMenuSeparator2
            // 
            this.ContextMenuSeparator2.Name = "ContextMenuSeparator2";
            this.ContextMenuSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // FetchMapTilesContextMenuItem
            // 
            this.FetchMapTilesContextMenuItem.Name = "FetchMapTilesContextMenuItem";
            this.FetchMapTilesContextMenuItem.Size = new System.Drawing.Size(146, 22);
            this.FetchMapTilesContextMenuItem.Text = "Fetch Map tiles";
            this.FetchMapTilesContextMenuItem.ToolTipText = "Fetch map tiles for offline usage";
            this.FetchMapTilesContextMenuItem.Click += new System.EventHandler(this.FetchMapTilesContextMenuItem_Click);
            // 
            // MousePosLabel
            // 
            this.MousePosLabel.AutoSize = true;
            this.MousePosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePosLabel.ForeColor = System.Drawing.Color.Black;
            this.MousePosLabel.Location = new System.Drawing.Point(762, 38);
            this.MousePosLabel.Name = "MousePosLabel";
            this.MousePosLabel.Size = new System.Drawing.Size(49, 19);
            this.MousePosLabel.TabIndex = 175;
            this.MousePosLabel.Text = "Position";
            this.MousePosLabel.UseCompatibleTextRendering = true;
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViaContextMenuItem,
            this.OrbitContextMenuItem,
            this.PerchContextMenuItem,
            this.POIContextMenuItem,
            this.TMRContextMenuItem,
            this.ContextMenuSeparator1,
            this.WPDeleteContextMenuItem,
            this.ClearMissionContextMenuItem,
            this.ContextMenuSeparator2,
            this.FetchMapTilesContextMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStripMap";
            this.contextMenuStripMap.Size = new System.Drawing.Size(147, 192);
            this.contextMenuStripMap.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMap_Opening);
            // 
            // ContextMenuSeparator3
            // 
            this.ContextMenuSeparator3.Name = "ContextMenuSeparator3";
            this.ContextMenuSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // OfflineMapLabel
            // 
            this.OfflineMapLabel.AutoSize = true;
            this.OfflineMapLabel.BackColor = System.Drawing.Color.White;
            this.OfflineMapLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OfflineMapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfflineMapLabel.ForeColor = System.Drawing.Color.Red;
            this.OfflineMapLabel.Location = new System.Drawing.Point(714, 478);
            this.OfflineMapLabel.Name = "OfflineMapLabel";
            this.OfflineMapLabel.Size = new System.Drawing.Size(218, 18);
            this.OfflineMapLabel.TabIndex = 178;
            this.OfflineMapLabel.Text = " Using Local Map - No Internet";
            this.OfflineMapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WPDefaultsGroupBox
            // 
            this.WPDefaultsGroupBox.Controls.Add(this.DefaultLoiterTextBox);
            this.WPDefaultsGroupBox.Controls.Add(this.DefaultAltTextBox);
            this.WPDefaultsGroupBox.Controls.Add(this.FenceRadiusLabel);
            this.WPDefaultsGroupBox.Controls.Add(this.FenceRadiusTextBox);
            this.WPDefaultsGroupBox.Controls.Add(this.DefAltitudeLabel);
            this.WPDefaultsGroupBox.Controls.Add(this.LoiterTimeLabel);
            this.WPDefaultsGroupBox.Location = new System.Drawing.Point(235, 513);
            this.WPDefaultsGroupBox.Name = "WPDefaultsGroupBox";
            this.WPDefaultsGroupBox.Size = new System.Drawing.Size(121, 90);
            this.WPDefaultsGroupBox.TabIndex = 181;
            this.WPDefaultsGroupBox.TabStop = false;
            this.WPDefaultsGroupBox.Text = "WP Defaults (M)";
            // 
            // DefaultLoiterTextBox
            // 
            this.DefaultLoiterTextBox.Location = new System.Drawing.Point(82, 66);
            this.DefaultLoiterTextBox.Name = "DefaultLoiterTextBox";
            this.DefaultLoiterTextBox.Size = new System.Drawing.Size(33, 20);
            this.DefaultLoiterTextBox.TabIndex = 192;
            this.DefaultLoiterTextBox.Text = "15";
            this.DefaultLoiterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DefaultLoiterTextBox.TextChanged += new System.EventHandler(this.DefaultLoiterTextBox_TextChanged);
            // 
            // DefaultAltTextBox
            // 
            this.DefaultAltTextBox.Location = new System.Drawing.Point(82, 40);
            this.DefaultAltTextBox.Name = "DefaultAltTextBox";
            this.DefaultAltTextBox.Size = new System.Drawing.Size(33, 20);
            this.DefaultAltTextBox.TabIndex = 191;
            this.DefaultAltTextBox.Text = "20";
            this.DefaultAltTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DefaultAltTextBox.TextChanged += new System.EventHandler(this.DefaultAltTextBox_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Up";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 27;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Down";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 41;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "DEL";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 34;
            // 
            // timer_updatemap
            // 
            this.timer_updatemap.Tick += new System.EventHandler(this.timer_updatemap_Tick);
            // 
            // LoadMissionButton
            // 
            this.LoadMissionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoadMissionButton.Location = new System.Drawing.Point(8, 2);
            this.LoadMissionButton.Name = "LoadMissionButton";
            this.LoadMissionButton.Size = new System.Drawing.Size(75, 23);
            this.LoadMissionButton.TabIndex = 189;
            this.LoadMissionButton.Text = "Load";
            this.LoadMissionButton.UseVisualStyleBackColor = true;
            this.LoadMissionButton.Click += new System.EventHandler(this.LoadMissionButton_Click);
            // 
            // SaveMissionButton
            // 
            this.SaveMissionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveMissionButton.Location = new System.Drawing.Point(89, 2);
            this.SaveMissionButton.Name = "SaveMissionButton";
            this.SaveMissionButton.Size = new System.Drawing.Size(75, 23);
            this.SaveMissionButton.TabIndex = 188;
            this.SaveMissionButton.Text = "Save";
            this.SaveMissionButton.UseVisualStyleBackColor = true;
            this.SaveMissionButton.Click += new System.EventHandler(this.SaveMissionButton_Click);
            // 
            // CurrentAltitude
            // 
            this.CurrentAltitude.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAltitude.Location = new System.Drawing.Point(432, 40);
            this.CurrentAltitude.Name = "CurrentAltitude";
            this.CurrentAltitude.Size = new System.Drawing.Size(109, 46);
            this.CurrentAltitude.TabIndex = 190;
            this.CurrentAltitude.Text = "-1";
            this.CurrentAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindDirectionTextBox
            // 
            this.WindDirectionTextBox.Location = new System.Drawing.Point(270, 626);
            this.WindDirectionTextBox.Name = "WindDirectionTextBox";
            this.WindDirectionTextBox.Size = new System.Drawing.Size(33, 20);
            this.WindDirectionTextBox.TabIndex = 191;
            this.WindDirectionTextBox.Text = "0";
            this.WindDirectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindSpeedTextBox
            // 
            this.WindSpeedTextBox.Location = new System.Drawing.Point(343, 625);
            this.WindSpeedTextBox.Name = "WindSpeedTextBox";
            this.WindSpeedTextBox.Size = new System.Drawing.Size(33, 20);
            this.WindSpeedTextBox.TabIndex = 192;
            this.WindSpeedTextBox.Text = "10";
            this.WindSpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Location = new System.Drawing.Point(309, 628);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(28, 13);
            this.WindSpeedLabel.TabIndex = 193;
            this.WindSpeedLabel.Text = "M/S";
            // 
            // WindDirectionLabel
            // 
            this.WindDirectionLabel.AutoSize = true;
            this.WindDirectionLabel.Location = new System.Drawing.Point(232, 629);
            this.WindDirectionLabel.Name = "WindDirectionLabel";
            this.WindDirectionLabel.Size = new System.Drawing.Size(32, 13);
            this.WindDirectionLabel.TabIndex = 194;
            this.WindDirectionLabel.Text = "Wind";
            // 
            // NavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(963, 661);
            this.Controls.Add(this.WindDirectionLabel);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.ProximityRadiusTextBox);
            this.Controls.Add(this.WindSpeedTextBox);
            this.Controls.Add(this.WindDirectionTextBox);
            this.Controls.Add(this.GoToCheckBox);
            this.Controls.Add(this.ProxRadiusLabel);
            this.Controls.Add(this.ProximityAltTextBox);
            this.Controls.Add(this.ProximityAltLabel);
            this.Controls.Add(this.AltitudeOverTerrainCheckBox);
            this.Controls.Add(this.CurrentAltitude);
            this.Controls.Add(this.LoadMissionButton);
            this.Controls.Add(this.LocationAddress);
            this.Controls.Add(this.SaveMissionButton);
            this.Controls.Add(this.UAVXWriteButton);
            this.Controls.Add(this.UAVXReadButton);
            this.Controls.Add(this.WPDefaultsGroupBox);
            this.Controls.Add(this.OfflineMapLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.MousePosLabel);
            this.Controls.Add(this.MainMap);
            this.Controls.Add(this.OriginGroupBox);
            this.Controls.Add(this.M);
            this.Controls.Add(this.MenuMain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClickMapLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NavForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAVXNav ";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.OriginGroupBox.ResumeLayout(false);
            this.OriginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapZoomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M)).EndInit();
            this.contextMenuStripMap.ResumeLayout(false);
            this.WPDefaultsGroupBox.ResumeLayout(false);
            this.WPDefaultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog SaveLogFileDialog;
        private OpenFileDialog OpenLogFileDialog;
        private System.Diagnostics.EventLog eventLog1;
        private GMapControl MainMap;
        private Label DistanceLabel;
        private GroupBox OriginGroupBox;
        private Label StartLonLabel;
        private Label StartLatLabel;
        private TextBox StartLat;
        private TextBox StartLon;
        private DataGridView M;
        private MenuStrip MenuMain;
        private ComboBox MapProviderComboBox;
        private Button MapCentreButton;
        private TextBox LocationAddress;
        private NumericUpDown MapZoomNumericUpDown;
        private Label label8;
        private Button UAVXWriteButton;
        private Button UAVXReadButton;
        private Label ClickMapLabel;
        private Label FenceRadiusLabel;
        private TextBox FenceRadiusTextBox;
        private Label ProximityAltLabel;
        private TextBox ProximityAltTextBox;
        private Label ProxRadiusLabel;
        private CheckBox AltitudeOverTerrainCheckBox;
        private TextBox ProximityRadiusTextBox;
       // private static SerialPort serialPort1;
      //  private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_updatemap;
      //  private System.Windows.Forms.Timer timer_telemetry;
        private CheckBox ShowFlightPathCheckBox;
        private CheckBox ShowWPCheckBox;
        private CheckBox ShowMissionCheckBox;
        private Label MousePosLabel;
        private ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem POIContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TMRContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViaContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrbitContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PerchContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator ContextMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ClearMissionContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator ContextMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FetchMapTilesContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WPDeleteContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator ContextMenuSeparator3;
        private Label OfflineMapLabel;
        private CheckBox GoToCheckBox;
        private Label MapZoomLabel;
        private GroupBox WPDefaultsGroupBox;
        private Label LoiterTimeLabel;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private Label DefAltitudeLabel;
        private Button LoadMissionButton;
        private Button SaveMissionButton;
        private TextBox CurrentAltitude;
        private CheckBox CentreCurrPositionCheckBox;
        private TextBox DefaultLoiterTextBox;
        private TextBox DefaultAltTextBox;
        private Label WindDirectionLabel;
        private Label WindSpeedLabel;
        private TextBox WindSpeedTextBox;
        private TextBox WindDirectionTextBox;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Lat;
        private DataGridViewTextBoxColumn Lon;
        private DataGridViewTextBoxColumn Altitude;
        private DataGridViewTextBoxColumn Hidden_Alt;
        private DataGridViewTextBoxColumn SeaLevelAlt;
        private DataGridViewTextBoxColumn Velocity;
        private DataGridViewTextBoxColumn Loiter;
        private DataGridViewComboBoxColumn Action;
        private DataGridViewTextBoxColumn OrbitRad;
        private DataGridViewTextBoxColumn OrbitVel;
        private DataGridViewTextBoxColumn PulseWidth;
        private DataGridViewTextBoxColumn PulsePeriod;
        private DataGridViewImageColumn Up;
        private DataGridViewImageColumn Down;
        private DataGridViewImageColumn DEL;

        //private GMap.NET.WindowsForms.GMapControl MainMap;
    }
}

