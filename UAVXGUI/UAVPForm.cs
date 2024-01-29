// UAVXSet
// Copyright (C) 2007  Thorsten Raab
// Email: thorsten.raab@gmx.at
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

using System;
using System.Collections;
using System.IO;
using System.IO.Ports;
using System.Resources;
using System.Text;
using System.Windows.Forms;


namespace UAVXGUI
{

    public partial class UAVPForm : Form
    {

        //public static System.Windows.Forms.SaveFileDialog hexOpenFileDialog = new System.Windows.Forms.OpenFileDialog();

        public UAVPForm()
        {
            //InitializeComponent();

            labels = new ResourceManager("UAVX.Resources.language", this.GetType().Assembly);
            errorLabels = new ResourceManager("UAVX.Resources.error", this.GetType().Assembly);


        }

        ResourceManager labels;
        ResourceManager errorLabels;
        public SerialPort sp = new SerialPort();

        public static void burn(FormMain mainForm)
        {
            //  hexOpenFileDialog.Filter = "PIC Firmware (*.hex)|*.hex|alle Dateien (*.*)|*.*";
            //  hexOpenFileDialog.InitialDirectory = Properties.Settings.Default.PICHexDirectory;
            //  if (hexOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                // Legacy(hexOpenFileDialog.FileName, mainForm);
                //Pfad f�r n�chstes mal speichern
                //    Properties.Settings.Default.PICHexDirectory = hexOpenFileDialog.InitialDirectory;
            }
        }


        public static void Legacy(string fileName, FormMain mainForm)
        {
            //zzz SerialPort sp;

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName, Encoding.GetEncoding("windows-1252"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            ArrayList hexFile = new ArrayList();
            string line = null;
            while ((line = sr.ReadLine()) != null)
                hexFile.Add(line);

            //Log.write(mainForm, ("Read File: " + fileName), 0);
            //Log.write(mainForm, ("Lines: " + hexFile.Count.ToString()), 1);

            // mainForm.toolStripProgressBar.Visible = true;
            mainForm.Cursor = Cursors.WaitCursor;
            mainForm.Enabled = false;

            // if (!sp.IsOpen) 
            //     connect(mainForm, false, true);
            /*            
             //zzz          int i = 1;
            //zzz           string temp = "no answer from PIC after B";

                       if (false)//mainForm.picBootMode == false)
                       {
                           sp.DiscardInBuffer();
                           sp.Write("B");
                           try
                           {
                               Thread.Sleep(Properties.Settings.Default.iReadSleep);  
                               temp = sp.ReadLine();
                               if (temp == "B\r")
                               {
                                   Thread.Sleep(Properties.Settings.Default.iReadSleep);  
                                   temp = sp.ReadLine();
                               }

                           }
                           catch (Exception e)
                           {
                              // Log.write(mainForm, e.ToString(), 1);
                           }
                       }
             */
            // mainForm.toolStripProgressBar.Maximum = Convert.ToInt16(hexFile.Count);
            /*
                        try 
                        {
                            foreach (string zeile in hexFile) 
                            {
                                mainForm.Cursor = Cursors.WaitCursor;

                                // Progressbar hochz�hlen
                               // mainForm.toolStripProgressBar.Increment(1);
                                // Infotext in status schreiben
                                //mainForm.infoleisteToolStripStatusLabel.Text = labels.GetString("writeLine") +
                                //    " " + i.ToString() + " " + labels.GetString("writeMax") + " " + 
                                //    Convert.ToInt16(hexFile.Count) + "  ";

                                Application.DoEvents();
                                i++;

                             //   sp.Write(zeile + "\r\n");

                                Thread.Sleep(1);

                                for (int j = 0; j < 10; j++) 
                                {
                                    if (Properties.Settings.Default.iReadSleep == 0)
                                        Thread.Sleep(Properties.Settings.Default.writeSleep * j * j);
                                    else
                                        Thread.Sleep(Properties.Settings.Default.iReadSleep);

                                 //   temp = sp.ReadLine();
                                    if (temp == "ERR\r") 
                                    {
                                //        sp.Write(zeile);
                                    } 
                                    else 
                                        break;
                                }
                                if (temp == "ERR\r") 
                                {
                                 //   MessageBox.Show(errorLabels.GetString("flashError"), "Error!", 
                                 //   MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }

                           // mainForm.infoleisteToolStripStatusLabel.Text = labels.GetString("LegacyOk");
                           // mainForm.picBootModus = false;
                        } 
                        catch (Exception e) 
                        {
                          //  MessageBox.Show(errorLabels.GetString("errorBurn"),"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            //closeConnection(mainForm);
                        }
            */
            // MessageBox.Show(labels.GetString("flashInfo"),"Info!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //mainForm.toolStripProgressBar.Value = 0;
            //mainForm.toolStripProgressBar.Visible = false;
            //mainForm.toolStripProgressBar.Maximum = 100;
            mainForm.Cursor = Cursors.Default;
            mainForm.Enabled = true;

        }

    }
}
