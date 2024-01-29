namespace UAVXGUI
{
    partial class FormMain
    {
       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
               components.Dispose();
            }
            base.Dispose(disposing);
        }
         * */

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RollAngle = new System.Windows.Forms.TextBox();
            this.PitchAngle = new System.Windows.Forms.TextBox();
            this.BatteryVolts = new System.Windows.Forms.TextBox();
            this.BatteryCurrent = new System.Windows.Forms.TextBox();
            this.RCGlitches = new System.Windows.Forms.TextBox();
            this.DesiredThrottle = new System.Windows.Forms.TextBox();
            this.DesiredRoll = new System.Windows.Forms.TextBox();
            this.DesiredPitch = new System.Windows.Forms.TextBox();
            this.DesiredYaw = new System.Windows.Forms.TextBox();
            this.YawGyro = new System.Windows.Forms.TextBox();
            this.PitchRate = new System.Windows.Forms.TextBox();
            this.RollRate = new System.Windows.Forms.TextBox();
            this.LRAcc = new System.Windows.Forms.TextBox();
            this.YawAngle = new System.Windows.Forms.TextBox();
            this.DUAcc = new System.Windows.Forms.TextBox();
            this.FBAcc = new System.Windows.Forms.TextBox();
            this.VoltsLabel = new System.Windows.Forms.Label();
            this.LRAccLabel = new System.Windows.Forms.Label();
            this.FBAccLabel = new System.Windows.Forms.Label();
            this.DUAccLabel = new System.Windows.Forms.Label();
            this.DesiredYawLabel = new System.Windows.Forms.Label();
            this.DesiredPitchLabel = new System.Windows.Forms.Label();
            this.DesiredRollLabel = new System.Windows.Forms.Label();
            this.DesiredThrottleLabel = new System.Windows.Forms.Label();
            this.RCGlitchesLabel = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.GPShAcc = new System.Windows.Forms.TextBox();
            this.RangefinderAltitude = new System.Windows.Forms.TextBox();
            this.BaroAltitude = new System.Windows.Forms.TextBox();
            this.GPSFix = new System.Windows.Forms.TextBox();
            this.ROC = new System.Windows.Forms.TextBox();
            this.GPSNoOfSats = new System.Windows.Forms.TextBox();
            this.AlarmState = new System.Windows.Forms.TextBox();
            this.GPSAltitude = new System.Windows.Forms.TextBox();
            this.ROCLabel = new System.Windows.Forms.Label();
            this.hAccLabel = new System.Windows.Forms.Label();
            this.RangefinderAltLabel = new System.Windows.Forms.Label();
            this.GPSFixLabel = new System.Windows.Forms.Label();
            this.GPSNoOfSatsLabel = new System.Windows.Forms.Label();
            this.GPSAltLabel = new System.Windows.Forms.Label();
            this.BaroAltitudeLabel = new System.Windows.Forms.Label();
            this.YawGyroLabel = new System.Windows.Forms.Label();
            this.PitchRateLabel = new System.Windows.Forms.Label();
            this.RollRateLabel = new System.Windows.Forms.Label();
            this.RxTypeErr = new System.Windows.Forms.TextBox();
            this.RxCSumErr = new System.Windows.Forms.TextBox();
            this.RxLenErr = new System.Windows.Forms.TextBox();
            this.RxTypeLabel = new System.Windows.Forms.Label();
            this.RxCSumLabel = new System.Windows.Forms.Label();
            this.RxLenLabel = new System.Windows.Forms.Label();
            this.FlightState = new System.Windows.Forms.TextBox();
            this.GyroGroupBox = new System.Windows.Forms.GroupBox();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.AttitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.AccConfidenceLabel = new System.Windows.Forms.Label();
            this.YawLabel = new System.Windows.Forms.Label();
            this.PitchLabel = new System.Windows.Forms.Label();
            this.AccConfidence = new System.Windows.Forms.TextBox();
            this.RollLabel = new System.Windows.Forms.Label();
            this.AccelerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.CommsGroupBox = new System.Windows.Forms.GroupBox();
            this.SerialBRxProgressBar = new System.Windows.Forms.ProgressBar();
            this.SerialARxProgressBar = new System.Windows.Forms.ProgressBar();
            this.SerialBTxProgressBar = new System.Windows.Forms.ProgressBar();
            this.SerialATxProgressBar = new System.Windows.Forms.ProgressBar();
            this.SerailBRxEntries = new System.Windows.Forms.TextBox();
            this.SerialBTxEntries = new System.Windows.Forms.TextBox();
            this.SerialBLabel = new System.Windows.Forms.Label();
            this.SerialARxEntries = new System.Windows.Forms.TextBox();
            this.SerialATxEntries = new System.Windows.Forms.TextBox();
            this.SerialAlLabel = new System.Windows.Forms.Label();
            this.SensorTemp = new System.Windows.Forms.TextBox();
            this.BatteryGroupBox = new System.Windows.Forms.GroupBox();
            this.BatteryCharge = new System.Windows.Forms.TextBox();
            this.BatteryChargeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NavBox = new System.Windows.Forms.TextBox();
            this.RTHBox = new System.Windows.Forms.TextBox();
            this.GPSValidBox = new System.Windows.Forms.TextBox();
            this.AngleControlBox = new System.Windows.Forms.TextBox();
            this.NavValidBox = new System.Windows.Forms.TextBox();
            this.OffsetOriginValidBox = new System.Windows.Forms.TextBox();
            this.ThrottleMovingBox = new System.Windows.Forms.TextBox();
            this.AltHoldBox = new System.Windows.Forms.TextBox();
            this.HoldingAltBox = new System.Windows.Forms.TextBox();
            this.RapidDescentHazardFlagBox = new System.Windows.Forms.TextBox();
            this.BaroAltValidBox = new System.Windows.Forms.TextBox();
            this.GPSAltitudeBox = new System.Windows.Forms.TextBox();
            this.RangefinderAltValidBox = new System.Windows.Forms.TextBox();
            this.UsingRangefinderBox = new System.Windows.Forms.TextBox();
            this.NearLevelBox = new System.Windows.Forms.TextBox();
            this.AttitudeHoldBox = new System.Windows.Forms.TextBox();
            this.NavigateBox = new System.Windows.Forms.TextBox();
            this.TurnToPOIBox = new System.Windows.Forms.TextBox();
            this.CloseProximityBox = new System.Windows.Forms.TextBox();
            this.ProximityBox = new System.Windows.Forms.TextBox();
            this.UseRTHAutoDescendBox = new System.Windows.Forms.TextBox();
            this.LandingSwitchBox = new System.Windows.Forms.TextBox();
            this.LowBatteryBox = new System.Windows.Forms.TextBox();
            this.IMUFailBox = new System.Windows.Forms.TextBox();
            this.GPSFailBox = new System.Windows.Forms.TextBox();
            this.BaroFailBox = new System.Windows.Forms.TextBox();
            this.MagFailBox = new System.Windows.Forms.TextBox();
            this.BypassBox = new System.Windows.Forms.TextBox();
            this.DCMotorsBox = new System.Windows.Forms.TextBox();
            this.FlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.GPSStatusBox = new System.Windows.Forms.GroupBox();
            this.GPSHWVersionTextBox = new System.Windows.Forms.TextBox();
            this.GPSHWVersionLabel = new System.Windows.Forms.Label();
            this.GPSdTTextBox = new System.Windows.Forms.TextBox();
            this.GPSdTLabel = new System.Windows.Forms.Label();
            this.GPScAcc = new System.Windows.Forms.TextBox();
            this.GPScAccLabel = new System.Windows.Forms.Label();
            this.GPSvAcc = new System.Windows.Forms.TextBox();
            this.GPSvAccLabel = new System.Windows.Forms.Label();
            this.GPSHeadingLabel = new System.Windows.Forms.Label();
            this.GPSHeading = new System.Windows.Forms.TextBox();
            this.GPSsAccLabel = new System.Windows.Forms.Label();
            this.GPSLongitudeLabel = new System.Windows.Forms.Label();
            this.GPSsAcc = new System.Windows.Forms.TextBox();
            this.GPSVelLabel = new System.Windows.Forms.Label();
            this.GPSLatitudeLabel = new System.Windows.Forms.Label();
            this.GPSLongitude = new System.Windows.Forms.TextBox();
            this.GPSVel = new System.Windows.Forms.TextBox();
            this.GPSLatitude = new System.Windows.Forms.TextBox();
            this.WhereDistance = new System.Windows.Forms.TextBox();
            this.WhereBearingLabel = new System.Windows.Forms.Label();
            this.WhereBearing = new System.Windows.Forms.TextBox();
            this.WhereDistanceLabel = new System.Windows.Forms.Label();
            this.AltitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BaroPressure = new System.Windows.Forms.TextBox();
            this.BaroTemperature = new System.Windows.Forms.TextBox();
            this.WayHeadingLabel = new System.Windows.Forms.Label();
            this.CurrWPLabel = new System.Windows.Forms.Label();
            this.NavState = new System.Windows.Forms.TextBox();
            this.CurrWP = new System.Windows.Forms.TextBox();
            this.WayHeading = new System.Windows.Forms.TextBox();
            this.AltitudeErrorLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.DesiredAltitude = new System.Windows.Forms.TextBox();
            this.Heading = new System.Windows.Forms.TextBox();
            this.WPDistanceLabel = new System.Windows.Forms.Label();
            this.DistanceToDesired = new System.Windows.Forms.TextBox();
            this.NavGroupBox = new System.Windows.Forms.GroupBox();
            this.DesiredAltitudeLabel = new System.Windows.Forms.Label();
            this.AltitudeError = new System.Windows.Forms.TextBox();
            this.CrossTrackErrorLabel = new System.Windows.Forms.Label();
            this.CrossTrackError = new System.Windows.Forms.TextBox();
            this.NavStateTimeoutLabel = new System.Windows.Forms.Label();
            this.NavStateTimeout = new System.Windows.Forms.TextBox();
            this.CurrentAltitude = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AltitudeSource = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NavSensitivity = new System.Windows.Forms.TextBox();
            this.NavSensitivityLabel = new System.Windows.Forms.Label();
            this.CruiseThrottle = new System.Windows.Forms.TextBox();
            this.CruiseThrottleLabel = new System.Windows.Forms.Label();
            this.NavYCorr = new System.Windows.Forms.TextBox();
            this.BattFFLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NavPCorr = new System.Windows.Forms.TextBox();
            this.NavRCorr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BattFFComp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AltComp = new System.Windows.Forms.TextBox();
            this.TiltFFComp = new System.Windows.Forms.TextBox();
            this.TiltFFCompLabel = new System.Windows.Forms.Label();
            this.AltCompLabel = new System.Windows.Forms.Label();
            this.EmulationTextBox = new System.Windows.Forms.TextBox();
            this.OpenLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.COMSelectComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.COMBaudRateComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.ReplayProgressBar = new System.Windows.Forms.ProgressBar();
            this.Airframe = new System.Windows.Forms.TextBox();
            this.ReplayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeechGroupBox = new System.Windows.Forms.GroupBox();
            this.SpeakVarioCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakIntervalLabel = new System.Windows.Forms.Label();
            this.SpeakIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeechEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakNavCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakAltitudeCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakWhereCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakVoltsCheckBox = new System.Windows.Forms.CheckBox();
            this.timer_announce = new System.Windows.Forms.Timer(this.components);
            this.timer_telemetry = new System.Windows.Forms.Timer(this.components);
            this.StartNavigationButton = new System.Windows.Forms.Button();
            this.StartParametersButton = new System.Windows.Forms.Button();
            this.CalibrateIMUButton = new System.Windows.Forms.Button();
            this.CalibrateMagButton = new System.Windows.Forms.Button();
            this.DrivesGroupBox = new System.Windows.Forms.GroupBox();
            this.PWM1Label = new System.Windows.Forms.Label();
            this.PWM2Label = new System.Windows.Forms.Label();
            this.PWM3Label = new System.Windows.Forms.Label();
            this.PWM4Label = new System.Windows.Forms.Label();
            this.PWM5Label = new System.Windows.Forms.Label();
            this.PWM6Label = new System.Windows.Forms.Label();
            this.PWM7Label = new System.Windows.Forms.Label();
            this.PWM0Label = new System.Windows.Forms.Label();
            this.PWM8Label = new System.Windows.Forms.Label();
            this.ImbalanceLabel = new System.Windows.Forms.Label();
            this.DiagnosticCheckBox = new System.Windows.Forms.CheckBox();
            this.PWM9Label = new System.Windows.Forms.Label();
            this.PWMT7 = new System.Windows.Forms.TextBox();
            this.PWMT6 = new System.Windows.Forms.TextBox();
            this.PWMT5 = new System.Windows.Forms.TextBox();
            this.PWMT4 = new System.Windows.Forms.TextBox();
            this.PWMT9 = new System.Windows.Forms.TextBox();
            this.PWMT3 = new System.Windows.Forms.TextBox();
            this.PWMT2 = new System.Windows.Forms.TextBox();
            this.PWMT1 = new System.Windows.Forms.TextBox();
            this.PWMT0 = new System.Windows.Forms.TextBox();
            this.PWMT8 = new System.Windows.Forms.TextBox();
            this.PWMT0ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT6ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT1ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT5ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT2ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT7ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT4ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT3ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT8ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT9ProgressBar = new System.Windows.Forms.ProgressBar();
            this.FWRateEnergy = new System.Windows.Forms.TextBox();
            this.RateEnergyLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.MissionTimeTextBox = new System.Windows.Forms.TextBox();
            this.WarningPictureBox = new System.Windows.Forms.PictureBox();
            this.GPSPassThruButton = new System.Windows.Forms.Button();
            this.DumpBBButton = new System.Windows.Forms.Button();
            this.AlarmsButton = new System.Windows.Forms.Button();
            this.execPeakPercentLabel = new System.Windows.Forms.Label();
            this.CalibrationGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBarQ8 = new System.Windows.Forms.ProgressBar();
            this.progressBarQ6 = new System.Windows.Forms.ProgressBar();
            this.progressBarQ4 = new System.Windows.Forms.ProgressBar();
            this.progressBarQ2 = new System.Windows.Forms.ProgressBar();
            this.progressBarQ7 = new System.Windows.Forms.ProgressBar();
            this.progressBarQ5 = new System.Windows.Forms.ProgressBar();
            this.progressBarQ3 = new System.Windows.Forms.ProgressBar();
            this.progressBarQ1 = new System.Windows.Forms.ProgressBar();
            this.TrackBaroVariance = new System.Windows.Forms.TextBox();
            this.BaroVarianceLabel = new System.Windows.Forms.Label();
            this.TrackAccUVariance = new System.Windows.Forms.TextBox();
            this.AccVarianceLabel = new System.Windows.Forms.Label();
            this.IMUTempLabel = new System.Windows.Forms.Label();
            this.FWGlideOffsetAngle = new System.Windows.Forms.TextBox();
            this.YawPitchRollGyroLabel = new System.Windows.Forms.Label();
            this.FWGlideAngleOffsetLabel = new System.Windows.Forms.Label();
            this.NyquistMargin = new System.Windows.Forms.Label();
            this.GyroLPF = new System.Windows.Forms.Label();
            this.AccLPF = new System.Windows.Forms.Label();
            this.NyquistMarginLabel = new System.Windows.Forms.Label();
            this.AccLPFLabel = new System.Windows.Forms.Label();
            this.PitchRollGyroLabel = new System.Windows.Forms.Label();
            this.MZCalBiasLabel = new System.Windows.Forms.Label();
            this.MYCalBiasLabel = new System.Windows.Forms.Label();
            this.MXCalBiasLabel = new System.Windows.Forms.Label();
            this.MZBiasLabel = new System.Windows.Forms.Label();
            this.MXBiasLabel = new System.Windows.Forms.Label();
            this.MYBiasLabel = new System.Windows.Forms.Label();
            this.MZScaleLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MXScaleLabel = new System.Windows.Forms.Label();
            this.MYScaleLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CalTRefLabel = new System.Windows.Forms.Label();
            this.UDAccMLabel = new System.Windows.Forms.Label();
            this.BFAccMLabel = new System.Windows.Forms.Label();
            this.LRAccMLabel = new System.Windows.Forms.Label();
            this.UDAccCLabel = new System.Windows.Forms.Label();
            this.BFAccCLabel = new System.Windows.Forms.Label();
            this.LRAccCLabel = new System.Windows.Forms.Label();
            this.YawGyroCLabel = new System.Windows.Forms.Label();
            this.RollGyroCLabel = new System.Windows.Forms.Label();
            this.YawGyroMLabel = new System.Windows.Forms.Label();
            this.YawCalLabel = new System.Windows.Forms.Label();
            this.PitchGyroCLabel = new System.Windows.Forms.Label();
            this.PitchCalLabel = new System.Windows.Forms.Label();
            this.RollCalLabel = new System.Windows.Forms.Label();
            this.RollGyroMLabel = new System.Windows.Forms.Label();
            this.PitchGyroMLabel = new System.Windows.Forms.Label();
            this.BootLoadButton = new System.Windows.Forms.Button();
            this.WPActionTextBox = new System.Windows.Forms.TextBox();
            this.KMLComboBox = new System.Windows.Forms.ComboBox();
            this.CalibrateAccZeroButton = new System.Windows.Forms.Button();
            this.WhereGroupBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.execPercentLabel = new System.Windows.Forms.Label();
            this.MagHeadingTextBox = new System.Windows.Forms.TextBox();
            this.RadioGroupBox = new System.Windows.Forms.GroupBox();
            this.RCFailsafesTextBox = new System.Windows.Forms.TextBox();
            this.RCFailsafesLabel = new System.Windows.Forms.Label();
            this.RCSignalLossesTextBox = new System.Windows.Forms.TextBox();
            this.RCSignalLossesLabel = new System.Windows.Forms.Label();
            this.upSNRTextBox = new System.Windows.Forms.TextBox();
            this.upSNRLabel = new System.Windows.Forms.Label();
            this.upRSSITextBox = new System.Windows.Forms.TextBox();
            this.upLQTextBox = new System.Windows.Forms.TextBox();
            this.upRSSILabel = new System.Windows.Forms.Label();
            this.upLQLabel = new System.Windows.Forms.Label();
            this.attitudeIndicatorInstrumentControl1 = new Instruments.AttitudeIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new Instruments.HeadingIndicatorInstrumentControl();
            this.GyroGroupBox.SuspendLayout();
            this.ControlsGroupBox.SuspendLayout();
            this.AttitudeGroupBox.SuspendLayout();
            this.AccelerationsGroupBox.SuspendLayout();
            this.CommsGroupBox.SuspendLayout();
            this.BatteryGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.FlagsGroupBox.SuspendLayout();
            this.GPSStatusBox.SuspendLayout();
            this.AltitudeGroupBox.SuspendLayout();
            this.NavGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayNumericUpDown)).BeginInit();
            this.SpeechGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakIntervalNumericUpDown)).BeginInit();
            this.DrivesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).BeginInit();
            this.CalibrationGroupBox.SuspendLayout();
            this.WhereGroupBox.SuspendLayout();
            this.RadioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Red;
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConnectButton.Location = new System.Drawing.Point(171, 0);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(85, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Disconnected";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RollAngle
            // 
            this.RollAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RollAngle.Location = new System.Drawing.Point(39, 37);
            this.RollAngle.Name = "RollAngle";
            this.RollAngle.ReadOnly = true;
            this.RollAngle.Size = new System.Drawing.Size(32, 13);
            this.RollAngle.TabIndex = 5;
            this.RollAngle.Text = "-";
            this.RollAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PitchAngle
            // 
            this.PitchAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PitchAngle.Location = new System.Drawing.Point(39, 55);
            this.PitchAngle.Name = "PitchAngle";
            this.PitchAngle.ReadOnly = true;
            this.PitchAngle.Size = new System.Drawing.Size(32, 13);
            this.PitchAngle.TabIndex = 6;
            this.PitchAngle.Text = "-";
            this.PitchAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatteryVolts
            // 
            this.BatteryVolts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BatteryVolts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryVolts.Location = new System.Drawing.Point(17, 15);
            this.BatteryVolts.Name = "BatteryVolts";
            this.BatteryVolts.ReadOnly = true;
            this.BatteryVolts.Size = new System.Drawing.Size(44, 15);
            this.BatteryVolts.TabIndex = 8;
            this.BatteryVolts.Text = "10";
            this.BatteryVolts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatteryCurrent
            // 
            this.BatteryCurrent.BackColor = System.Drawing.SystemColors.Control;
            this.BatteryCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BatteryCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryCurrent.Location = new System.Drawing.Point(76, 15);
            this.BatteryCurrent.Name = "BatteryCurrent";
            this.BatteryCurrent.ReadOnly = true;
            this.BatteryCurrent.Size = new System.Drawing.Size(32, 15);
            this.BatteryCurrent.TabIndex = 9;
            this.BatteryCurrent.Text = "0";
            this.BatteryCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RCGlitches
            // 
            this.RCGlitches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCGlitches.Location = new System.Drawing.Point(58, 80);
            this.RCGlitches.Name = "RCGlitches";
            this.RCGlitches.ReadOnly = true;
            this.RCGlitches.Size = new System.Drawing.Size(44, 13);
            this.RCGlitches.TabIndex = 10;
            this.RCGlitches.Text = "-";
            this.RCGlitches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredThrottle
            // 
            this.DesiredThrottle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DesiredThrottle.Location = new System.Drawing.Point(38, 19);
            this.DesiredThrottle.Name = "DesiredThrottle";
            this.DesiredThrottle.ReadOnly = true;
            this.DesiredThrottle.Size = new System.Drawing.Size(32, 13);
            this.DesiredThrottle.TabIndex = 11;
            this.DesiredThrottle.Text = "-";
            this.DesiredThrottle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredRoll
            // 
            this.DesiredRoll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DesiredRoll.Location = new System.Drawing.Point(38, 37);
            this.DesiredRoll.Name = "DesiredRoll";
            this.DesiredRoll.ReadOnly = true;
            this.DesiredRoll.Size = new System.Drawing.Size(32, 13);
            this.DesiredRoll.TabIndex = 12;
            this.DesiredRoll.Text = "-";
            this.DesiredRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredPitch
            // 
            this.DesiredPitch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DesiredPitch.Location = new System.Drawing.Point(38, 56);
            this.DesiredPitch.Name = "DesiredPitch";
            this.DesiredPitch.ReadOnly = true;
            this.DesiredPitch.Size = new System.Drawing.Size(32, 13);
            this.DesiredPitch.TabIndex = 13;
            this.DesiredPitch.Text = "-";
            this.DesiredPitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredYaw
            // 
            this.DesiredYaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DesiredYaw.Location = new System.Drawing.Point(38, 73);
            this.DesiredYaw.Name = "DesiredYaw";
            this.DesiredYaw.ReadOnly = true;
            this.DesiredYaw.Size = new System.Drawing.Size(32, 13);
            this.DesiredYaw.TabIndex = 14;
            this.DesiredYaw.Text = "-";
            this.DesiredYaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YawGyro
            // 
            this.YawGyro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YawGyro.Location = new System.Drawing.Point(35, 53);
            this.YawGyro.Name = "YawGyro";
            this.YawGyro.ReadOnly = true;
            this.YawGyro.Size = new System.Drawing.Size(35, 13);
            this.YawGyro.TabIndex = 17;
            this.YawGyro.Text = "-";
            this.YawGyro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PitchRate
            // 
            this.PitchRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PitchRate.Location = new System.Drawing.Point(35, 37);
            this.PitchRate.Name = "PitchRate";
            this.PitchRate.ReadOnly = true;
            this.PitchRate.Size = new System.Drawing.Size(35, 13);
            this.PitchRate.TabIndex = 16;
            this.PitchRate.Text = "-";
            this.PitchRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RollRate
            // 
            this.RollRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RollRate.Location = new System.Drawing.Point(35, 17);
            this.RollRate.Name = "RollRate";
            this.RollRate.ReadOnly = true;
            this.RollRate.Size = new System.Drawing.Size(35, 13);
            this.RollRate.TabIndex = 15;
            this.RollRate.Text = "-";
            this.RollRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LRAcc
            // 
            this.LRAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LRAcc.Location = new System.Drawing.Point(38, 36);
            this.LRAcc.Name = "LRAcc";
            this.LRAcc.ReadOnly = true;
            this.LRAcc.Size = new System.Drawing.Size(32, 13);
            this.LRAcc.TabIndex = 21;
            this.LRAcc.Text = "-";
            this.LRAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YawAngle
            // 
            this.YawAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YawAngle.Location = new System.Drawing.Point(39, 72);
            this.YawAngle.Name = "YawAngle";
            this.YawAngle.ReadOnly = true;
            this.YawAngle.Size = new System.Drawing.Size(32, 13);
            this.YawAngle.TabIndex = 20;
            this.YawAngle.Text = "-";
            this.YawAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DUAcc
            // 
            this.DUAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DUAcc.Location = new System.Drawing.Point(38, 52);
            this.DUAcc.Name = "DUAcc";
            this.DUAcc.ReadOnly = true;
            this.DUAcc.Size = new System.Drawing.Size(32, 13);
            this.DUAcc.TabIndex = 19;
            this.DUAcc.Text = "-";
            this.DUAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FBAcc
            // 
            this.FBAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FBAcc.Location = new System.Drawing.Point(38, 17);
            this.FBAcc.Name = "FBAcc";
            this.FBAcc.ReadOnly = true;
            this.FBAcc.Size = new System.Drawing.Size(32, 13);
            this.FBAcc.TabIndex = 18;
            this.FBAcc.Text = "-";
            this.FBAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VoltsLabel
            // 
            this.VoltsLabel.AutoSize = true;
            this.VoltsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltsLabel.Location = new System.Drawing.Point(61, 15);
            this.VoltsLabel.Name = "VoltsLabel";
            this.VoltsLabel.Size = new System.Drawing.Size(18, 16);
            this.VoltsLabel.TabIndex = 22;
            this.VoltsLabel.Text = "V";
            // 
            // LRAccLabel
            // 
            this.LRAccLabel.AutoSize = true;
            this.LRAccLabel.Location = new System.Drawing.Point(6, 35);
            this.LRAccLabel.Name = "LRAccLabel";
            this.LRAccLabel.Size = new System.Drawing.Size(21, 13);
            this.LRAccLabel.TabIndex = 26;
            this.LRAccLabel.Text = "LR";
            // 
            // FBAccLabel
            // 
            this.FBAccLabel.AutoSize = true;
            this.FBAccLabel.Location = new System.Drawing.Point(6, 17);
            this.FBAccLabel.Name = "FBAccLabel";
            this.FBAccLabel.Size = new System.Drawing.Size(20, 13);
            this.FBAccLabel.TabIndex = 27;
            this.FBAccLabel.Text = "BF";
            // 
            // DUAccLabel
            // 
            this.DUAccLabel.AutoSize = true;
            this.DUAccLabel.Location = new System.Drawing.Point(4, 53);
            this.DUAccLabel.Name = "DUAccLabel";
            this.DUAccLabel.Size = new System.Drawing.Size(23, 13);
            this.DUAccLabel.TabIndex = 28;
            this.DUAccLabel.Text = "UD";
            // 
            // DesiredYawLabel
            // 
            this.DesiredYawLabel.AutoSize = true;
            this.DesiredYawLabel.Location = new System.Drawing.Point(7, 73);
            this.DesiredYawLabel.Name = "DesiredYawLabel";
            this.DesiredYawLabel.Size = new System.Drawing.Size(28, 13);
            this.DesiredYawLabel.TabIndex = 34;
            this.DesiredYawLabel.Text = "Yaw";
            // 
            // DesiredPitchLabel
            // 
            this.DesiredPitchLabel.AutoSize = true;
            this.DesiredPitchLabel.Location = new System.Drawing.Point(7, 55);
            this.DesiredPitchLabel.Name = "DesiredPitchLabel";
            this.DesiredPitchLabel.Size = new System.Drawing.Size(31, 13);
            this.DesiredPitchLabel.TabIndex = 33;
            this.DesiredPitchLabel.Text = "Pitch";
            // 
            // DesiredRollLabel
            // 
            this.DesiredRollLabel.AutoSize = true;
            this.DesiredRollLabel.Location = new System.Drawing.Point(7, 37);
            this.DesiredRollLabel.Name = "DesiredRollLabel";
            this.DesiredRollLabel.Size = new System.Drawing.Size(25, 13);
            this.DesiredRollLabel.TabIndex = 32;
            this.DesiredRollLabel.Text = "Roll";
            // 
            // DesiredThrottleLabel
            // 
            this.DesiredThrottleLabel.AutoSize = true;
            this.DesiredThrottleLabel.Location = new System.Drawing.Point(6, 19);
            this.DesiredThrottleLabel.Name = "DesiredThrottleLabel";
            this.DesiredThrottleLabel.Size = new System.Drawing.Size(26, 13);
            this.DesiredThrottleLabel.TabIndex = 31;
            this.DesiredThrottleLabel.Text = "Thr.";
            // 
            // RCGlitchesLabel
            // 
            this.RCGlitchesLabel.AutoSize = true;
            this.RCGlitchesLabel.Location = new System.Drawing.Point(7, 81);
            this.RCGlitchesLabel.Name = "RCGlitchesLabel";
            this.RCGlitchesLabel.Size = new System.Drawing.Size(42, 13);
            this.RCGlitchesLabel.TabIndex = 30;
            this.RCGlitchesLabel.Text = "BadPkt";
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLabel.Location = new System.Drawing.Point(114, 15);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(18, 16);
            this.CurrentLabel.TabIndex = 29;
            this.CurrentLabel.Text = "A";
            // 
            // GPShAcc
            // 
            this.GPShAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPShAcc.Location = new System.Drawing.Point(174, 33);
            this.GPShAcc.Name = "GPShAcc";
            this.GPShAcc.ReadOnly = true;
            this.GPShAcc.Size = new System.Drawing.Size(38, 13);
            this.GPShAcc.TabIndex = 44;
            this.GPShAcc.Text = "-";
            this.GPShAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RangefinderAltitude
            // 
            this.RangefinderAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RangefinderAltitude.Location = new System.Drawing.Point(37, 54);
            this.RangefinderAltitude.Name = "RangefinderAltitude";
            this.RangefinderAltitude.ReadOnly = true;
            this.RangefinderAltitude.Size = new System.Drawing.Size(35, 13);
            this.RangefinderAltitude.TabIndex = 43;
            this.RangefinderAltitude.Text = "-";
            this.RangefinderAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BaroAltitude
            // 
            this.BaroAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaroAltitude.Location = new System.Drawing.Point(37, 15);
            this.BaroAltitude.Name = "BaroAltitude";
            this.BaroAltitude.ReadOnly = true;
            this.BaroAltitude.Size = new System.Drawing.Size(35, 13);
            this.BaroAltitude.TabIndex = 46;
            this.BaroAltitude.Text = "-";
            this.BaroAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSFix
            // 
            this.GPSFix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSFix.Location = new System.Drawing.Point(112, 33);
            this.GPSFix.Name = "GPSFix";
            this.GPSFix.ReadOnly = true;
            this.GPSFix.Size = new System.Drawing.Size(22, 13);
            this.GPSFix.TabIndex = 51;
            this.GPSFix.Text = "-";
            this.GPSFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ROC
            // 
            this.ROC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ROC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROC.Location = new System.Drawing.Point(512, 73);
            this.ROC.Name = "ROC";
            this.ROC.ReadOnly = true;
            this.ROC.Size = new System.Drawing.Size(54, 23);
            this.ROC.TabIndex = 49;
            this.ROC.Text = "0";
            this.ROC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSNoOfSats
            // 
            this.GPSNoOfSats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSNoOfSats.Location = new System.Drawing.Point(48, 33);
            this.GPSNoOfSats.Name = "GPSNoOfSats";
            this.GPSNoOfSats.ReadOnly = true;
            this.GPSNoOfSats.Size = new System.Drawing.Size(22, 13);
            this.GPSNoOfSats.TabIndex = 54;
            this.GPSNoOfSats.Text = "-";
            this.GPSNoOfSats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AlarmState
            // 
            this.AlarmState.Location = new System.Drawing.Point(230, 28);
            this.AlarmState.Name = "AlarmState";
            this.AlarmState.ReadOnly = true;
            this.AlarmState.Size = new System.Drawing.Size(86, 20);
            this.AlarmState.TabIndex = 53;
            this.AlarmState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPSAltitude
            // 
            this.GPSAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSAltitude.Location = new System.Drawing.Point(37, 35);
            this.GPSAltitude.Name = "GPSAltitude";
            this.GPSAltitude.ReadOnly = true;
            this.GPSAltitude.Size = new System.Drawing.Size(35, 13);
            this.GPSAltitude.TabIndex = 58;
            this.GPSAltitude.Text = "-";
            this.GPSAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ROCLabel
            // 
            this.ROCLabel.AutoSize = true;
            this.ROCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROCLabel.Location = new System.Drawing.Point(536, 57);
            this.ROCLabel.Name = "ROCLabel";
            this.ROCLabel.Size = new System.Drawing.Size(33, 13);
            this.ROCLabel.TabIndex = 65;
            this.ROCLabel.Text = "ROC";
            // 
            // hAccLabel
            // 
            this.hAccLabel.AutoSize = true;
            this.hAccLabel.Location = new System.Drawing.Point(151, 33);
            this.hAccLabel.Name = "hAccLabel";
            this.hAccLabel.Size = new System.Drawing.Size(20, 13);
            this.hAccLabel.TabIndex = 66;
            this.hAccLabel.Text = "hA";
            // 
            // RangefinderAltLabel
            // 
            this.RangefinderAltLabel.AutoSize = true;
            this.RangefinderAltLabel.Location = new System.Drawing.Point(7, 54);
            this.RangefinderAltLabel.Name = "RangefinderAltLabel";
            this.RangefinderAltLabel.Size = new System.Drawing.Size(21, 13);
            this.RangefinderAltLabel.TabIndex = 67;
            this.RangefinderAltLabel.Text = "RF";
            // 
            // GPSFixLabel
            // 
            this.GPSFixLabel.AutoSize = true;
            this.GPSFixLabel.Location = new System.Drawing.Point(78, 33);
            this.GPSFixLabel.Name = "GPSFixLabel";
            this.GPSFixLabel.Size = new System.Drawing.Size(20, 13);
            this.GPSFixLabel.TabIndex = 69;
            this.GPSFixLabel.Text = "Fix";
            // 
            // GPSNoOfSatsLabel
            // 
            this.GPSNoOfSatsLabel.AutoSize = true;
            this.GPSNoOfSatsLabel.Location = new System.Drawing.Point(8, 33);
            this.GPSNoOfSatsLabel.Name = "GPSNoOfSatsLabel";
            this.GPSNoOfSatsLabel.Size = new System.Drawing.Size(28, 13);
            this.GPSNoOfSatsLabel.TabIndex = 70;
            this.GPSNoOfSatsLabel.Text = "Sats";
            // 
            // GPSAltLabel
            // 
            this.GPSAltLabel.AutoSize = true;
            this.GPSAltLabel.Location = new System.Drawing.Point(7, 36);
            this.GPSAltLabel.Name = "GPSAltLabel";
            this.GPSAltLabel.Size = new System.Drawing.Size(29, 13);
            this.GPSAltLabel.TabIndex = 74;
            this.GPSAltLabel.Text = "GPS";
            // 
            // BaroAltitudeLabel
            // 
            this.BaroAltitudeLabel.AutoSize = true;
            this.BaroAltitudeLabel.Location = new System.Drawing.Point(7, 15);
            this.BaroAltitudeLabel.Name = "BaroAltitudeLabel";
            this.BaroAltitudeLabel.Size = new System.Drawing.Size(29, 13);
            this.BaroAltitudeLabel.TabIndex = 75;
            this.BaroAltitudeLabel.Text = "Baro";
            // 
            // YawGyroLabel
            // 
            this.YawGyroLabel.AutoSize = true;
            this.YawGyroLabel.Location = new System.Drawing.Point(7, 53);
            this.YawGyroLabel.Name = "YawGyroLabel";
            this.YawGyroLabel.Size = new System.Drawing.Size(28, 13);
            this.YawGyroLabel.TabIndex = 78;
            this.YawGyroLabel.Text = "Yaw";
            // 
            // PitchRateLabel
            // 
            this.PitchRateLabel.AutoSize = true;
            this.PitchRateLabel.Location = new System.Drawing.Point(7, 37);
            this.PitchRateLabel.Name = "PitchRateLabel";
            this.PitchRateLabel.Size = new System.Drawing.Size(31, 13);
            this.PitchRateLabel.TabIndex = 77;
            this.PitchRateLabel.Text = "Pitch";
            // 
            // RollRateLabel
            // 
            this.RollRateLabel.AutoSize = true;
            this.RollRateLabel.Location = new System.Drawing.Point(7, 17);
            this.RollRateLabel.Name = "RollRateLabel";
            this.RollRateLabel.Size = new System.Drawing.Size(25, 13);
            this.RollRateLabel.TabIndex = 76;
            this.RollRateLabel.Text = "Roll";
            // 
            // RxTypeErr
            // 
            this.RxTypeErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RxTypeErr.Location = new System.Drawing.Point(96, 16);
            this.RxTypeErr.Name = "RxTypeErr";
            this.RxTypeErr.ReadOnly = true;
            this.RxTypeErr.Size = new System.Drawing.Size(30, 13);
            this.RxTypeErr.TabIndex = 82;
            this.RxTypeErr.Text = "-";
            this.RxTypeErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxCSumErr
            // 
            this.RxCSumErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RxCSumErr.Location = new System.Drawing.Point(264, 16);
            this.RxCSumErr.Name = "RxCSumErr";
            this.RxCSumErr.ReadOnly = true;
            this.RxCSumErr.Size = new System.Drawing.Size(30, 13);
            this.RxCSumErr.TabIndex = 83;
            this.RxCSumErr.Text = "-";
            this.RxCSumErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxLenErr
            // 
            this.RxLenErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RxLenErr.Location = new System.Drawing.Point(178, 16);
            this.RxLenErr.Name = "RxLenErr";
            this.RxLenErr.ReadOnly = true;
            this.RxLenErr.Size = new System.Drawing.Size(30, 13);
            this.RxLenErr.TabIndex = 84;
            this.RxLenErr.Text = "-";
            this.RxLenErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxTypeLabel
            // 
            this.RxTypeLabel.AutoSize = true;
            this.RxTypeLabel.Location = new System.Drawing.Point(8, 16);
            this.RxTypeLabel.Name = "RxTypeLabel";
            this.RxTypeLabel.Size = new System.Drawing.Size(89, 13);
            this.RxTypeLabel.TabIndex = 85;
            this.RxTypeLabel.Text = "Packet        Type";
            // 
            // RxCSumLabel
            // 
            this.RxCSumLabel.AutoSize = true;
            this.RxCSumLabel.Location = new System.Drawing.Point(223, 16);
            this.RxCSumLabel.Name = "RxCSumLabel";
            this.RxCSumLabel.Size = new System.Drawing.Size(35, 13);
            this.RxCSumLabel.TabIndex = 86;
            this.RxCSumLabel.Text = "CSum";
            // 
            // RxLenLabel
            // 
            this.RxLenLabel.AutoSize = true;
            this.RxLenLabel.Location = new System.Drawing.Point(137, 16);
            this.RxLenLabel.Name = "RxLenLabel";
            this.RxLenLabel.Size = new System.Drawing.Size(40, 13);
            this.RxLenLabel.TabIndex = 87;
            this.RxLenLabel.Text = "Length";
            // 
            // FlightState
            // 
            this.FlightState.Location = new System.Drawing.Point(11, 28);
            this.FlightState.Name = "FlightState";
            this.FlightState.ReadOnly = true;
            this.FlightState.Size = new System.Drawing.Size(73, 20);
            this.FlightState.TabIndex = 89;
            this.FlightState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GyroGroupBox
            // 
            this.GyroGroupBox.Controls.Add(this.RollRate);
            this.GyroGroupBox.Controls.Add(this.PitchRate);
            this.GyroGroupBox.Controls.Add(this.YawGyro);
            this.GyroGroupBox.Controls.Add(this.RollRateLabel);
            this.GyroGroupBox.Controls.Add(this.PitchRateLabel);
            this.GyroGroupBox.Controls.Add(this.YawGyroLabel);
            this.GyroGroupBox.Location = new System.Drawing.Point(12, 201);
            this.GyroGroupBox.Name = "GyroGroupBox";
            this.GyroGroupBox.Size = new System.Drawing.Size(77, 73);
            this.GyroGroupBox.TabIndex = 92;
            this.GyroGroupBox.TabStop = false;
            this.GyroGroupBox.Text = "Gyros(Deg)";
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.Controls.Add(this.DesiredYaw);
            this.ControlsGroupBox.Controls.Add(this.DesiredRoll);
            this.ControlsGroupBox.Controls.Add(this.DesiredPitch);
            this.ControlsGroupBox.Controls.Add(this.DesiredRollLabel);
            this.ControlsGroupBox.Controls.Add(this.DesiredPitchLabel);
            this.ControlsGroupBox.Controls.Add(this.DesiredYawLabel);
            this.ControlsGroupBox.Controls.Add(this.DesiredThrottle);
            this.ControlsGroupBox.Controls.Add(this.DesiredThrottleLabel);
            this.ControlsGroupBox.Location = new System.Drawing.Point(12, 102);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Size = new System.Drawing.Size(77, 93);
            this.ControlsGroupBox.TabIndex = 93;
            this.ControlsGroupBox.TabStop = false;
            this.ControlsGroupBox.Text = "Controls(%)";
            // 
            // AttitudeGroupBox
            // 
            this.AttitudeGroupBox.Controls.Add(this.AccConfidenceLabel);
            this.AttitudeGroupBox.Controls.Add(this.YawLabel);
            this.AttitudeGroupBox.Controls.Add(this.PitchLabel);
            this.AttitudeGroupBox.Controls.Add(this.AccConfidence);
            this.AttitudeGroupBox.Controls.Add(this.RollLabel);
            this.AttitudeGroupBox.Controls.Add(this.RollAngle);
            this.AttitudeGroupBox.Controls.Add(this.PitchAngle);
            this.AttitudeGroupBox.Controls.Add(this.YawAngle);
            this.AttitudeGroupBox.Location = new System.Drawing.Point(95, 102);
            this.AttitudeGroupBox.Name = "AttitudeGroupBox";
            this.AttitudeGroupBox.Size = new System.Drawing.Size(77, 93);
            this.AttitudeGroupBox.TabIndex = 94;
            this.AttitudeGroupBox.TabStop = false;
            this.AttitudeGroupBox.Text = "Attitude";
            // 
            // AccConfidenceLabel
            // 
            this.AccConfidenceLabel.AutoSize = true;
            this.AccConfidenceLabel.Location = new System.Drawing.Point(5, 19);
            this.AccConfidenceLabel.Name = "AccConfidenceLabel";
            this.AccConfidenceLabel.Size = new System.Drawing.Size(40, 13);
            this.AccConfidenceLabel.TabIndex = 111;
            this.AccConfidenceLabel.Text = "Acc(%)";
            // 
            // YawLabel
            // 
            this.YawLabel.AutoSize = true;
            this.YawLabel.Location = new System.Drawing.Point(5, 73);
            this.YawLabel.Name = "YawLabel";
            this.YawLabel.Size = new System.Drawing.Size(28, 13);
            this.YawLabel.TabIndex = 109;
            this.YawLabel.Text = "Yaw";
            // 
            // PitchLabel
            // 
            this.PitchLabel.AutoSize = true;
            this.PitchLabel.Location = new System.Drawing.Point(5, 56);
            this.PitchLabel.Name = "PitchLabel";
            this.PitchLabel.Size = new System.Drawing.Size(31, 13);
            this.PitchLabel.TabIndex = 108;
            this.PitchLabel.Text = "Pitch";
            // 
            // AccConfidence
            // 
            this.AccConfidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccConfidence.Location = new System.Drawing.Point(45, 19);
            this.AccConfidence.Name = "AccConfidence";
            this.AccConfidence.ReadOnly = true;
            this.AccConfidence.Size = new System.Drawing.Size(25, 13);
            this.AccConfidence.TabIndex = 110;
            this.AccConfidence.Text = "-";
            this.AccConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RollLabel
            // 
            this.RollLabel.AutoSize = true;
            this.RollLabel.Location = new System.Drawing.Point(5, 37);
            this.RollLabel.Name = "RollLabel";
            this.RollLabel.Size = new System.Drawing.Size(25, 13);
            this.RollLabel.TabIndex = 107;
            this.RollLabel.Text = "Roll";
            // 
            // AccelerationsGroupBox
            // 
            this.AccelerationsGroupBox.Controls.Add(this.LRAcc);
            this.AccelerationsGroupBox.Controls.Add(this.FBAcc);
            this.AccelerationsGroupBox.Controls.Add(this.DUAcc);
            this.AccelerationsGroupBox.Controls.Add(this.LRAccLabel);
            this.AccelerationsGroupBox.Controls.Add(this.FBAccLabel);
            this.AccelerationsGroupBox.Controls.Add(this.DUAccLabel);
            this.AccelerationsGroupBox.Location = new System.Drawing.Point(95, 202);
            this.AccelerationsGroupBox.Name = "AccelerationsGroupBox";
            this.AccelerationsGroupBox.Size = new System.Drawing.Size(77, 73);
            this.AccelerationsGroupBox.TabIndex = 95;
            this.AccelerationsGroupBox.TabStop = false;
            this.AccelerationsGroupBox.Text = "Accel. (G)";
            // 
            // CommsGroupBox
            // 
            this.CommsGroupBox.Controls.Add(this.SerialBRxProgressBar);
            this.CommsGroupBox.Controls.Add(this.SerialARxProgressBar);
            this.CommsGroupBox.Controls.Add(this.SerialBTxProgressBar);
            this.CommsGroupBox.Controls.Add(this.SerialATxProgressBar);
            this.CommsGroupBox.Controls.Add(this.SerailBRxEntries);
            this.CommsGroupBox.Controls.Add(this.SerialBTxEntries);
            this.CommsGroupBox.Controls.Add(this.SerialBLabel);
            this.CommsGroupBox.Controls.Add(this.SerialARxEntries);
            this.CommsGroupBox.Controls.Add(this.SerialATxEntries);
            this.CommsGroupBox.Controls.Add(this.SerialAlLabel);
            this.CommsGroupBox.Controls.Add(this.RxTypeErr);
            this.CommsGroupBox.Controls.Add(this.RxCSumErr);
            this.CommsGroupBox.Controls.Add(this.RxLenErr);
            this.CommsGroupBox.Controls.Add(this.RxTypeLabel);
            this.CommsGroupBox.Controls.Add(this.RxCSumLabel);
            this.CommsGroupBox.Controls.Add(this.RxLenLabel);
            this.CommsGroupBox.Location = new System.Drawing.Point(12, 551);
            this.CommsGroupBox.Name = "CommsGroupBox";
            this.CommsGroupBox.Size = new System.Drawing.Size(304, 80);
            this.CommsGroupBox.TabIndex = 96;
            this.CommsGroupBox.TabStop = false;
            this.CommsGroupBox.Text = "RC & Telemetry";
            // 
            // SerialBRxProgressBar
            // 
            this.SerialBRxProgressBar.Location = new System.Drawing.Point(206, 62);
            this.SerialBRxProgressBar.Maximum = 1024;
            this.SerialBRxProgressBar.Name = "SerialBRxProgressBar";
            this.SerialBRxProgressBar.Size = new System.Drawing.Size(80, 10);
            this.SerialBRxProgressBar.Step = 1;
            this.SerialBRxProgressBar.TabIndex = 195;
            // 
            // SerialARxProgressBar
            // 
            this.SerialARxProgressBar.Location = new System.Drawing.Point(206, 41);
            this.SerialARxProgressBar.Maximum = 1024;
            this.SerialARxProgressBar.Name = "SerialARxProgressBar";
            this.SerialARxProgressBar.Size = new System.Drawing.Size(80, 10);
            this.SerialARxProgressBar.Step = 1;
            this.SerialARxProgressBar.TabIndex = 194;
            // 
            // SerialBTxProgressBar
            // 
            this.SerialBTxProgressBar.Location = new System.Drawing.Point(79, 60);
            this.SerialBTxProgressBar.Maximum = 1024;
            this.SerialBTxProgressBar.Name = "SerialBTxProgressBar";
            this.SerialBTxProgressBar.Size = new System.Drawing.Size(80, 10);
            this.SerialBTxProgressBar.Step = 1;
            this.SerialBTxProgressBar.TabIndex = 193;
            // 
            // SerialATxProgressBar
            // 
            this.SerialATxProgressBar.Location = new System.Drawing.Point(79, 40);
            this.SerialATxProgressBar.Maximum = 1024;
            this.SerialATxProgressBar.Name = "SerialATxProgressBar";
            this.SerialATxProgressBar.Size = new System.Drawing.Size(80, 10);
            this.SerialATxProgressBar.Step = 1;
            this.SerialATxProgressBar.TabIndex = 192;
            // 
            // SerailBRxEntries
            // 
            this.SerailBRxEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerailBRxEntries.Location = new System.Drawing.Point(173, 59);
            this.SerailBRxEntries.Name = "SerailBRxEntries";
            this.SerailBRxEntries.ReadOnly = true;
            this.SerailBRxEntries.Size = new System.Drawing.Size(25, 13);
            this.SerailBRxEntries.TabIndex = 94;
            this.SerailBRxEntries.Text = "-";
            this.SerailBRxEntries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialBTxEntries
            // 
            this.SerialBTxEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialBTxEntries.Location = new System.Drawing.Point(48, 59);
            this.SerialBTxEntries.Name = "SerialBTxEntries";
            this.SerialBTxEntries.ReadOnly = true;
            this.SerialBTxEntries.Size = new System.Drawing.Size(25, 13);
            this.SerialBTxEntries.TabIndex = 92;
            this.SerialBTxEntries.Text = "-";
            this.SerialBTxEntries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialBLabel
            // 
            this.SerialBLabel.AutoSize = true;
            this.SerialBLabel.Location = new System.Drawing.Point(6, 61);
            this.SerialBLabel.Name = "SerialBLabel";
            this.SerialBLabel.Size = new System.Drawing.Size(40, 13);
            this.SerialBLabel.TabIndex = 93;
            this.SerialBLabel.Text = "SerialB";
            // 
            // SerialARxEntries
            // 
            this.SerialARxEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialARxEntries.Location = new System.Drawing.Point(174, 38);
            this.SerialARxEntries.Name = "SerialARxEntries";
            this.SerialARxEntries.ReadOnly = true;
            this.SerialARxEntries.Size = new System.Drawing.Size(25, 13);
            this.SerialARxEntries.TabIndex = 90;
            this.SerialARxEntries.Text = "-";
            this.SerialARxEntries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialATxEntries
            // 
            this.SerialATxEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialATxEntries.Location = new System.Drawing.Point(48, 38);
            this.SerialATxEntries.Name = "SerialATxEntries";
            this.SerialATxEntries.ReadOnly = true;
            this.SerialATxEntries.Size = new System.Drawing.Size(25, 13);
            this.SerialATxEntries.TabIndex = 88;
            this.SerialATxEntries.Text = "-";
            this.SerialATxEntries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialAlLabel
            // 
            this.SerialAlLabel.AutoSize = true;
            this.SerialAlLabel.Location = new System.Drawing.Point(6, 40);
            this.SerialAlLabel.Name = "SerialAlLabel";
            this.SerialAlLabel.Size = new System.Drawing.Size(40, 13);
            this.SerialAlLabel.TabIndex = 89;
            this.SerialAlLabel.Text = "SerialA";
            // 
            // SensorTemp
            // 
            this.SensorTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SensorTemp.Location = new System.Drawing.Point(209, 21);
            this.SensorTemp.Name = "SensorTemp";
            this.SensorTemp.ReadOnly = true;
            this.SensorTemp.Size = new System.Drawing.Size(48, 13);
            this.SensorTemp.TabIndex = 161;
            this.SensorTemp.Text = "0.0";
            this.SensorTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatteryGroupBox
            // 
            this.BatteryGroupBox.Controls.Add(this.BatteryCharge);
            this.BatteryGroupBox.Controls.Add(this.BatteryChargeLabel);
            this.BatteryGroupBox.Controls.Add(this.BatteryVolts);
            this.BatteryGroupBox.Controls.Add(this.BatteryCurrent);
            this.BatteryGroupBox.Controls.Add(this.VoltsLabel);
            this.BatteryGroupBox.Controls.Add(this.CurrentLabel);
            this.BatteryGroupBox.Location = new System.Drawing.Point(587, 30);
            this.BatteryGroupBox.Name = "BatteryGroupBox";
            this.BatteryGroupBox.Size = new System.Drawing.Size(249, 40);
            this.BatteryGroupBox.TabIndex = 98;
            this.BatteryGroupBox.TabStop = false;
            this.BatteryGroupBox.Text = "Battery";
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.BackColor = System.Drawing.SystemColors.Control;
            this.BatteryCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BatteryCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryCharge.Location = new System.Drawing.Point(138, 15);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.ReadOnly = true;
            this.BatteryCharge.Size = new System.Drawing.Size(38, 15);
            this.BatteryCharge.TabIndex = 30;
            this.BatteryCharge.Text = "0";
            this.BatteryCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatteryChargeLabel
            // 
            this.BatteryChargeLabel.AutoSize = true;
            this.BatteryChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryChargeLabel.Location = new System.Drawing.Point(182, 15);
            this.BatteryChargeLabel.Name = "BatteryChargeLabel";
            this.BatteryChargeLabel.Size = new System.Drawing.Size(41, 16);
            this.BatteryChargeLabel.TabIndex = 31;
            this.BatteryChargeLabel.Text = "mAH";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NavBox);
            this.flowLayoutPanel1.Controls.Add(this.RTHBox);
            this.flowLayoutPanel1.Controls.Add(this.GPSValidBox);
            this.flowLayoutPanel1.Controls.Add(this.AngleControlBox);
            this.flowLayoutPanel1.Controls.Add(this.NavValidBox);
            this.flowLayoutPanel1.Controls.Add(this.OffsetOriginValidBox);
            this.flowLayoutPanel1.Controls.Add(this.ThrottleMovingBox);
            this.flowLayoutPanel1.Controls.Add(this.AltHoldBox);
            this.flowLayoutPanel1.Controls.Add(this.HoldingAltBox);
            this.flowLayoutPanel1.Controls.Add(this.RapidDescentHazardFlagBox);
            this.flowLayoutPanel1.Controls.Add(this.BaroAltValidBox);
            this.flowLayoutPanel1.Controls.Add(this.GPSAltitudeBox);
            this.flowLayoutPanel1.Controls.Add(this.RangefinderAltValidBox);
            this.flowLayoutPanel1.Controls.Add(this.UsingRangefinderBox);
            this.flowLayoutPanel1.Controls.Add(this.NearLevelBox);
            this.flowLayoutPanel1.Controls.Add(this.AttitudeHoldBox);
            this.flowLayoutPanel1.Controls.Add(this.NavigateBox);
            this.flowLayoutPanel1.Controls.Add(this.TurnToPOIBox);
            this.flowLayoutPanel1.Controls.Add(this.CloseProximityBox);
            this.flowLayoutPanel1.Controls.Add(this.ProximityBox);
            this.flowLayoutPanel1.Controls.Add(this.UseRTHAutoDescendBox);
            this.flowLayoutPanel1.Controls.Add(this.LandingSwitchBox);
            this.flowLayoutPanel1.Controls.Add(this.LowBatteryBox);
            this.flowLayoutPanel1.Controls.Add(this.IMUFailBox);
            this.flowLayoutPanel1.Controls.Add(this.GPSFailBox);
            this.flowLayoutPanel1.Controls.Add(this.BaroFailBox);
            this.flowLayoutPanel1.Controls.Add(this.MagFailBox);
            this.flowLayoutPanel1.Controls.Add(this.BypassBox);
            this.flowLayoutPanel1.Controls.Add(this.DCMotorsBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 388);
            this.flowLayoutPanel1.TabIndex = 99;
            // 
            // NavBox
            // 
            this.NavBox.BackColor = System.Drawing.SystemColors.Window;
            this.NavBox.Location = new System.Drawing.Point(3, 3);
            this.NavBox.Name = "NavBox";
            this.NavBox.ReadOnly = true;
            this.NavBox.Size = new System.Drawing.Size(109, 20);
            this.NavBox.TabIndex = 127;
            this.NavBox.Text = "Navigate";
            this.NavBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RTHBox
            // 
            this.RTHBox.BackColor = System.Drawing.SystemColors.Window;
            this.RTHBox.Location = new System.Drawing.Point(118, 3);
            this.RTHBox.Name = "RTHBox";
            this.RTHBox.ReadOnly = true;
            this.RTHBox.Size = new System.Drawing.Size(109, 20);
            this.RTHBox.TabIndex = 126;
            this.RTHBox.Text = "RTH";
            this.RTHBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPSValidBox
            // 
            this.GPSValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.GPSValidBox.Location = new System.Drawing.Point(3, 29);
            this.GPSValidBox.Name = "GPSValidBox";
            this.GPSValidBox.ReadOnly = true;
            this.GPSValidBox.Size = new System.Drawing.Size(109, 20);
            this.GPSValidBox.TabIndex = 105;
            this.GPSValidBox.Text = "GPS Valid";
            this.GPSValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AngleControlBox
            // 
            this.AngleControlBox.BackColor = System.Drawing.SystemColors.Window;
            this.AngleControlBox.Location = new System.Drawing.Point(118, 29);
            this.AngleControlBox.Name = "AngleControlBox";
            this.AngleControlBox.ReadOnly = true;
            this.AngleControlBox.Size = new System.Drawing.Size(109, 20);
            this.AngleControlBox.TabIndex = 116;
            this.AngleControlBox.Text = "Angle Control";
            this.AngleControlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NavValidBox
            // 
            this.NavValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.NavValidBox.Location = new System.Drawing.Point(3, 55);
            this.NavValidBox.Name = "NavValidBox";
            this.NavValidBox.ReadOnly = true;
            this.NavValidBox.Size = new System.Drawing.Size(109, 20);
            this.NavValidBox.TabIndex = 107;
            this.NavValidBox.Text = "Origin Valid";
            this.NavValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OffsetOriginValidBox
            // 
            this.OffsetOriginValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.OffsetOriginValidBox.Location = new System.Drawing.Point(118, 55);
            this.OffsetOriginValidBox.Name = "OffsetOriginValidBox";
            this.OffsetOriginValidBox.ReadOnly = true;
            this.OffsetOriginValidBox.Size = new System.Drawing.Size(109, 20);
            this.OffsetOriginValidBox.TabIndex = 127;
            this.OffsetOriginValidBox.Text = "Offset Origin Valid";
            this.OffsetOriginValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThrottleMovingBox
            // 
            this.ThrottleMovingBox.BackColor = System.Drawing.SystemColors.Window;
            this.ThrottleMovingBox.Location = new System.Drawing.Point(3, 81);
            this.ThrottleMovingBox.Name = "ThrottleMovingBox";
            this.ThrottleMovingBox.ReadOnly = true;
            this.ThrottleMovingBox.Size = new System.Drawing.Size(109, 20);
            this.ThrottleMovingBox.TabIndex = 113;
            this.ThrottleMovingBox.Text = "Throttle Moving";
            this.ThrottleMovingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AltHoldBox
            // 
            this.AltHoldBox.AcceptsTab = true;
            this.AltHoldBox.BackColor = System.Drawing.SystemColors.Window;
            this.AltHoldBox.Location = new System.Drawing.Point(118, 81);
            this.AltHoldBox.Name = "AltHoldBox";
            this.AltHoldBox.ReadOnly = true;
            this.AltHoldBox.Size = new System.Drawing.Size(109, 20);
            this.AltHoldBox.TabIndex = 100;
            this.AltHoldBox.Text = "Alt Hold Enabled";
            this.AltHoldBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoldingAltBox
            // 
            this.HoldingAltBox.BackColor = System.Drawing.SystemColors.Window;
            this.HoldingAltBox.Location = new System.Drawing.Point(3, 107);
            this.HoldingAltBox.Name = "HoldingAltBox";
            this.HoldingAltBox.ReadOnly = true;
            this.HoldingAltBox.Size = new System.Drawing.Size(109, 20);
            this.HoldingAltBox.TabIndex = 114;
            this.HoldingAltBox.Text = "Holding Altitude";
            this.HoldingAltBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RapidDescentHazardFlagBox
            // 
            this.RapidDescentHazardFlagBox.BackColor = System.Drawing.SystemColors.Window;
            this.RapidDescentHazardFlagBox.Location = new System.Drawing.Point(118, 107);
            this.RapidDescentHazardFlagBox.Name = "RapidDescentHazardFlagBox";
            this.RapidDescentHazardFlagBox.ReadOnly = true;
            this.RapidDescentHazardFlagBox.Size = new System.Drawing.Size(109, 20);
            this.RapidDescentHazardFlagBox.TabIndex = 102;
            this.RapidDescentHazardFlagBox.Text = "VRS Hazard";
            this.RapidDescentHazardFlagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaroAltValidBox
            // 
            this.BaroAltValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.BaroAltValidBox.Location = new System.Drawing.Point(3, 133);
            this.BaroAltValidBox.Name = "BaroAltValidBox";
            this.BaroAltValidBox.ReadOnly = true;
            this.BaroAltValidBox.Size = new System.Drawing.Size(109, 20);
            this.BaroAltValidBox.TabIndex = 121;
            this.BaroAltValidBox.Text = "Baro Alt Valid";
            this.BaroAltValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPSAltitudeBox
            // 
            this.GPSAltitudeBox.AcceptsTab = true;
            this.GPSAltitudeBox.BackColor = System.Drawing.SystemColors.Window;
            this.GPSAltitudeBox.Location = new System.Drawing.Point(118, 133);
            this.GPSAltitudeBox.Name = "GPSAltitudeBox";
            this.GPSAltitudeBox.ReadOnly = true;
            this.GPSAltitudeBox.Size = new System.Drawing.Size(109, 20);
            this.GPSAltitudeBox.TabIndex = 126;
            this.GPSAltitudeBox.Text = "Using GPS Alt";
            this.GPSAltitudeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RangefinderAltValidBox
            // 
            this.RangefinderAltValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.RangefinderAltValidBox.Location = new System.Drawing.Point(3, 159);
            this.RangefinderAltValidBox.Name = "RangefinderAltValidBox";
            this.RangefinderAltValidBox.ReadOnly = true;
            this.RangefinderAltValidBox.Size = new System.Drawing.Size(109, 20);
            this.RangefinderAltValidBox.TabIndex = 122;
            this.RangefinderAltValidBox.Text = "Rangefinder Valid";
            this.RangefinderAltValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsingRangefinderBox
            // 
            this.UsingRangefinderBox.BackColor = System.Drawing.SystemColors.Window;
            this.UsingRangefinderBox.Location = new System.Drawing.Point(118, 159);
            this.UsingRangefinderBox.Name = "UsingRangefinderBox";
            this.UsingRangefinderBox.ReadOnly = true;
            this.UsingRangefinderBox.Size = new System.Drawing.Size(109, 20);
            this.UsingRangefinderBox.TabIndex = 123;
            this.UsingRangefinderBox.Text = "Using Rangefinder";
            this.UsingRangefinderBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NearLevelBox
            // 
            this.NearLevelBox.BackColor = System.Drawing.SystemColors.Window;
            this.NearLevelBox.Location = new System.Drawing.Point(3, 185);
            this.NearLevelBox.Name = "NearLevelBox";
            this.NearLevelBox.ReadOnly = true;
            this.NearLevelBox.Size = new System.Drawing.Size(109, 20);
            this.NearLevelBox.TabIndex = 104;
            this.NearLevelBox.Text = "Near Level";
            this.NearLevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttitudeHoldBox
            // 
            this.AttitudeHoldBox.BackColor = System.Drawing.SystemColors.Window;
            this.AttitudeHoldBox.Location = new System.Drawing.Point(118, 185);
            this.AttitudeHoldBox.Name = "AttitudeHoldBox";
            this.AttitudeHoldBox.ReadOnly = true;
            this.AttitudeHoldBox.Size = new System.Drawing.Size(109, 20);
            this.AttitudeHoldBox.TabIndex = 112;
            this.AttitudeHoldBox.Text = "Holding Roll&Pitch";
            this.AttitudeHoldBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NavigateBox
            // 
            this.NavigateBox.BackColor = System.Drawing.SystemColors.Window;
            this.NavigateBox.Location = new System.Drawing.Point(3, 211);
            this.NavigateBox.Name = "NavigateBox";
            this.NavigateBox.ReadOnly = true;
            this.NavigateBox.Size = new System.Drawing.Size(109, 20);
            this.NavigateBox.TabIndex = 115;
            this.NavigateBox.Text = "Transiting";
            this.NavigateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TurnToPOIBox
            // 
            this.TurnToPOIBox.BackColor = System.Drawing.SystemColors.Window;
            this.TurnToPOIBox.Location = new System.Drawing.Point(118, 211);
            this.TurnToPOIBox.Name = "TurnToPOIBox";
            this.TurnToPOIBox.ReadOnly = true;
            this.TurnToPOIBox.Size = new System.Drawing.Size(109, 20);
            this.TurnToPOIBox.TabIndex = 101;
            this.TurnToPOIBox.Text = "Turn to POI";
            this.TurnToPOIBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseProximityBox
            // 
            this.CloseProximityBox.BackColor = System.Drawing.SystemColors.Window;
            this.CloseProximityBox.Location = new System.Drawing.Point(3, 237);
            this.CloseProximityBox.Name = "CloseProximityBox";
            this.CloseProximityBox.ReadOnly = true;
            this.CloseProximityBox.Size = new System.Drawing.Size(109, 20);
            this.CloseProximityBox.TabIndex = 118;
            this.CloseProximityBox.Text = "Centered";
            this.CloseProximityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProximityBox
            // 
            this.ProximityBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProximityBox.Location = new System.Drawing.Point(118, 237);
            this.ProximityBox.Name = "ProximityBox";
            this.ProximityBox.ReadOnly = true;
            this.ProximityBox.Size = new System.Drawing.Size(109, 20);
            this.ProximityBox.TabIndex = 117;
            this.ProximityBox.Text = "WP Achieved";
            this.ProximityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UseRTHAutoDescendBox
            // 
            this.UseRTHAutoDescendBox.BackColor = System.Drawing.SystemColors.Window;
            this.UseRTHAutoDescendBox.Location = new System.Drawing.Point(3, 263);
            this.UseRTHAutoDescendBox.Name = "UseRTHAutoDescendBox";
            this.UseRTHAutoDescendBox.ReadOnly = true;
            this.UseRTHAutoDescendBox.Size = new System.Drawing.Size(109, 20);
            this.UseRTHAutoDescendBox.TabIndex = 120;
            this.UseRTHAutoDescendBox.Text = "Using Auto Land";
            this.UseRTHAutoDescendBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LandingSwitchBox
            // 
            this.LandingSwitchBox.BackColor = System.Drawing.SystemColors.Window;
            this.LandingSwitchBox.Location = new System.Drawing.Point(118, 263);
            this.LandingSwitchBox.Name = "LandingSwitchBox";
            this.LandingSwitchBox.ReadOnly = true;
            this.LandingSwitchBox.Size = new System.Drawing.Size(109, 20);
            this.LandingSwitchBox.TabIndex = 103;
            this.LandingSwitchBox.Text = "Contact Sw";
            this.LandingSwitchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LowBatteryBox
            // 
            this.LowBatteryBox.BackColor = System.Drawing.SystemColors.Window;
            this.LowBatteryBox.Location = new System.Drawing.Point(3, 289);
            this.LowBatteryBox.Name = "LowBatteryBox";
            this.LowBatteryBox.ReadOnly = true;
            this.LowBatteryBox.Size = new System.Drawing.Size(109, 20);
            this.LowBatteryBox.TabIndex = 106;
            this.LowBatteryBox.Text = "Low Battery";
            this.LowBatteryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IMUFailBox
            // 
            this.IMUFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.IMUFailBox.Location = new System.Drawing.Point(118, 289);
            this.IMUFailBox.Name = "IMUFailBox";
            this.IMUFailBox.ReadOnly = true;
            this.IMUFailBox.Size = new System.Drawing.Size(109, 20);
            this.IMUFailBox.TabIndex = 109;
            this.IMUFailBox.Text = "IMU Error";
            this.IMUFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPSFailBox
            // 
            this.GPSFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.GPSFailBox.Location = new System.Drawing.Point(3, 315);
            this.GPSFailBox.Name = "GPSFailBox";
            this.GPSFailBox.ReadOnly = true;
            this.GPSFailBox.Size = new System.Drawing.Size(109, 20);
            this.GPSFailBox.TabIndex = 111;
            this.GPSFailBox.Text = "GPS Error";
            this.GPSFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaroFailBox
            // 
            this.BaroFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.BaroFailBox.Location = new System.Drawing.Point(118, 315);
            this.BaroFailBox.Name = "BaroFailBox";
            this.BaroFailBox.ReadOnly = true;
            this.BaroFailBox.Size = new System.Drawing.Size(109, 20);
            this.BaroFailBox.TabIndex = 108;
            this.BaroFailBox.Text = "Baro Error";
            this.BaroFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MagFailBox
            // 
            this.MagFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.MagFailBox.Location = new System.Drawing.Point(3, 341);
            this.MagFailBox.Name = "MagFailBox";
            this.MagFailBox.ReadOnly = true;
            this.MagFailBox.Size = new System.Drawing.Size(109, 20);
            this.MagFailBox.TabIndex = 110;
            this.MagFailBox.Text = "Mag Error";
            this.MagFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BypassBox
            // 
            this.BypassBox.BackColor = System.Drawing.SystemColors.Window;
            this.BypassBox.Location = new System.Drawing.Point(118, 341);
            this.BypassBox.Name = "BypassBox";
            this.BypassBox.ReadOnly = true;
            this.BypassBox.Size = new System.Drawing.Size(109, 20);
            this.BypassBox.TabIndex = 125;
            this.BypassBox.Text = "PassThrough";
            this.BypassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DCMotorsBox
            // 
            this.DCMotorsBox.BackColor = System.Drawing.SystemColors.Window;
            this.DCMotorsBox.Location = new System.Drawing.Point(3, 367);
            this.DCMotorsBox.Name = "DCMotorsBox";
            this.DCMotorsBox.ReadOnly = true;
            this.DCMotorsBox.Size = new System.Drawing.Size(109, 20);
            this.DCMotorsBox.TabIndex = 128;
            this.DCMotorsBox.Text = "DC Motors";
            this.DCMotorsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FlagsGroupBox
            // 
            this.FlagsGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.FlagsGroupBox.Location = new System.Drawing.Point(587, 73);
            this.FlagsGroupBox.Name = "FlagsGroupBox";
            this.FlagsGroupBox.Size = new System.Drawing.Size(249, 410);
            this.FlagsGroupBox.TabIndex = 100;
            this.FlagsGroupBox.TabStop = false;
            this.FlagsGroupBox.Text = "Flags";
            // 
            // GPSStatusBox
            // 
            this.GPSStatusBox.Controls.Add(this.GPSHWVersionTextBox);
            this.GPSStatusBox.Controls.Add(this.GPSHWVersionLabel);
            this.GPSStatusBox.Controls.Add(this.GPSdTTextBox);
            this.GPSStatusBox.Controls.Add(this.GPSdTLabel);
            this.GPSStatusBox.Controls.Add(this.GPScAcc);
            this.GPSStatusBox.Controls.Add(this.GPScAccLabel);
            this.GPSStatusBox.Controls.Add(this.GPSvAcc);
            this.GPSStatusBox.Controls.Add(this.GPSvAccLabel);
            this.GPSStatusBox.Controls.Add(this.GPSHeadingLabel);
            this.GPSStatusBox.Controls.Add(this.GPSHeading);
            this.GPSStatusBox.Controls.Add(this.GPSNoOfSats);
            this.GPSStatusBox.Controls.Add(this.GPSFixLabel);
            this.GPSStatusBox.Controls.Add(this.GPSNoOfSatsLabel);
            this.GPSStatusBox.Controls.Add(this.GPSFix);
            this.GPSStatusBox.Controls.Add(this.GPSsAccLabel);
            this.GPSStatusBox.Controls.Add(this.GPSLongitudeLabel);
            this.GPSStatusBox.Controls.Add(this.GPSsAcc);
            this.GPSStatusBox.Controls.Add(this.GPShAcc);
            this.GPSStatusBox.Controls.Add(this.GPSVelLabel);
            this.GPSStatusBox.Controls.Add(this.GPSLatitudeLabel);
            this.GPSStatusBox.Controls.Add(this.hAccLabel);
            this.GPSStatusBox.Controls.Add(this.GPSLongitude);
            this.GPSStatusBox.Controls.Add(this.GPSVel);
            this.GPSStatusBox.Controls.Add(this.GPSLatitude);
            this.GPSStatusBox.Location = new System.Drawing.Point(12, 384);
            this.GPSStatusBox.Name = "GPSStatusBox";
            this.GPSStatusBox.Size = new System.Drawing.Size(305, 105);
            this.GPSStatusBox.TabIndex = 101;
            this.GPSStatusBox.TabStop = false;
            this.GPSStatusBox.Text = "GPS";
            // 
            // GPSHWVersionTextBox
            // 
            this.GPSHWVersionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSHWVersionTextBox.Location = new System.Drawing.Point(76, 14);
            this.GPSHWVersionTextBox.Name = "GPSHWVersionTextBox";
            this.GPSHWVersionTextBox.ReadOnly = true;
            this.GPSHWVersionTextBox.Size = new System.Drawing.Size(60, 13);
            this.GPSHWVersionTextBox.TabIndex = 158;
            this.GPSHWVersionTextBox.Text = "-";
            this.GPSHWVersionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSHWVersionLabel
            // 
            this.GPSHWVersionLabel.AutoSize = true;
            this.GPSHWVersionLabel.Location = new System.Drawing.Point(8, 15);
            this.GPSHWVersionLabel.Name = "GPSHWVersionLabel";
            this.GPSHWVersionLabel.Size = new System.Drawing.Size(64, 13);
            this.GPSHWVersionLabel.TabIndex = 159;
            this.GPSHWVersionLabel.Text = "HW Version";
            // 
            // GPSdTTextBox
            // 
            this.GPSdTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSdTTextBox.Location = new System.Drawing.Point(88, 52);
            this.GPSdTTextBox.Name = "GPSdTTextBox";
            this.GPSdTTextBox.ReadOnly = true;
            this.GPSdTTextBox.Size = new System.Drawing.Size(46, 13);
            this.GPSdTTextBox.TabIndex = 156;
            this.GPSdTTextBox.Text = "-";
            this.GPSdTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSdTLabel
            // 
            this.GPSdTLabel.AutoSize = true;
            this.GPSdTLabel.Location = new System.Drawing.Point(8, 52);
            this.GPSdTLabel.Name = "GPSdTLabel";
            this.GPSdTLabel.Size = new System.Drawing.Size(41, 13);
            this.GPSdTLabel.TabIndex = 157;
            this.GPSdTLabel.Text = "dT(mS)";
            // 
            // GPScAcc
            // 
            this.GPScAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPScAcc.Location = new System.Drawing.Point(256, 52);
            this.GPScAcc.Name = "GPScAcc";
            this.GPScAcc.ReadOnly = true;
            this.GPScAcc.Size = new System.Drawing.Size(37, 13);
            this.GPScAcc.TabIndex = 75;
            this.GPScAcc.Text = "-";
            this.GPScAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPScAccLabel
            // 
            this.GPScAccLabel.AutoSize = true;
            this.GPScAccLabel.Location = new System.Drawing.Point(237, 52);
            this.GPScAccLabel.Name = "GPScAccLabel";
            this.GPScAccLabel.Size = new System.Drawing.Size(20, 13);
            this.GPScAccLabel.TabIndex = 76;
            this.GPScAccLabel.Text = "cA";
            // 
            // GPSvAcc
            // 
            this.GPSvAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSvAcc.Location = new System.Drawing.Point(256, 32);
            this.GPSvAcc.Name = "GPSvAcc";
            this.GPSvAcc.ReadOnly = true;
            this.GPSvAcc.Size = new System.Drawing.Size(37, 13);
            this.GPSvAcc.TabIndex = 73;
            this.GPSvAcc.Text = "-";
            this.GPSvAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSvAccLabel
            // 
            this.GPSvAccLabel.AutoSize = true;
            this.GPSvAccLabel.Location = new System.Drawing.Point(238, 32);
            this.GPSvAccLabel.Name = "GPSvAccLabel";
            this.GPSvAccLabel.Size = new System.Drawing.Size(20, 13);
            this.GPSvAccLabel.TabIndex = 74;
            this.GPSvAccLabel.Text = "vA";
            // 
            // GPSHeadingLabel
            // 
            this.GPSHeadingLabel.AutoSize = true;
            this.GPSHeadingLabel.Location = new System.Drawing.Point(8, 86);
            this.GPSHeadingLabel.Name = "GPSHeadingLabel";
            this.GPSHeadingLabel.Size = new System.Drawing.Size(56, 13);
            this.GPSHeadingLabel.TabIndex = 155;
            this.GPSHeadingLabel.Text = "COG(Deg)";
            // 
            // GPSHeading
            // 
            this.GPSHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSHeading.Location = new System.Drawing.Point(97, 88);
            this.GPSHeading.Name = "GPSHeading";
            this.GPSHeading.ReadOnly = true;
            this.GPSHeading.Size = new System.Drawing.Size(37, 13);
            this.GPSHeading.TabIndex = 154;
            this.GPSHeading.Text = "-";
            this.GPSHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSsAccLabel
            // 
            this.GPSsAccLabel.AutoSize = true;
            this.GPSsAccLabel.Location = new System.Drawing.Point(150, 52);
            this.GPSsAccLabel.Name = "GPSsAccLabel";
            this.GPSsAccLabel.Size = new System.Drawing.Size(19, 13);
            this.GPSsAccLabel.TabIndex = 72;
            this.GPSsAccLabel.Text = "sA";
            // 
            // GPSLongitudeLabel
            // 
            this.GPSLongitudeLabel.AutoSize = true;
            this.GPSLongitudeLabel.Location = new System.Drawing.Point(149, 86);
            this.GPSLongitudeLabel.Name = "GPSLongitudeLabel";
            this.GPSLongitudeLabel.Size = new System.Drawing.Size(54, 13);
            this.GPSLongitudeLabel.TabIndex = 63;
            this.GPSLongitudeLabel.Text = "Longitude";
            // 
            // GPSsAcc
            // 
            this.GPSsAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSsAcc.Location = new System.Drawing.Point(172, 52);
            this.GPSsAcc.Name = "GPSsAcc";
            this.GPSsAcc.ReadOnly = true;
            this.GPSsAcc.Size = new System.Drawing.Size(39, 13);
            this.GPSsAcc.TabIndex = 71;
            this.GPSsAcc.Text = "-";
            this.GPSsAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSVelLabel
            // 
            this.GPSVelLabel.AutoSize = true;
            this.GPSVelLabel.Location = new System.Drawing.Point(8, 69);
            this.GPSVelLabel.Name = "GPSVelLabel";
            this.GPSVelLabel.Size = new System.Drawing.Size(68, 13);
            this.GPSVelLabel.TabIndex = 60;
            this.GPSVelLabel.Text = "Speed (M/S)";
            // 
            // GPSLatitudeLabel
            // 
            this.GPSLatitudeLabel.AutoSize = true;
            this.GPSLatitudeLabel.Location = new System.Drawing.Point(148, 69);
            this.GPSLatitudeLabel.Name = "GPSLatitudeLabel";
            this.GPSLatitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.GPSLatitudeLabel.TabIndex = 61;
            this.GPSLatitudeLabel.Text = "Latitude";
            // 
            // GPSLongitude
            // 
            this.GPSLongitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSLongitude.Location = new System.Drawing.Point(220, 86);
            this.GPSLongitude.Name = "GPSLongitude";
            this.GPSLongitude.ReadOnly = true;
            this.GPSLongitude.Size = new System.Drawing.Size(73, 13);
            this.GPSLongitude.TabIndex = 56;
            this.GPSLongitude.Text = "-";
            this.GPSLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSVel
            // 
            this.GPSVel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSVel.Location = new System.Drawing.Point(97, 69);
            this.GPSVel.Name = "GPSVel";
            this.GPSVel.ReadOnly = true;
            this.GPSVel.Size = new System.Drawing.Size(37, 13);
            this.GPSVel.TabIndex = 45;
            this.GPSVel.Text = "-";
            this.GPSVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSLatitude
            // 
            this.GPSLatitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPSLatitude.Location = new System.Drawing.Point(220, 69);
            this.GPSLatitude.Name = "GPSLatitude";
            this.GPSLatitude.ReadOnly = true;
            this.GPSLatitude.Size = new System.Drawing.Size(73, 13);
            this.GPSLatitude.TabIndex = 57;
            this.GPSLatitude.Text = "-";
            this.GPSLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WhereDistance
            // 
            this.WhereDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WhereDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereDistance.Location = new System.Drawing.Point(234, 19);
            this.WhereDistance.Name = "WhereDistance";
            this.WhereDistance.ReadOnly = true;
            this.WhereDistance.Size = new System.Drawing.Size(50, 15);
            this.WhereDistance.TabIndex = 165;
            this.WhereDistance.Text = "-";
            this.WhereDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WhereBearingLabel
            // 
            this.WhereBearingLabel.AutoSize = true;
            this.WhereBearingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereBearingLabel.Location = new System.Drawing.Point(8, 18);
            this.WhereBearingLabel.Name = "WhereBearingLabel";
            this.WhereBearingLabel.Size = new System.Drawing.Size(61, 16);
            this.WhereBearingLabel.TabIndex = 54;
            this.WhereBearingLabel.Text = "Azimuth";
            // 
            // WhereBearing
            // 
            this.WhereBearing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WhereBearing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereBearing.Location = new System.Drawing.Point(76, 18);
            this.WhereBearing.Name = "WhereBearing";
            this.WhereBearing.ReadOnly = true;
            this.WhereBearing.Size = new System.Drawing.Size(35, 15);
            this.WhereBearing.TabIndex = 164;
            this.WhereBearing.Text = "-";
            this.WhereBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WhereDistanceLabel
            // 
            this.WhereDistanceLabel.AutoSize = true;
            this.WhereDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhereDistanceLabel.Location = new System.Drawing.Point(150, 18);
            this.WhereDistanceLabel.Name = "WhereDistanceLabel";
            this.WhereDistanceLabel.Size = new System.Drawing.Size(69, 16);
            this.WhereDistanceLabel.TabIndex = 53;
            this.WhereDistanceLabel.Text = "Distance";
            // 
            // AltitudeGroupBox
            // 
            this.AltitudeGroupBox.Controls.Add(this.label11);
            this.AltitudeGroupBox.Controls.Add(this.label4);
            this.AltitudeGroupBox.Controls.Add(this.BaroPressure);
            this.AltitudeGroupBox.Controls.Add(this.BaroTemperature);
            this.AltitudeGroupBox.Controls.Add(this.RangefinderAltitude);
            this.AltitudeGroupBox.Controls.Add(this.GPSAltitude);
            this.AltitudeGroupBox.Controls.Add(this.BaroAltitude);
            this.AltitudeGroupBox.Controls.Add(this.GPSAltLabel);
            this.AltitudeGroupBox.Controls.Add(this.BaroAltitudeLabel);
            this.AltitudeGroupBox.Controls.Add(this.RangefinderAltLabel);
            this.AltitudeGroupBox.Location = new System.Drawing.Point(12, 277);
            this.AltitudeGroupBox.Name = "AltitudeGroupBox";
            this.AltitudeGroupBox.Size = new System.Drawing.Size(160, 108);
            this.AltitudeGroupBox.TabIndex = 102;
            this.AltitudeGroupBox.TabStop = false;
            this.AltitudeGroupBox.Text = "Altitude";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "P(mB)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "T(C)";
            // 
            // BaroPressure
            // 
            this.BaroPressure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaroPressure.Location = new System.Drawing.Point(114, 15);
            this.BaroPressure.Name = "BaroPressure";
            this.BaroPressure.ReadOnly = true;
            this.BaroPressure.Size = new System.Drawing.Size(39, 13);
            this.BaroPressure.TabIndex = 76;
            this.BaroPressure.Text = "-";
            this.BaroPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BaroTemperature
            // 
            this.BaroTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaroTemperature.Location = new System.Drawing.Point(112, 36);
            this.BaroTemperature.Name = "BaroTemperature";
            this.BaroTemperature.ReadOnly = true;
            this.BaroTemperature.Size = new System.Drawing.Size(41, 13);
            this.BaroTemperature.TabIndex = 77;
            this.BaroTemperature.Text = "-";
            this.BaroTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WayHeadingLabel
            // 
            this.WayHeadingLabel.AutoSize = true;
            this.WayHeadingLabel.Location = new System.Drawing.Point(6, 60);
            this.WayHeadingLabel.Name = "WayHeadingLabel";
            this.WayHeadingLabel.Size = new System.Drawing.Size(69, 13);
            this.WayHeadingLabel.TabIndex = 64;
            this.WayHeadingLabel.Text = "Course (Deg)";
            // 
            // CurrWPLabel
            // 
            this.CurrWPLabel.AutoSize = true;
            this.CurrWPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrWPLabel.Location = new System.Drawing.Point(6, 43);
            this.CurrWPLabel.Name = "CurrWPLabel";
            this.CurrWPLabel.Size = new System.Drawing.Size(35, 13);
            this.CurrWPLabel.TabIndex = 73;
            this.CurrWPLabel.Text = "WP#";
            // 
            // NavState
            // 
            this.NavState.Location = new System.Drawing.Point(89, 28);
            this.NavState.Name = "NavState";
            this.NavState.ReadOnly = true;
            this.NavState.Size = new System.Drawing.Size(76, 20);
            this.NavState.TabIndex = 52;
            this.NavState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrWP
            // 
            this.CurrWP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrWP.Location = new System.Drawing.Point(94, 42);
            this.CurrWP.Name = "CurrWP";
            this.CurrWP.ReadOnly = true;
            this.CurrWP.Size = new System.Drawing.Size(37, 13);
            this.CurrWP.TabIndex = 50;
            this.CurrWP.Text = "-";
            this.CurrWP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WayHeading
            // 
            this.WayHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WayHeading.Location = new System.Drawing.Point(94, 61);
            this.WayHeading.Name = "WayHeading";
            this.WayHeading.ReadOnly = true;
            this.WayHeading.Size = new System.Drawing.Size(37, 13);
            this.WayHeading.TabIndex = 48;
            this.WayHeading.Text = "-";
            this.WayHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AltitudeErrorLabel
            // 
            this.AltitudeErrorLabel.AutoSize = true;
            this.AltitudeErrorLabel.Location = new System.Drawing.Point(6, 135);
            this.AltitudeErrorLabel.Name = "AltitudeErrorLabel";
            this.AltitudeErrorLabel.Size = new System.Drawing.Size(47, 13);
            this.AltitudeErrorLabel.TabIndex = 77;
            this.AltitudeErrorLabel.Text = "Alt. Error";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(6, 80);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(76, 13);
            this.HeadingLabel.TabIndex = 41;
            this.HeadingLabel.Text = "Heading (Deg)";
            // 
            // DesiredAltitude
            // 
            this.DesiredAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DesiredAltitude.Location = new System.Drawing.Point(94, 99);
            this.DesiredAltitude.Name = "DesiredAltitude";
            this.DesiredAltitude.ReadOnly = true;
            this.DesiredAltitude.Size = new System.Drawing.Size(37, 13);
            this.DesiredAltitude.TabIndex = 76;
            this.DesiredAltitude.Text = "-";
            this.DesiredAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Heading
            // 
            this.Heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Heading.Location = new System.Drawing.Point(94, 80);
            this.Heading.Name = "Heading";
            this.Heading.ReadOnly = true;
            this.Heading.Size = new System.Drawing.Size(37, 13);
            this.Heading.TabIndex = 7;
            this.Heading.Text = "-";
            this.Heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WPDistanceLabel
            // 
            this.WPDistanceLabel.AutoSize = true;
            this.WPDistanceLabel.Location = new System.Drawing.Point(6, 117);
            this.WPDistanceLabel.Name = "WPDistanceLabel";
            this.WPDistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.WPDistanceLabel.TabIndex = 75;
            this.WPDistanceLabel.Text = "Distance";
            // 
            // DistanceToDesired
            // 
            this.DistanceToDesired.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DistanceToDesired.Location = new System.Drawing.Point(94, 117);
            this.DistanceToDesired.Name = "DistanceToDesired";
            this.DistanceToDesired.ReadOnly = true;
            this.DistanceToDesired.Size = new System.Drawing.Size(37, 13);
            this.DistanceToDesired.TabIndex = 74;
            this.DistanceToDesired.Text = "-";
            this.DistanceToDesired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavGroupBox
            // 
            this.NavGroupBox.Controls.Add(this.DesiredAltitudeLabel);
            this.NavGroupBox.Controls.Add(this.AltitudeError);
            this.NavGroupBox.Controls.Add(this.CrossTrackErrorLabel);
            this.NavGroupBox.Controls.Add(this.CrossTrackError);
            this.NavGroupBox.Controls.Add(this.NavStateTimeoutLabel);
            this.NavGroupBox.Controls.Add(this.NavStateTimeout);
            this.NavGroupBox.Controls.Add(this.DistanceToDesired);
            this.NavGroupBox.Controls.Add(this.WayHeadingLabel);
            this.NavGroupBox.Controls.Add(this.WPDistanceLabel);
            this.NavGroupBox.Controls.Add(this.Heading);
            this.NavGroupBox.Controls.Add(this.DesiredAltitude);
            this.NavGroupBox.Controls.Add(this.CurrWPLabel);
            this.NavGroupBox.Controls.Add(this.CurrWP);
            this.NavGroupBox.Controls.Add(this.HeadingLabel);
            this.NavGroupBox.Controls.Add(this.WayHeading);
            this.NavGroupBox.Controls.Add(this.AltitudeErrorLabel);
            this.NavGroupBox.Location = new System.Drawing.Point(178, 102);
            this.NavGroupBox.Name = "NavGroupBox";
            this.NavGroupBox.Size = new System.Drawing.Size(139, 172);
            this.NavGroupBox.TabIndex = 91;
            this.NavGroupBox.TabStop = false;
            this.NavGroupBox.Text = "Nav";
            // 
            // DesiredAltitudeLabel
            // 
            this.DesiredAltitudeLabel.AutoSize = true;
            this.DesiredAltitudeLabel.Location = new System.Drawing.Point(6, 100);
            this.DesiredAltitudeLabel.Name = "DesiredAltitudeLabel";
            this.DesiredAltitudeLabel.Size = new System.Drawing.Size(61, 13);
            this.DesiredAltitudeLabel.TabIndex = 159;
            this.DesiredAltitudeLabel.Text = "Desired Alt.";
            // 
            // AltitudeError
            // 
            this.AltitudeError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AltitudeError.Location = new System.Drawing.Point(94, 134);
            this.AltitudeError.Name = "AltitudeError";
            this.AltitudeError.ReadOnly = true;
            this.AltitudeError.Size = new System.Drawing.Size(37, 13);
            this.AltitudeError.TabIndex = 158;
            this.AltitudeError.Text = "-";
            this.AltitudeError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CrossTrackErrorLabel
            // 
            this.CrossTrackErrorLabel.AutoSize = true;
            this.CrossTrackErrorLabel.Location = new System.Drawing.Point(6, 152);
            this.CrossTrackErrorLabel.Name = "CrossTrackErrorLabel";
            this.CrossTrackErrorLabel.Size = new System.Drawing.Size(69, 13);
            this.CrossTrackErrorLabel.TabIndex = 157;
            this.CrossTrackErrorLabel.Text = "Track Err.(M)";
            // 
            // CrossTrackError
            // 
            this.CrossTrackError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CrossTrackError.Location = new System.Drawing.Point(94, 150);
            this.CrossTrackError.Name = "CrossTrackError";
            this.CrossTrackError.ReadOnly = true;
            this.CrossTrackError.Size = new System.Drawing.Size(37, 13);
            this.CrossTrackError.TabIndex = 156;
            this.CrossTrackError.Text = "-";
            this.CrossTrackError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavStateTimeoutLabel
            // 
            this.NavStateTimeoutLabel.AutoSize = true;
            this.NavStateTimeoutLabel.Location = new System.Drawing.Point(6, 19);
            this.NavStateTimeoutLabel.Name = "NavStateTimeoutLabel";
            this.NavStateTimeoutLabel.Size = new System.Drawing.Size(60, 13);
            this.NavStateTimeoutLabel.TabIndex = 153;
            this.NavStateTimeoutLabel.Text = "Delay Time";
            // 
            // NavStateTimeout
            // 
            this.NavStateTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NavStateTimeout.Location = new System.Drawing.Point(94, 18);
            this.NavStateTimeout.Name = "NavStateTimeout";
            this.NavStateTimeout.ReadOnly = true;
            this.NavStateTimeout.Size = new System.Drawing.Size(37, 13);
            this.NavStateTimeout.TabIndex = 153;
            this.NavStateTimeout.Text = "-";
            this.NavStateTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurrentAltitude
            // 
            this.CurrentAltitude.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAltitude.Location = new System.Drawing.Point(382, 57);
            this.CurrentAltitude.Name = "CurrentAltitude";
            this.CurrentAltitude.Size = new System.Drawing.Size(141, 46);
            this.CurrentAltitude.TabIndex = 103;
            this.CurrentAltitude.Text = "-1";
            this.CurrentAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainLabel
            // 
            this.MainLabel.Location = new System.Drawing.Point(336, 378);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(233, 21);
            this.MainLabel.TabIndex = 104;
            this.MainLabel.Text = "UAVX Firmware Revision Unknown";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AltitudeSource
            // 
            this.AltitudeSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AltitudeSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltitudeSource.Location = new System.Drawing.Point(392, 47);
            this.AltitudeSource.Name = "AltitudeSource";
            this.AltitudeSource.ReadOnly = true;
            this.AltitudeSource.Size = new System.Drawing.Size(121, 13);
            this.AltitudeSource.TabIndex = 107;
            this.AltitudeSource.Text = "Barometer";
            this.AltitudeSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NavSensitivity);
            this.groupBox1.Controls.Add(this.NavSensitivityLabel);
            this.groupBox1.Controls.Add(this.CruiseThrottle);
            this.groupBox1.Controls.Add(this.CruiseThrottleLabel);
            this.groupBox1.Controls.Add(this.NavYCorr);
            this.groupBox1.Controls.Add(this.BattFFLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NavPCorr);
            this.groupBox1.Controls.Add(this.NavRCorr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BattFFComp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AltComp);
            this.groupBox1.Controls.Add(this.TiltFFComp);
            this.groupBox1.Controls.Add(this.TiltFFCompLabel);
            this.groupBox1.Controls.Add(this.AltCompLabel);
            this.groupBox1.Location = new System.Drawing.Point(11, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 54);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compensation";
            // 
            // NavSensitivity
            // 
            this.NavSensitivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NavSensitivity.Location = new System.Drawing.Point(47, 33);
            this.NavSensitivity.Name = "NavSensitivity";
            this.NavSensitivity.ReadOnly = true;
            this.NavSensitivity.Size = new System.Drawing.Size(25, 13);
            this.NavSensitivity.TabIndex = 59;
            this.NavSensitivity.Text = "-";
            this.NavSensitivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavSensitivityLabel
            // 
            this.NavSensitivityLabel.AutoSize = true;
            this.NavSensitivityLabel.Location = new System.Drawing.Point(6, 33);
            this.NavSensitivityLabel.Name = "NavSensitivityLabel";
            this.NavSensitivityLabel.Size = new System.Drawing.Size(34, 13);
            this.NavSensitivityLabel.TabIndex = 65;
            this.NavSensitivityLabel.Text = "Sens.";
            // 
            // CruiseThrottle
            // 
            this.CruiseThrottle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CruiseThrottle.Location = new System.Drawing.Point(189, 13);
            this.CruiseThrottle.Name = "CruiseThrottle";
            this.CruiseThrottle.ReadOnly = true;
            this.CruiseThrottle.Size = new System.Drawing.Size(30, 13);
            this.CruiseThrottle.TabIndex = 221;
            this.CruiseThrottle.Text = "-";
            this.CruiseThrottle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CruiseThrottleLabel
            // 
            this.CruiseThrottleLabel.AutoSize = true;
            this.CruiseThrottleLabel.Location = new System.Drawing.Point(149, 13);
            this.CruiseThrottleLabel.Name = "CruiseThrottleLabel";
            this.CruiseThrottleLabel.Size = new System.Drawing.Size(38, 13);
            this.CruiseThrottleLabel.TabIndex = 222;
            this.CruiseThrottleLabel.Text = "Hvr(%)";
            // 
            // NavYCorr
            // 
            this.NavYCorr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NavYCorr.Location = new System.Drawing.Point(269, 33);
            this.NavYCorr.Name = "NavYCorr";
            this.NavYCorr.ReadOnly = true;
            this.NavYCorr.Size = new System.Drawing.Size(30, 13);
            this.NavYCorr.TabIndex = 43;
            this.NavYCorr.Text = "-";
            this.NavYCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BattFFLabel
            // 
            this.BattFFLabel.AutoSize = true;
            this.BattFFLabel.Location = new System.Drawing.Point(78, 13);
            this.BattFFLabel.Name = "BattFFLabel";
            this.BattFFLabel.Size = new System.Drawing.Size(28, 13);
            this.BattFFLabel.TabIndex = 220;
            this.BattFFLabel.Text = "xBat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Yaw";
            // 
            // NavPCorr
            // 
            this.NavPCorr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NavPCorr.Location = new System.Drawing.Point(189, 33);
            this.NavPCorr.Name = "NavPCorr";
            this.NavPCorr.ReadOnly = true;
            this.NavPCorr.Size = new System.Drawing.Size(30, 13);
            this.NavPCorr.TabIndex = 46;
            this.NavPCorr.Text = "-";
            this.NavPCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavRCorr
            // 
            this.NavRCorr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NavRCorr.Location = new System.Drawing.Point(104, 33);
            this.NavRCorr.Name = "NavRCorr";
            this.NavRCorr.ReadOnly = true;
            this.NavRCorr.Size = new System.Drawing.Size(30, 13);
            this.NavRCorr.TabIndex = 58;
            this.NavRCorr.Text = "-";
            this.NavRCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Pitch";
            // 
            // BattFFComp
            // 
            this.BattFFComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BattFFComp.Location = new System.Drawing.Point(104, 13);
            this.BattFFComp.Name = "BattFFComp";
            this.BattFFComp.ReadOnly = true;
            this.BattFFComp.Size = new System.Drawing.Size(30, 13);
            this.BattFFComp.TabIndex = 78;
            this.BattFFComp.Text = "-";
            this.BattFFComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Roll";
            // 
            // AltComp
            // 
            this.AltComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AltComp.Location = new System.Drawing.Point(269, 13);
            this.AltComp.Name = "AltComp";
            this.AltComp.ReadOnly = true;
            this.AltComp.Size = new System.Drawing.Size(30, 13);
            this.AltComp.TabIndex = 43;
            this.AltComp.Text = "-";
            this.AltComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TiltFFComp
            // 
            this.TiltFFComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TiltFFComp.Location = new System.Drawing.Point(42, 13);
            this.TiltFFComp.Name = "TiltFFComp";
            this.TiltFFComp.ReadOnly = true;
            this.TiltFFComp.Size = new System.Drawing.Size(30, 13);
            this.TiltFFComp.TabIndex = 46;
            this.TiltFFComp.Text = "-";
            this.TiltFFComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TiltFFCompLabel
            // 
            this.TiltFFCompLabel.AutoSize = true;
            this.TiltFFCompLabel.Location = new System.Drawing.Point(8, 13);
            this.TiltFFCompLabel.Name = "TiltFFCompLabel";
            this.TiltFFCompLabel.Size = new System.Drawing.Size(26, 13);
            this.TiltFFCompLabel.TabIndex = 75;
            this.TiltFFCompLabel.Text = "xTilt";
            // 
            // AltCompLabel
            // 
            this.AltCompLabel.AutoSize = true;
            this.AltCompLabel.Location = new System.Drawing.Point(230, 13);
            this.AltCompLabel.Name = "AltCompLabel";
            this.AltCompLabel.Size = new System.Drawing.Size(36, 13);
            this.AltCompLabel.TabIndex = 67;
            this.AltCompLabel.Text = "Alt (%)";
            // 
            // EmulationTextBox
            // 
            this.EmulationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmulationTextBox.Location = new System.Drawing.Point(389, 28);
            this.EmulationTextBox.Name = "EmulationTextBox";
            this.EmulationTextBox.ReadOnly = true;
            this.EmulationTextBox.Size = new System.Drawing.Size(121, 13);
            this.EmulationTextBox.TabIndex = 154;
            this.EmulationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenLogFileDialog
            // 
            this.OpenLogFileDialog.FileName = "UAVX.log";
            // 
            // COMSelectComboBox
            // 
            this.COMSelectComboBox.Name = "COMSelectComboBox";
            this.COMSelectComboBox.Size = new System.Drawing.Size(75, 23);
            this.COMSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.COMSelectComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COMSelectComboBox,
            this.COMBaudRateComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 27);
            this.menuStrip1.TabIndex = 153;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // COMBaudRateComboBox
            // 
            this.COMBaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.COMBaudRateComboBox.Name = "COMBaudRateComboBox";
            this.COMBaudRateComboBox.Size = new System.Drawing.Size(75, 23);
            this.COMBaudRateComboBox.Text = "115200";
            this.COMBaudRateComboBox.SelectedIndexChanged += new System.EventHandler(this.COMBaudRateComboBox_SelectedIndexChanged);
            // 
            // ReplayButton
            // 
            this.ReplayButton.Location = new System.Drawing.Point(731, 1);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(75, 23);
            this.ReplayButton.TabIndex = 164;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // ReplayProgressBar
            // 
            this.ReplayProgressBar.Location = new System.Drawing.Point(898, 1);
            this.ReplayProgressBar.Name = "ReplayProgressBar";
            this.ReplayProgressBar.Size = new System.Drawing.Size(54, 23);
            this.ReplayProgressBar.TabIndex = 165;
            // 
            // Airframe
            // 
            this.Airframe.BackColor = System.Drawing.SystemColors.Control;
            this.Airframe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Airframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airframe.Location = new System.Drawing.Point(382, 99);
            this.Airframe.Name = "Airframe";
            this.Airframe.Size = new System.Drawing.Size(141, 13);
            this.Airframe.TabIndex = 166;
            this.Airframe.Text = "UNKNOWN";
            this.Airframe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReplayNumericUpDown
            // 
            this.ReplayNumericUpDown.Location = new System.Drawing.Point(958, 2);
            this.ReplayNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ReplayNumericUpDown.Name = "ReplayNumericUpDown";
            this.ReplayNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.ReplayNumericUpDown.TabIndex = 167;
            this.ReplayNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReplayNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ReplayNumericUpDown.Visible = false;
            this.ReplayNumericUpDown.ValueChanged += new System.EventHandler(this.ReplayNumericUpDown_Changed);
            // 
            // SpeechGroupBox
            // 
            this.SpeechGroupBox.Controls.Add(this.SpeakVarioCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakIntervalLabel);
            this.SpeechGroupBox.Controls.Add(this.SpeakIntervalNumericUpDown);
            this.SpeechGroupBox.Controls.Add(this.SpeechEnableCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakNavCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakAltitudeCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakWhereCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakVoltsCheckBox);
            this.SpeechGroupBox.Location = new System.Drawing.Point(842, 107);
            this.SpeechGroupBox.Name = "SpeechGroupBox";
            this.SpeechGroupBox.Size = new System.Drawing.Size(162, 80);
            this.SpeechGroupBox.TabIndex = 183;
            this.SpeechGroupBox.TabStop = false;
            this.SpeechGroupBox.Text = "Speech";
            // 
            // SpeakVarioCheckBox
            // 
            this.SpeakVarioCheckBox.AutoSize = true;
            this.SpeakVarioCheckBox.Location = new System.Drawing.Point(86, 33);
            this.SpeakVarioCheckBox.Name = "SpeakVarioCheckBox";
            this.SpeakVarioCheckBox.Size = new System.Drawing.Size(50, 17);
            this.SpeakVarioCheckBox.TabIndex = 190;
            this.SpeakVarioCheckBox.Text = "Vario";
            this.SpeakVarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakIntervalLabel
            // 
            this.SpeakIntervalLabel.AutoSize = true;
            this.SpeakIntervalLabel.Location = new System.Drawing.Point(6, 17);
            this.SpeakIntervalLabel.Name = "SpeakIntervalLabel";
            this.SpeakIntervalLabel.Size = new System.Drawing.Size(42, 13);
            this.SpeakIntervalLabel.TabIndex = 189;
            this.SpeakIntervalLabel.Text = "Interval";
            // 
            // SpeakIntervalNumericUpDown
            // 
            this.SpeakIntervalNumericUpDown.Location = new System.Drawing.Point(86, 10);
            this.SpeakIntervalNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.SpeakIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeakIntervalNumericUpDown.Name = "SpeakIntervalNumericUpDown";
            this.SpeakIntervalNumericUpDown.ReadOnly = true;
            this.SpeakIntervalNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.SpeakIntervalNumericUpDown.TabIndex = 188;
            this.SpeakIntervalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpeakIntervalNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SpeakIntervalNumericUpDown.Click += new System.EventHandler(this.SpeakIntervalNumericUpDown_Click);
            // 
            // SpeechEnableCheckBox
            // 
            this.SpeechEnableCheckBox.AutoSize = true;
            this.SpeechEnableCheckBox.Checked = true;
            this.SpeechEnableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeechEnableCheckBox.Location = new System.Drawing.Point(11, 33);
            this.SpeechEnableCheckBox.Name = "SpeechEnableCheckBox";
            this.SpeechEnableCheckBox.Size = new System.Drawing.Size(59, 17);
            this.SpeechEnableCheckBox.TabIndex = 181;
            this.SpeechEnableCheckBox.Text = "Enable";
            this.SpeechEnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakNavCheckBox
            // 
            this.SpeakNavCheckBox.AutoSize = true;
            this.SpeakNavCheckBox.Checked = true;
            this.SpeakNavCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeakNavCheckBox.Location = new System.Drawing.Point(11, 46);
            this.SpeakNavCheckBox.Name = "SpeakNavCheckBox";
            this.SpeakNavCheckBox.Size = new System.Drawing.Size(49, 17);
            this.SpeakNavCheckBox.TabIndex = 187;
            this.SpeakNavCheckBox.Text = "Nav.";
            this.SpeakNavCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakAltitudeCheckBox
            // 
            this.SpeakAltitudeCheckBox.AutoSize = true;
            this.SpeakAltitudeCheckBox.Location = new System.Drawing.Point(86, 46);
            this.SpeakAltitudeCheckBox.Name = "SpeakAltitudeCheckBox";
            this.SpeakAltitudeCheckBox.Size = new System.Drawing.Size(41, 17);
            this.SpeakAltitudeCheckBox.TabIndex = 184;
            this.SpeakAltitudeCheckBox.Text = "Alt.";
            this.SpeakAltitudeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakWhereCheckBox
            // 
            this.SpeakWhereCheckBox.AutoSize = true;
            this.SpeakWhereCheckBox.Location = new System.Drawing.Point(86, 59);
            this.SpeakWhereCheckBox.Name = "SpeakWhereCheckBox";
            this.SpeakWhereCheckBox.Size = new System.Drawing.Size(58, 17);
            this.SpeakWhereCheckBox.TabIndex = 186;
            this.SpeakWhereCheckBox.Text = "Where";
            this.SpeakWhereCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakVoltsCheckBox
            // 
            this.SpeakVoltsCheckBox.AutoSize = true;
            this.SpeakVoltsCheckBox.Checked = true;
            this.SpeakVoltsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeakVoltsCheckBox.Location = new System.Drawing.Point(11, 59);
            this.SpeakVoltsCheckBox.Name = "SpeakVoltsCheckBox";
            this.SpeakVoltsCheckBox.Size = new System.Drawing.Size(49, 17);
            this.SpeakVoltsCheckBox.TabIndex = 185;
            this.SpeakVoltsCheckBox.Text = "Volts";
            this.SpeakVoltsCheckBox.UseVisualStyleBackColor = true;
            // 
            // timer_announce
            // 
            this.timer_announce.Enabled = true;
            this.timer_announce.Interval = 20000;
            this.timer_announce.Tick += new System.EventHandler(this.timer_announce_Tick);
            // 
            // timer_telemetry
            // 
            this.timer_telemetry.Enabled = true;
            this.timer_telemetry.Interval = 5000;
            this.timer_telemetry.Tick += new System.EventHandler(this.timer_telemetry_Tick);
            // 
            // StartNavigationButton
            // 
            this.StartNavigationButton.BackColor = System.Drawing.Color.Green;
            this.StartNavigationButton.Location = new System.Drawing.Point(851, 76);
            this.StartNavigationButton.Name = "StartNavigationButton";
            this.StartNavigationButton.Size = new System.Drawing.Size(67, 23);
            this.StartNavigationButton.TabIndex = 184;
            this.StartNavigationButton.Text = "Navigation";
            this.StartNavigationButton.UseVisualStyleBackColor = false;
            this.StartNavigationButton.Click += new System.EventHandler(this.StartNavigationButton_Click);
            // 
            // StartParametersButton
            // 
            this.StartParametersButton.BackColor = System.Drawing.Color.Green;
            this.StartParametersButton.Location = new System.Drawing.Point(924, 76);
            this.StartParametersButton.Name = "StartParametersButton";
            this.StartParametersButton.Size = new System.Drawing.Size(67, 23);
            this.StartParametersButton.TabIndex = 185;
            this.StartParametersButton.Text = "Parameters";
            this.StartParametersButton.UseVisualStyleBackColor = false;
            this.StartParametersButton.Click += new System.EventHandler(this.StartParametersButton_Click);
            // 
            // CalibrateIMUButton
            // 
            this.CalibrateIMUButton.Location = new System.Drawing.Point(849, 416);
            this.CalibrateIMUButton.Name = "CalibrateIMUButton";
            this.CalibrateIMUButton.Size = new System.Drawing.Size(69, 23);
            this.CalibrateIMUButton.TabIndex = 199;
            this.CalibrateIMUButton.Text = "IMU";
            this.CalibrateIMUButton.UseVisualStyleBackColor = true;
            this.CalibrateIMUButton.Click += new System.EventHandler(this.CalibrateIMUButton_Click);
            // 
            // CalibrateMagButton
            // 
            this.CalibrateMagButton.Location = new System.Drawing.Point(849, 444);
            this.CalibrateMagButton.Name = "CalibrateMagButton";
            this.CalibrateMagButton.Size = new System.Drawing.Size(69, 23);
            this.CalibrateMagButton.TabIndex = 201;
            this.CalibrateMagButton.Text = "Mag";
            this.CalibrateMagButton.UseVisualStyleBackColor = true;
            this.CalibrateMagButton.Click += new System.EventHandler(this.CalibrateMagButton_Click);
            // 
            // DrivesGroupBox
            // 
            this.DrivesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.DrivesGroupBox.Controls.Add(this.PWM1Label);
            this.DrivesGroupBox.Controls.Add(this.PWM2Label);
            this.DrivesGroupBox.Controls.Add(this.PWM3Label);
            this.DrivesGroupBox.Controls.Add(this.PWM4Label);
            this.DrivesGroupBox.Controls.Add(this.PWM5Label);
            this.DrivesGroupBox.Controls.Add(this.PWM6Label);
            this.DrivesGroupBox.Controls.Add(this.PWM7Label);
            this.DrivesGroupBox.Controls.Add(this.PWM0Label);
            this.DrivesGroupBox.Controls.Add(this.PWM8Label);
            this.DrivesGroupBox.Controls.Add(this.ImbalanceLabel);
            this.DrivesGroupBox.Controls.Add(this.DiagnosticCheckBox);
            this.DrivesGroupBox.Controls.Add(this.PWM9Label);
            this.DrivesGroupBox.Controls.Add(this.PWMT7);
            this.DrivesGroupBox.Controls.Add(this.PWMT6);
            this.DrivesGroupBox.Controls.Add(this.PWMT5);
            this.DrivesGroupBox.Controls.Add(this.PWMT4);
            this.DrivesGroupBox.Controls.Add(this.PWMT9);
            this.DrivesGroupBox.Controls.Add(this.PWMT3);
            this.DrivesGroupBox.Controls.Add(this.PWMT2);
            this.DrivesGroupBox.Controls.Add(this.PWMT1);
            this.DrivesGroupBox.Controls.Add(this.PWMT0);
            this.DrivesGroupBox.Controls.Add(this.PWMT8);
            this.DrivesGroupBox.Controls.Add(this.PWMT0ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT6ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT1ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT5ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT2ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT7ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT4ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT3ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT8ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT9ProgressBar);
            this.DrivesGroupBox.Location = new System.Drawing.Point(843, 189);
            this.DrivesGroupBox.Name = "DrivesGroupBox";
            this.DrivesGroupBox.Size = new System.Drawing.Size(162, 209);
            this.DrivesGroupBox.TabIndex = 210;
            this.DrivesGroupBox.TabStop = false;
            this.DrivesGroupBox.Text = "Motors/Servos (%)";
            // 
            // PWM1Label
            // 
            this.PWM1Label.AutoSize = true;
            this.PWM1Label.Location = new System.Drawing.Point(6, 52);
            this.PWM1Label.Name = "PWM1Label";
            this.PWM1Label.Size = new System.Drawing.Size(41, 13);
            this.PWM1Label.TabIndex = 242;
            this.PWM1Label.Text = "L Back";
            // 
            // PWM2Label
            // 
            this.PWM2Label.AutoSize = true;
            this.PWM2Label.Location = new System.Drawing.Point(6, 67);
            this.PWM2Label.Name = "PWM2Label";
            this.PWM2Label.Size = new System.Drawing.Size(42, 13);
            this.PWM2Label.TabIndex = 241;
            this.PWM2Label.Text = "R Front";
            // 
            // PWM3Label
            // 
            this.PWM3Label.AutoSize = true;
            this.PWM3Label.Location = new System.Drawing.Point(6, 82);
            this.PWM3Label.Name = "PWM3Label";
            this.PWM3Label.Size = new System.Drawing.Size(43, 13);
            this.PWM3Label.TabIndex = 240;
            this.PWM3Label.Text = "R Back";
            // 
            // PWM4Label
            // 
            this.PWM4Label.AutoSize = true;
            this.PWM4Label.Location = new System.Drawing.Point(6, 127);
            this.PWM4Label.Name = "PWM4Label";
            this.PWM4Label.Size = new System.Drawing.Size(0, 13);
            this.PWM4Label.TabIndex = 239;
            // 
            // PWM5Label
            // 
            this.PWM5Label.AutoSize = true;
            this.PWM5Label.Location = new System.Drawing.Point(6, 144);
            this.PWM5Label.Name = "PWM5Label";
            this.PWM5Label.Size = new System.Drawing.Size(0, 13);
            this.PWM5Label.TabIndex = 238;
            // 
            // PWM6Label
            // 
            this.PWM6Label.AutoSize = true;
            this.PWM6Label.Location = new System.Drawing.Point(6, 157);
            this.PWM6Label.Name = "PWM6Label";
            this.PWM6Label.Size = new System.Drawing.Size(0, 13);
            this.PWM6Label.TabIndex = 237;
            // 
            // PWM7Label
            // 
            this.PWM7Label.AutoSize = true;
            this.PWM7Label.Location = new System.Drawing.Point(6, 172);
            this.PWM7Label.Name = "PWM7Label";
            this.PWM7Label.Size = new System.Drawing.Size(31, 13);
            this.PWM7Label.TabIndex = 236;
            this.PWM7Label.Text = "Aux2";
            // 
            // PWM0Label
            // 
            this.PWM0Label.AutoSize = true;
            this.PWM0Label.Location = new System.Drawing.Point(6, 37);
            this.PWM0Label.Name = "PWM0Label";
            this.PWM0Label.Size = new System.Drawing.Size(40, 13);
            this.PWM0Label.TabIndex = 235;
            this.PWM0Label.Text = "L Front";
            // 
            // PWM8Label
            // 
            this.PWM8Label.AutoSize = true;
            this.PWM8Label.Location = new System.Drawing.Point(6, 98);
            this.PWM8Label.Name = "PWM8Label";
            this.PWM8Label.Size = new System.Drawing.Size(49, 13);
            this.PWM8Label.TabIndex = 234;
            this.PWM8Label.Text = "Cam Roll";
            // 
            // ImbalanceLabel
            // 
            this.ImbalanceLabel.AutoSize = true;
            this.ImbalanceLabel.Location = new System.Drawing.Point(52, 17);
            this.ImbalanceLabel.Name = "ImbalanceLabel";
            this.ImbalanceLabel.Size = new System.Drawing.Size(84, 13);
            this.ImbalanceLabel.TabIndex = 228;
            this.ImbalanceLabel.Text = "Drive Imbalance";
            // 
            // DiagnosticCheckBox
            // 
            this.DiagnosticCheckBox.AutoSize = true;
            this.DiagnosticCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DiagnosticCheckBox.Location = new System.Drawing.Point(141, 17);
            this.DiagnosticCheckBox.Name = "DiagnosticCheckBox";
            this.DiagnosticCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DiagnosticCheckBox.TabIndex = 226;
            this.DiagnosticCheckBox.UseVisualStyleBackColor = true;
            // 
            // PWM9Label
            // 
            this.PWM9Label.AutoSize = true;
            this.PWM9Label.Location = new System.Drawing.Point(6, 113);
            this.PWM9Label.Name = "PWM9Label";
            this.PWM9Label.Size = new System.Drawing.Size(55, 13);
            this.PWM9Label.TabIndex = 233;
            this.PWM9Label.Text = "Cam Pitch";
            // 
            // PWMT7
            // 
            this.PWMT7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT7.Location = new System.Drawing.Point(62, 171);
            this.PWMT7.Name = "PWMT7";
            this.PWMT7.ReadOnly = true;
            this.PWMT7.Size = new System.Drawing.Size(25, 13);
            this.PWMT7.TabIndex = 205;
            this.PWMT7.Text = "0";
            this.PWMT7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT6
            // 
            this.PWMT6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT6.Location = new System.Drawing.Point(62, 157);
            this.PWMT6.Name = "PWMT6";
            this.PWMT6.ReadOnly = true;
            this.PWMT6.Size = new System.Drawing.Size(25, 13);
            this.PWMT6.TabIndex = 204;
            this.PWMT6.Text = "0";
            this.PWMT6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT5
            // 
            this.PWMT5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT5.Location = new System.Drawing.Point(62, 142);
            this.PWMT5.Name = "PWMT5";
            this.PWMT5.ReadOnly = true;
            this.PWMT5.Size = new System.Drawing.Size(25, 13);
            this.PWMT5.TabIndex = 203;
            this.PWMT5.Text = "0";
            this.PWMT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT4
            // 
            this.PWMT4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT4.Location = new System.Drawing.Point(62, 127);
            this.PWMT4.Name = "PWMT4";
            this.PWMT4.ReadOnly = true;
            this.PWMT4.Size = new System.Drawing.Size(25, 13);
            this.PWMT4.TabIndex = 202;
            this.PWMT4.Text = "0";
            this.PWMT4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT9
            // 
            this.PWMT9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT9.Location = new System.Drawing.Point(62, 113);
            this.PWMT9.Name = "PWMT9";
            this.PWMT9.ReadOnly = true;
            this.PWMT9.Size = new System.Drawing.Size(25, 13);
            this.PWMT9.TabIndex = 207;
            this.PWMT9.Text = "0";
            this.PWMT9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT3
            // 
            this.PWMT3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT3.Location = new System.Drawing.Point(61, 82);
            this.PWMT3.Name = "PWMT3";
            this.PWMT3.ReadOnly = true;
            this.PWMT3.Size = new System.Drawing.Size(25, 13);
            this.PWMT3.TabIndex = 201;
            this.PWMT3.Text = "0";
            this.PWMT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT2
            // 
            this.PWMT2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT2.Location = new System.Drawing.Point(61, 67);
            this.PWMT2.Name = "PWMT2";
            this.PWMT2.ReadOnly = true;
            this.PWMT2.Size = new System.Drawing.Size(25, 13);
            this.PWMT2.TabIndex = 200;
            this.PWMT2.Text = "0";
            this.PWMT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT1
            // 
            this.PWMT1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT1.Location = new System.Drawing.Point(61, 52);
            this.PWMT1.Name = "PWMT1";
            this.PWMT1.ReadOnly = true;
            this.PWMT1.Size = new System.Drawing.Size(25, 13);
            this.PWMT1.TabIndex = 199;
            this.PWMT1.Text = "0";
            this.PWMT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT0
            // 
            this.PWMT0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT0.Location = new System.Drawing.Point(61, 37);
            this.PWMT0.Name = "PWMT0";
            this.PWMT0.ReadOnly = true;
            this.PWMT0.Size = new System.Drawing.Size(25, 13);
            this.PWMT0.TabIndex = 198;
            this.PWMT0.Text = "0";
            this.PWMT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT8
            // 
            this.PWMT8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT8.Location = new System.Drawing.Point(62, 98);
            this.PWMT8.Name = "PWMT8";
            this.PWMT8.ReadOnly = true;
            this.PWMT8.Size = new System.Drawing.Size(25, 13);
            this.PWMT8.TabIndex = 206;
            this.PWMT8.Text = "0";
            this.PWMT8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT0ProgressBar
            // 
            this.PWMT0ProgressBar.Location = new System.Drawing.Point(91, 37);
            this.PWMT0ProgressBar.Maximum = 1000;
            this.PWMT0ProgressBar.Name = "PWMT0ProgressBar";
            this.PWMT0ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT0ProgressBar.Step = 1;
            this.PWMT0ProgressBar.TabIndex = 191;
            // 
            // PWMT6ProgressBar
            // 
            this.PWMT6ProgressBar.Location = new System.Drawing.Point(91, 157);
            this.PWMT6ProgressBar.Maximum = 1000;
            this.PWMT6ProgressBar.Name = "PWMT6ProgressBar";
            this.PWMT6ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT6ProgressBar.Step = 1;
            this.PWMT6ProgressBar.TabIndex = 197;
            // 
            // PWMT1ProgressBar
            // 
            this.PWMT1ProgressBar.Location = new System.Drawing.Point(91, 52);
            this.PWMT1ProgressBar.Maximum = 1000;
            this.PWMT1ProgressBar.Name = "PWMT1ProgressBar";
            this.PWMT1ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT1ProgressBar.Step = 1;
            this.PWMT1ProgressBar.TabIndex = 192;
            // 
            // PWMT5ProgressBar
            // 
            this.PWMT5ProgressBar.Location = new System.Drawing.Point(91, 142);
            this.PWMT5ProgressBar.Maximum = 1000;
            this.PWMT5ProgressBar.Name = "PWMT5ProgressBar";
            this.PWMT5ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT5ProgressBar.Step = 1;
            this.PWMT5ProgressBar.TabIndex = 196;
            // 
            // PWMT2ProgressBar
            // 
            this.PWMT2ProgressBar.Location = new System.Drawing.Point(91, 67);
            this.PWMT2ProgressBar.Maximum = 1000;
            this.PWMT2ProgressBar.Name = "PWMT2ProgressBar";
            this.PWMT2ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT2ProgressBar.Step = 1;
            this.PWMT2ProgressBar.TabIndex = 193;
            // 
            // PWMT7ProgressBar
            // 
            this.PWMT7ProgressBar.Location = new System.Drawing.Point(91, 172);
            this.PWMT7ProgressBar.Maximum = 1000;
            this.PWMT7ProgressBar.Name = "PWMT7ProgressBar";
            this.PWMT7ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT7ProgressBar.Step = 1;
            this.PWMT7ProgressBar.TabIndex = 186;
            // 
            // PWMT4ProgressBar
            // 
            this.PWMT4ProgressBar.Location = new System.Drawing.Point(91, 127);
            this.PWMT4ProgressBar.Maximum = 1000;
            this.PWMT4ProgressBar.Name = "PWMT4ProgressBar";
            this.PWMT4ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT4ProgressBar.Step = 1;
            this.PWMT4ProgressBar.TabIndex = 195;
            // 
            // PWMT3ProgressBar
            // 
            this.PWMT3ProgressBar.Location = new System.Drawing.Point(91, 82);
            this.PWMT3ProgressBar.Maximum = 1000;
            this.PWMT3ProgressBar.Name = "PWMT3ProgressBar";
            this.PWMT3ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT3ProgressBar.Step = 1;
            this.PWMT3ProgressBar.TabIndex = 194;
            // 
            // PWMT8ProgressBar
            // 
            this.PWMT8ProgressBar.Location = new System.Drawing.Point(91, 98);
            this.PWMT8ProgressBar.Maximum = 1000;
            this.PWMT8ProgressBar.Name = "PWMT8ProgressBar";
            this.PWMT8ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT8ProgressBar.Step = 1;
            this.PWMT8ProgressBar.TabIndex = 187;
            // 
            // PWMT9ProgressBar
            // 
            this.PWMT9ProgressBar.Location = new System.Drawing.Point(91, 114);
            this.PWMT9ProgressBar.Maximum = 1000;
            this.PWMT9ProgressBar.Name = "PWMT9ProgressBar";
            this.PWMT9ProgressBar.Size = new System.Drawing.Size(65, 13);
            this.PWMT9ProgressBar.Step = 1;
            this.PWMT9ProgressBar.TabIndex = 188;
            // 
            // FWRateEnergy
            // 
            this.FWRateEnergy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FWRateEnergy.Location = new System.Drawing.Point(365, 123);
            this.FWRateEnergy.Name = "FWRateEnergy";
            this.FWRateEnergy.ReadOnly = true;
            this.FWRateEnergy.Size = new System.Drawing.Size(45, 13);
            this.FWRateEnergy.TabIndex = 226;
            this.FWRateEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RateEnergyLabel
            // 
            this.RateEnergyLabel.AutoSize = true;
            this.RateEnergyLabel.Location = new System.Drawing.Point(269, 123);
            this.RateEnergyLabel.Name = "RateEnergyLabel";
            this.RateEnergyLabel.Size = new System.Drawing.Size(87, 13);
            this.RateEnergyLabel.TabIndex = 227;
            this.RateEnergyLabel.Text = "Motor Energy (%)";
            // 
            // MissionTimeTextBox
            // 
            this.MissionTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MissionTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissionTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionTimeTextBox.Location = new System.Drawing.Point(857, 24);
            this.MissionTimeTextBox.Name = "MissionTimeTextBox";
            this.MissionTimeTextBox.Size = new System.Drawing.Size(130, 46);
            this.MissionTimeTextBox.TabIndex = 211;
            this.MissionTimeTextBox.Text = "-1";
            this.MissionTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WarningPictureBox
            // 
            this.WarningPictureBox.Image = global::UAVXGUI.Properties.Resources.Warning_Stripe_Black_Yellow;
            this.WarningPictureBox.Location = new System.Drawing.Point(323, 28);
            this.WarningPictureBox.Name = "WarningPictureBox";
            this.WarningPictureBox.Size = new System.Drawing.Size(258, 13);
            this.WarningPictureBox.TabIndex = 212;
            this.WarningPictureBox.TabStop = false;
            // 
            // GPSPassThruButton
            // 
            this.GPSPassThruButton.Location = new System.Drawing.Point(930, 444);
            this.GPSPassThruButton.Name = "GPSPassThruButton";
            this.GPSPassThruButton.Size = new System.Drawing.Size(69, 23);
            this.GPSPassThruButton.TabIndex = 213;
            this.GPSPassThruButton.Text = "GPS ";
            this.GPSPassThruButton.UseVisualStyleBackColor = true;
            this.GPSPassThruButton.Click += new System.EventHandler(this.GPSPassThruButton_Click);
            // 
            // DumpBBButton
            // 
            this.DumpBBButton.Location = new System.Drawing.Point(650, 1);
            this.DumpBBButton.Name = "DumpBBButton";
            this.DumpBBButton.Size = new System.Drawing.Size(75, 23);
            this.DumpBBButton.TabIndex = 216;
            this.DumpBBButton.Text = "Black Box";
            this.DumpBBButton.UseVisualStyleBackColor = true;
            this.DumpBBButton.Click += new System.EventHandler(this.DumpBBButton_Click);
            // 
            // AlarmsButton
            // 
            this.AlarmsButton.Location = new System.Drawing.Point(262, 0);
            this.AlarmsButton.Name = "AlarmsButton";
            this.AlarmsButton.Size = new System.Drawing.Size(75, 23);
            this.AlarmsButton.TabIndex = 217;
            this.AlarmsButton.Text = "Say Alarms";
            this.AlarmsButton.UseVisualStyleBackColor = true;
            this.AlarmsButton.Click += new System.EventHandler(this.AlarmsButton_Click);
            // 
            // execPeakPercentLabel
            // 
            this.execPeakPercentLabel.AutoSize = true;
            this.execPeakPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execPeakPercentLabel.Location = new System.Drawing.Point(455, 1);
            this.execPeakPercentLabel.Name = "execPeakPercentLabel";
            this.execPeakPercentLabel.Size = new System.Drawing.Size(17, 24);
            this.execPeakPercentLabel.TabIndex = 218;
            this.execPeakPercentLabel.Text = "-";
            // 
            // CalibrationGroupBox
            // 
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ8);
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ6);
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ4);
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ2);
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ7);
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ5);
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ3);
            this.CalibrationGroupBox.Controls.Add(this.progressBarQ1);
            this.CalibrationGroupBox.Controls.Add(this.TrackBaroVariance);
            this.CalibrationGroupBox.Controls.Add(this.BaroVarianceLabel);
            this.CalibrationGroupBox.Controls.Add(this.TrackAccUVariance);
            this.CalibrationGroupBox.Controls.Add(this.AccVarianceLabel);
            this.CalibrationGroupBox.Controls.Add(this.IMUTempLabel);
            this.CalibrationGroupBox.Controls.Add(this.SensorTemp);
            this.CalibrationGroupBox.Controls.Add(this.FWGlideOffsetAngle);
            this.CalibrationGroupBox.Controls.Add(this.YawPitchRollGyroLabel);
            this.CalibrationGroupBox.Controls.Add(this.FWGlideAngleOffsetLabel);
            this.CalibrationGroupBox.Controls.Add(this.FWRateEnergy);
            this.CalibrationGroupBox.Controls.Add(this.NyquistMargin);
            this.CalibrationGroupBox.Controls.Add(this.RateEnergyLabel);
            this.CalibrationGroupBox.Controls.Add(this.GyroLPF);
            this.CalibrationGroupBox.Controls.Add(this.AccLPF);
            this.CalibrationGroupBox.Controls.Add(this.NyquistMarginLabel);
            this.CalibrationGroupBox.Controls.Add(this.AccLPFLabel);
            this.CalibrationGroupBox.Controls.Add(this.PitchRollGyroLabel);
            this.CalibrationGroupBox.Controls.Add(this.MZCalBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MYCalBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MXCalBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MZBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MXBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MYBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MZScaleLabel);
            this.CalibrationGroupBox.Controls.Add(this.label13);
            this.CalibrationGroupBox.Controls.Add(this.label15);
            this.CalibrationGroupBox.Controls.Add(this.MXScaleLabel);
            this.CalibrationGroupBox.Controls.Add(this.MYScaleLabel);
            this.CalibrationGroupBox.Controls.Add(this.label16);
            this.CalibrationGroupBox.Controls.Add(this.label12);
            this.CalibrationGroupBox.Controls.Add(this.CalTRefLabel);
            this.CalibrationGroupBox.Controls.Add(this.UDAccMLabel);
            this.CalibrationGroupBox.Controls.Add(this.BFAccMLabel);
            this.CalibrationGroupBox.Controls.Add(this.LRAccMLabel);
            this.CalibrationGroupBox.Controls.Add(this.UDAccCLabel);
            this.CalibrationGroupBox.Controls.Add(this.BFAccCLabel);
            this.CalibrationGroupBox.Controls.Add(this.LRAccCLabel);
            this.CalibrationGroupBox.Controls.Add(this.YawGyroCLabel);
            this.CalibrationGroupBox.Controls.Add(this.RollGyroCLabel);
            this.CalibrationGroupBox.Controls.Add(this.YawGyroMLabel);
            this.CalibrationGroupBox.Controls.Add(this.YawCalLabel);
            this.CalibrationGroupBox.Controls.Add(this.PitchGyroCLabel);
            this.CalibrationGroupBox.Controls.Add(this.PitchCalLabel);
            this.CalibrationGroupBox.Controls.Add(this.RollCalLabel);
            this.CalibrationGroupBox.Controls.Add(this.RollGyroMLabel);
            this.CalibrationGroupBox.Controls.Add(this.PitchGyroMLabel);
            this.CalibrationGroupBox.Location = new System.Drawing.Point(587, 482);
            this.CalibrationGroupBox.Name = "CalibrationGroupBox";
            this.CalibrationGroupBox.Size = new System.Drawing.Size(418, 149);
            this.CalibrationGroupBox.TabIndex = 220;
            this.CalibrationGroupBox.TabStop = false;
            this.CalibrationGroupBox.Text = "Calibration and Filters";
            // 
            // progressBarQ8
            // 
            this.progressBarQ8.Location = new System.Drawing.Point(344, 59);
            this.progressBarQ8.Maximum = 55;
            this.progressBarQ8.Name = "progressBarQ8";
            this.progressBarQ8.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ8.Step = 1;
            this.progressBarQ8.TabIndex = 240;
            // 
            // progressBarQ6
            // 
            this.progressBarQ6.Location = new System.Drawing.Point(344, 43);
            this.progressBarQ6.Maximum = 55;
            this.progressBarQ6.Name = "progressBarQ6";
            this.progressBarQ6.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ6.Step = 1;
            this.progressBarQ6.TabIndex = 239;
            // 
            // progressBarQ4
            // 
            this.progressBarQ4.Location = new System.Drawing.Point(344, 27);
            this.progressBarQ4.Maximum = 55;
            this.progressBarQ4.Name = "progressBarQ4";
            this.progressBarQ4.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ4.Step = 1;
            this.progressBarQ4.TabIndex = 238;
            // 
            // progressBarQ2
            // 
            this.progressBarQ2.Location = new System.Drawing.Point(344, 11);
            this.progressBarQ2.Maximum = 55;
            this.progressBarQ2.Name = "progressBarQ2";
            this.progressBarQ2.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ2.Step = 1;
            this.progressBarQ2.TabIndex = 237;
            // 
            // progressBarQ7
            // 
            this.progressBarQ7.Location = new System.Drawing.Point(272, 59);
            this.progressBarQ7.Maximum = 55;
            this.progressBarQ7.Name = "progressBarQ7";
            this.progressBarQ7.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ7.Step = 1;
            this.progressBarQ7.TabIndex = 236;
            // 
            // progressBarQ5
            // 
            this.progressBarQ5.Location = new System.Drawing.Point(272, 43);
            this.progressBarQ5.Maximum = 55;
            this.progressBarQ5.Name = "progressBarQ5";
            this.progressBarQ5.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ5.Step = 1;
            this.progressBarQ5.TabIndex = 235;
            // 
            // progressBarQ3
            // 
            this.progressBarQ3.Location = new System.Drawing.Point(272, 27);
            this.progressBarQ3.Maximum = 55;
            this.progressBarQ3.Name = "progressBarQ3";
            this.progressBarQ3.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ3.Step = 1;
            this.progressBarQ3.TabIndex = 234;
            // 
            // progressBarQ1
            // 
            this.progressBarQ1.Location = new System.Drawing.Point(272, 11);
            this.progressBarQ1.Maximum = 55;
            this.progressBarQ1.Name = "progressBarQ1";
            this.progressBarQ1.Size = new System.Drawing.Size(66, 10);
            this.progressBarQ1.Step = 1;
            this.progressBarQ1.TabIndex = 233;
            // 
            // TrackBaroVariance
            // 
            this.TrackBaroVariance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrackBaroVariance.Location = new System.Drawing.Point(365, 90);
            this.TrackBaroVariance.Name = "TrackBaroVariance";
            this.TrackBaroVariance.ReadOnly = true;
            this.TrackBaroVariance.Size = new System.Drawing.Size(45, 13);
            this.TrackBaroVariance.TabIndex = 231;
            this.TrackBaroVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BaroVarianceLabel
            // 
            this.BaroVarianceLabel.AutoSize = true;
            this.BaroVarianceLabel.Location = new System.Drawing.Point(269, 90);
            this.BaroVarianceLabel.Name = "BaroVarianceLabel";
            this.BaroVarianceLabel.Size = new System.Drawing.Size(71, 13);
            this.BaroVarianceLabel.TabIndex = 232;
            this.BaroVarianceLabel.Text = "BaroVariance";
            // 
            // TrackAccUVariance
            // 
            this.TrackAccUVariance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrackAccUVariance.Location = new System.Drawing.Point(365, 73);
            this.TrackAccUVariance.Name = "TrackAccUVariance";
            this.TrackAccUVariance.ReadOnly = true;
            this.TrackAccUVariance.Size = new System.Drawing.Size(45, 13);
            this.TrackAccUVariance.TabIndex = 229;
            this.TrackAccUVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AccVarianceLabel
            // 
            this.AccVarianceLabel.AutoSize = true;
            this.AccVarianceLabel.Location = new System.Drawing.Point(269, 73);
            this.AccVarianceLabel.Name = "AccVarianceLabel";
            this.AccVarianceLabel.Size = new System.Drawing.Size(76, 13);
            this.AccVarianceLabel.TabIndex = 230;
            this.AccVarianceLabel.Text = "AccUVariance";
            // 
            // IMUTempLabel
            // 
            this.IMUTempLabel.AutoSize = true;
            this.IMUTempLabel.Location = new System.Drawing.Point(146, 21);
            this.IMUTempLabel.Name = "IMUTempLabel";
            this.IMUTempLabel.Size = new System.Drawing.Size(43, 13);
            this.IMUTempLabel.TabIndex = 228;
            this.IMUTempLabel.Text = "IMU (C)";
            // 
            // FWGlideOffsetAngle
            // 
            this.FWGlideOffsetAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FWGlideOffsetAngle.Location = new System.Drawing.Point(372, 107);
            this.FWGlideOffsetAngle.Name = "FWGlideOffsetAngle";
            this.FWGlideOffsetAngle.ReadOnly = true;
            this.FWGlideOffsetAngle.Size = new System.Drawing.Size(38, 13);
            this.FWGlideOffsetAngle.TabIndex = 222;
            this.FWGlideOffsetAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YawPitchRollGyroLabel
            // 
            this.YawPitchRollGyroLabel.Location = new System.Drawing.Point(206, 107);
            this.YawPitchRollGyroLabel.Name = "YawPitchRollGyroLabel";
            this.YawPitchRollGyroLabel.Size = new System.Drawing.Size(20, 13);
            this.YawPitchRollGyroLabel.TabIndex = 221;
            this.YawPitchRollGyroLabel.Text = "0";
            this.YawPitchRollGyroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FWGlideAngleOffsetLabel
            // 
            this.FWGlideAngleOffsetLabel.AutoSize = true;
            this.FWGlideAngleOffsetLabel.Location = new System.Drawing.Point(269, 107);
            this.FWGlideAngleOffsetLabel.Name = "FWGlideAngleOffsetLabel";
            this.FWGlideAngleOffsetLabel.Size = new System.Drawing.Size(103, 13);
            this.FWGlideAngleOffsetLabel.TabIndex = 225;
            this.FWGlideAngleOffsetLabel.Text = "Pitch Trim FW (Deg)";
            // 
            // NyquistMargin
            // 
            this.NyquistMargin.AutoSize = true;
            this.NyquistMargin.Location = new System.Drawing.Point(145, 123);
            this.NyquistMargin.Name = "NyquistMargin";
            this.NyquistMargin.Size = new System.Drawing.Size(64, 13);
            this.NyquistMargin.TabIndex = 220;
            this.NyquistMargin.Text = "Nyquist (Hz)";
            // 
            // GyroLPF
            // 
            this.GyroLPF.AutoSize = true;
            this.GyroLPF.Location = new System.Drawing.Point(146, 107);
            this.GyroLPF.Name = "GyroLPF";
            this.GyroLPF.Size = new System.Drawing.Size(57, 13);
            this.GyroLPF.TabIndex = 219;
            this.GyroLPF.Text = "Gyro Y-PR";
            // 
            // AccLPF
            // 
            this.AccLPF.AutoSize = true;
            this.AccLPF.Location = new System.Drawing.Point(146, 91);
            this.AccLPF.Name = "AccLPF";
            this.AccLPF.Size = new System.Drawing.Size(73, 13);
            this.AccLPF.TabIndex = 218;
            this.AccLPF.Text = "LPF(Hz)   Acc";
            // 
            // NyquistMarginLabel
            // 
            this.NyquistMarginLabel.Location = new System.Drawing.Point(218, 123);
            this.NyquistMarginLabel.Name = "NyquistMarginLabel";
            this.NyquistMarginLabel.Size = new System.Drawing.Size(40, 13);
            this.NyquistMarginLabel.TabIndex = 217;
            this.NyquistMarginLabel.Text = "0";
            this.NyquistMarginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccLPFLabel
            // 
            this.AccLPFLabel.Location = new System.Drawing.Point(218, 91);
            this.AccLPFLabel.Name = "AccLPFLabel";
            this.AccLPFLabel.Size = new System.Drawing.Size(40, 13);
            this.AccLPFLabel.TabIndex = 216;
            this.AccLPFLabel.Text = "0";
            this.AccLPFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PitchRollGyroLabel
            // 
            this.PitchRollGyroLabel.Location = new System.Drawing.Point(218, 107);
            this.PitchRollGyroLabel.Name = "PitchRollGyroLabel";
            this.PitchRollGyroLabel.Size = new System.Drawing.Size(40, 13);
            this.PitchRollGyroLabel.TabIndex = 215;
            this.PitchRollGyroLabel.Text = "0";
            this.PitchRollGyroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MZCalBiasLabel
            // 
            this.MZCalBiasLabel.AutoSize = true;
            this.MZCalBiasLabel.Location = new System.Drawing.Point(146, 74);
            this.MZCalBiasLabel.Name = "MZCalBiasLabel";
            this.MZCalBiasLabel.Size = new System.Drawing.Size(22, 13);
            this.MZCalBiasLabel.TabIndex = 213;
            this.MZCalBiasLabel.Text = "mZ";
            // 
            // MYCalBiasLabel
            // 
            this.MYCalBiasLabel.AutoSize = true;
            this.MYCalBiasLabel.Location = new System.Drawing.Point(146, 57);
            this.MYCalBiasLabel.Name = "MYCalBiasLabel";
            this.MYCalBiasLabel.Size = new System.Drawing.Size(22, 13);
            this.MYCalBiasLabel.TabIndex = 212;
            this.MYCalBiasLabel.Text = "mY";
            // 
            // MXCalBiasLabel
            // 
            this.MXCalBiasLabel.AutoSize = true;
            this.MXCalBiasLabel.Location = new System.Drawing.Point(146, 39);
            this.MXCalBiasLabel.Name = "MXCalBiasLabel";
            this.MXCalBiasLabel.Size = new System.Drawing.Size(22, 13);
            this.MXCalBiasLabel.TabIndex = 211;
            this.MXCalBiasLabel.Text = "mX";
            // 
            // MZBiasLabel
            // 
            this.MZBiasLabel.Location = new System.Drawing.Point(218, 74);
            this.MZBiasLabel.Name = "MZBiasLabel";
            this.MZBiasLabel.Size = new System.Drawing.Size(40, 13);
            this.MZBiasLabel.TabIndex = 210;
            this.MZBiasLabel.Text = "0";
            this.MZBiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MXBiasLabel
            // 
            this.MXBiasLabel.Location = new System.Drawing.Point(218, 39);
            this.MXBiasLabel.Name = "MXBiasLabel";
            this.MXBiasLabel.Size = new System.Drawing.Size(40, 13);
            this.MXBiasLabel.TabIndex = 209;
            this.MXBiasLabel.Text = "0";
            this.MXBiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MYBiasLabel
            // 
            this.MYBiasLabel.Location = new System.Drawing.Point(218, 57);
            this.MYBiasLabel.Name = "MYBiasLabel";
            this.MYBiasLabel.Size = new System.Drawing.Size(40, 13);
            this.MYBiasLabel.TabIndex = 208;
            this.MYBiasLabel.Text = "0";
            this.MYBiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MZScaleLabel
            // 
            this.MZScaleLabel.Location = new System.Drawing.Point(164, 74);
            this.MZScaleLabel.Name = "MZScaleLabel";
            this.MZScaleLabel.Size = new System.Drawing.Size(40, 13);
            this.MZScaleLabel.TabIndex = 207;
            this.MZScaleLabel.Text = "0";
            this.MZScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 204;
            this.label13.Text = "aUD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 203;
            this.label15.Text = "aLR";
            // 
            // MXScaleLabel
            // 
            this.MXScaleLabel.Location = new System.Drawing.Point(164, 39);
            this.MXScaleLabel.Name = "MXScaleLabel";
            this.MXScaleLabel.Size = new System.Drawing.Size(40, 13);
            this.MXScaleLabel.TabIndex = 206;
            this.MXScaleLabel.Text = "0";
            this.MXScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MYScaleLabel
            // 
            this.MYScaleLabel.Location = new System.Drawing.Point(164, 57);
            this.MYScaleLabel.Name = "MYScaleLabel";
            this.MYScaleLabel.Size = new System.Drawing.Size(40, 13);
            this.MYScaleLabel.TabIndex = 205;
            this.MYScaleLabel.Text = "0";
            this.MYScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 202;
            this.label16.Text = "aBF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "Scale/Bias @";
            // 
            // CalTRefLabel
            // 
            this.CalTRefLabel.Location = new System.Drawing.Point(88, 24);
            this.CalTRefLabel.Name = "CalTRefLabel";
            this.CalTRefLabel.Size = new System.Drawing.Size(40, 13);
            this.CalTRefLabel.TabIndex = 84;
            this.CalTRefLabel.Text = "0";
            this.CalTRefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UDAccMLabel
            // 
            this.UDAccMLabel.Location = new System.Drawing.Point(46, 124);
            this.UDAccMLabel.Name = "UDAccMLabel";
            this.UDAccMLabel.Size = new System.Drawing.Size(40, 13);
            this.UDAccMLabel.TabIndex = 83;
            this.UDAccMLabel.Text = "0";
            this.UDAccMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BFAccMLabel
            // 
            this.BFAccMLabel.Location = new System.Drawing.Point(46, 90);
            this.BFAccMLabel.Name = "BFAccMLabel";
            this.BFAccMLabel.Size = new System.Drawing.Size(40, 13);
            this.BFAccMLabel.TabIndex = 82;
            this.BFAccMLabel.Text = "0";
            this.BFAccMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LRAccMLabel
            // 
            this.LRAccMLabel.Location = new System.Drawing.Point(46, 107);
            this.LRAccMLabel.Name = "LRAccMLabel";
            this.LRAccMLabel.Size = new System.Drawing.Size(40, 13);
            this.LRAccMLabel.TabIndex = 81;
            this.LRAccMLabel.Text = "0";
            this.LRAccMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UDAccCLabel
            // 
            this.UDAccCLabel.Location = new System.Drawing.Point(88, 124);
            this.UDAccCLabel.Name = "UDAccCLabel";
            this.UDAccCLabel.Size = new System.Drawing.Size(40, 13);
            this.UDAccCLabel.TabIndex = 80;
            this.UDAccCLabel.Text = "0";
            this.UDAccCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BFAccCLabel
            // 
            this.BFAccCLabel.Location = new System.Drawing.Point(88, 90);
            this.BFAccCLabel.Name = "BFAccCLabel";
            this.BFAccCLabel.Size = new System.Drawing.Size(40, 13);
            this.BFAccCLabel.TabIndex = 79;
            this.BFAccCLabel.Text = "0";
            this.BFAccCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LRAccCLabel
            // 
            this.LRAccCLabel.Location = new System.Drawing.Point(88, 107);
            this.LRAccCLabel.Name = "LRAccCLabel";
            this.LRAccCLabel.Size = new System.Drawing.Size(40, 13);
            this.LRAccCLabel.TabIndex = 78;
            this.LRAccCLabel.Text = "0";
            this.LRAccCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YawGyroCLabel
            // 
            this.YawGyroCLabel.Location = new System.Drawing.Point(88, 73);
            this.YawGyroCLabel.Name = "YawGyroCLabel";
            this.YawGyroCLabel.Size = new System.Drawing.Size(40, 13);
            this.YawGyroCLabel.TabIndex = 73;
            this.YawGyroCLabel.Text = "0";
            this.YawGyroCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RollGyroCLabel
            // 
            this.RollGyroCLabel.Location = new System.Drawing.Point(88, 39);
            this.RollGyroCLabel.Name = "RollGyroCLabel";
            this.RollGyroCLabel.Size = new System.Drawing.Size(40, 13);
            this.RollGyroCLabel.TabIndex = 71;
            this.RollGyroCLabel.Text = "0";
            this.RollGyroCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YawGyroMLabel
            // 
            this.YawGyroMLabel.Location = new System.Drawing.Point(46, 73);
            this.YawGyroMLabel.Name = "YawGyroMLabel";
            this.YawGyroMLabel.Size = new System.Drawing.Size(40, 13);
            this.YawGyroMLabel.TabIndex = 70;
            this.YawGyroMLabel.Text = "0";
            this.YawGyroMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YawCalLabel
            // 
            this.YawCalLabel.AutoSize = true;
            this.YawCalLabel.Location = new System.Drawing.Point(14, 73);
            this.YawCalLabel.Name = "YawCalLabel";
            this.YawCalLabel.Size = new System.Drawing.Size(20, 13);
            this.YawCalLabel.TabIndex = 69;
            this.YawCalLabel.Text = "gY";
            // 
            // PitchGyroCLabel
            // 
            this.PitchGyroCLabel.Location = new System.Drawing.Point(88, 56);
            this.PitchGyroCLabel.Name = "PitchGyroCLabel";
            this.PitchGyroCLabel.Size = new System.Drawing.Size(40, 13);
            this.PitchGyroCLabel.TabIndex = 68;
            this.PitchGyroCLabel.Text = "0";
            this.PitchGyroCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PitchCalLabel
            // 
            this.PitchCalLabel.AutoSize = true;
            this.PitchCalLabel.Location = new System.Drawing.Point(14, 56);
            this.PitchCalLabel.Name = "PitchCalLabel";
            this.PitchCalLabel.Size = new System.Drawing.Size(20, 13);
            this.PitchCalLabel.TabIndex = 53;
            this.PitchCalLabel.Text = "gP";
            // 
            // RollCalLabel
            // 
            this.RollCalLabel.AutoSize = true;
            this.RollCalLabel.Location = new System.Drawing.Point(14, 39);
            this.RollCalLabel.Name = "RollCalLabel";
            this.RollCalLabel.Size = new System.Drawing.Size(21, 13);
            this.RollCalLabel.TabIndex = 49;
            this.RollCalLabel.Text = "gR";
            // 
            // RollGyroMLabel
            // 
            this.RollGyroMLabel.Location = new System.Drawing.Point(46, 39);
            this.RollGyroMLabel.Name = "RollGyroMLabel";
            this.RollGyroMLabel.Size = new System.Drawing.Size(40, 13);
            this.RollGyroMLabel.TabIndex = 48;
            this.RollGyroMLabel.Text = "0";
            this.RollGyroMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PitchGyroMLabel
            // 
            this.PitchGyroMLabel.Location = new System.Drawing.Point(46, 56);
            this.PitchGyroMLabel.Name = "PitchGyroMLabel";
            this.PitchGyroMLabel.Size = new System.Drawing.Size(40, 13);
            this.PitchGyroMLabel.TabIndex = 51;
            this.PitchGyroMLabel.Text = "0";
            this.PitchGyroMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BootLoadButton
            // 
            this.BootLoadButton.BackColor = System.Drawing.Color.Green;
            this.BootLoadButton.Location = new System.Drawing.Point(571, 1);
            this.BootLoadButton.Name = "BootLoadButton";
            this.BootLoadButton.Size = new System.Drawing.Size(75, 23);
            this.BootLoadButton.TabIndex = 229;
            this.BootLoadButton.Text = "BOOTLOAD";
            this.BootLoadButton.UseVisualStyleBackColor = false;
            this.BootLoadButton.Click += new System.EventHandler(this.BootLoadButton_Click);
            // 
            // WPActionTextBox
            // 
            this.WPActionTextBox.Location = new System.Drawing.Point(171, 28);
            this.WPActionTextBox.Name = "WPActionTextBox";
            this.WPActionTextBox.ReadOnly = true;
            this.WPActionTextBox.Size = new System.Drawing.Size(53, 20);
            this.WPActionTextBox.TabIndex = 230;
            this.WPActionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KMLComboBox
            // 
            this.KMLComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "TriAF",
            "TriCoaxialAF/Y6",
            "VTailAF",
            "QuadAF",
            "QuadXAF",
            "QuadCoaxAF/OctCoax",
            "QuadCoaxXAF",
            "HexAF",
            "HexXAF",
            "OctAF",
            "OctXAF",
            "Heli90AF",
            "Heli120AF",
            "ElevonAF",
            "AileronAF",
            "VTOLAF",
            "GimbalAF,",
            "AFUnknown,"});
            this.KMLComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.KMLComboBox.FormattingEnabled = true;
            this.KMLComboBox.Items.AddRange(new object[] {
            "KML Alt",
            "KML Nav",
            "KML RC1",
            "KML Sats"});
            this.KMLComboBox.Location = new System.Drawing.Point(813, 2);
            this.KMLComboBox.Name = "KMLComboBox";
            this.KMLComboBox.Size = new System.Drawing.Size(79, 21);
            this.KMLComboBox.TabIndex = 261;
            this.KMLComboBox.Tag = "44";
            this.KMLComboBox.Text = "KML Alt";
            // 
            // CalibrateAccZeroButton
            // 
            this.CalibrateAccZeroButton.Location = new System.Drawing.Point(930, 415);
            this.CalibrateAccZeroButton.Name = "CalibrateAccZeroButton";
            this.CalibrateAccZeroButton.Size = new System.Drawing.Size(69, 23);
            this.CalibrateAccZeroButton.TabIndex = 263;
            this.CalibrateAccZeroButton.Text = "Simple IMU";
            this.CalibrateAccZeroButton.UseVisualStyleBackColor = true;
            this.CalibrateAccZeroButton.Click += new System.EventHandler(this.CalibrateAccZeroButton_Click);
            // 
            // WhereGroupBox
            // 
            this.WhereGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.WhereGroupBox.Controls.Add(this.WhereDistance);
            this.WhereGroupBox.Controls.Add(this.label18);
            this.WhereGroupBox.Controls.Add(this.WhereBearingLabel);
            this.WhereGroupBox.Controls.Add(this.WhereDistanceLabel);
            this.WhereGroupBox.Controls.Add(this.WhereBearing);
            this.WhereGroupBox.Location = new System.Drawing.Point(12, 57);
            this.WhereGroupBox.Name = "WhereGroupBox";
            this.WhereGroupBox.Size = new System.Drawing.Size(305, 40);
            this.WhereGroupBox.TabIndex = 264;
            this.WhereGroupBox.TabStop = false;
            this.WhereGroupBox.Text = "Aircraft Direction and Distance";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 62;
            // 
            // execPercentLabel
            // 
            this.execPercentLabel.AutoSize = true;
            this.execPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execPercentLabel.Location = new System.Drawing.Point(409, 2);
            this.execPercentLabel.Name = "execPercentLabel";
            this.execPercentLabel.Size = new System.Drawing.Size(17, 24);
            this.execPercentLabel.TabIndex = 265;
            this.execPercentLabel.Text = "-";
            // 
            // MagHeadingTextBox
            // 
            this.MagHeadingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagHeadingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagHeadingTextBox.Location = new System.Drawing.Point(389, 618);
            this.MagHeadingTextBox.Name = "MagHeadingTextBox";
            this.MagHeadingTextBox.ReadOnly = true;
            this.MagHeadingTextBox.Size = new System.Drawing.Size(121, 15);
            this.MagHeadingTextBox.TabIndex = 266;
            this.MagHeadingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RadioGroupBox
            // 
            this.RadioGroupBox.Controls.Add(this.RCFailsafesTextBox);
            this.RadioGroupBox.Controls.Add(this.RCFailsafesLabel);
            this.RadioGroupBox.Controls.Add(this.RCSignalLossesTextBox);
            this.RadioGroupBox.Controls.Add(this.RCSignalLossesLabel);
            this.RadioGroupBox.Controls.Add(this.upSNRTextBox);
            this.RadioGroupBox.Controls.Add(this.RCGlitches);
            this.RadioGroupBox.Controls.Add(this.upSNRLabel);
            this.RadioGroupBox.Controls.Add(this.RCGlitchesLabel);
            this.RadioGroupBox.Controls.Add(this.upRSSITextBox);
            this.RadioGroupBox.Controls.Add(this.upLQTextBox);
            this.RadioGroupBox.Controls.Add(this.upRSSILabel);
            this.RadioGroupBox.Controls.Add(this.upLQLabel);
            this.RadioGroupBox.Location = new System.Drawing.Point(178, 280);
            this.RadioGroupBox.Name = "RadioGroupBox";
            this.RadioGroupBox.Size = new System.Drawing.Size(139, 105);
            this.RadioGroupBox.TabIndex = 267;
            this.RadioGroupBox.TabStop = false;
            this.RadioGroupBox.Text = "Link";
            // 
            // RCFailsafesTextBox
            // 
            this.RCFailsafesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCFailsafesTextBox.Location = new System.Drawing.Point(58, 64);
            this.RCFailsafesTextBox.Name = "RCFailsafesTextBox";
            this.RCFailsafesTextBox.ReadOnly = true;
            this.RCFailsafesTextBox.Size = new System.Drawing.Size(44, 13);
            this.RCFailsafesTextBox.TabIndex = 86;
            this.RCFailsafesTextBox.Text = "-";
            this.RCFailsafesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RCFailsafesLabel
            // 
            this.RCFailsafesLabel.AutoSize = true;
            this.RCFailsafesLabel.Location = new System.Drawing.Point(7, 64);
            this.RCFailsafesLabel.Name = "RCFailsafesLabel";
            this.RCFailsafesLabel.Size = new System.Drawing.Size(48, 13);
            this.RCFailsafesLabel.TabIndex = 87;
            this.RCFailsafesLabel.Text = "Failsafes";
            // 
            // RCSignalLossesTextBox
            // 
            this.RCSignalLossesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RCSignalLossesTextBox.Location = new System.Drawing.Point(58, 48);
            this.RCSignalLossesTextBox.Name = "RCSignalLossesTextBox";
            this.RCSignalLossesTextBox.ReadOnly = true;
            this.RCSignalLossesTextBox.Size = new System.Drawing.Size(44, 13);
            this.RCSignalLossesTextBox.TabIndex = 84;
            this.RCSignalLossesTextBox.Text = "-";
            this.RCSignalLossesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RCSignalLossesLabel
            // 
            this.RCSignalLossesLabel.AutoSize = true;
            this.RCSignalLossesLabel.Location = new System.Drawing.Point(7, 47);
            this.RCSignalLossesLabel.Name = "RCSignalLossesLabel";
            this.RCSignalLossesLabel.Size = new System.Drawing.Size(40, 13);
            this.RCSignalLossesLabel.TabIndex = 85;
            this.RCSignalLossesLabel.Text = "Losses";
            // 
            // upSNRTextBox
            // 
            this.upSNRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upSNRTextBox.Location = new System.Drawing.Point(47, 29);
            this.upSNRTextBox.Name = "upSNRTextBox";
            this.upSNRTextBox.ReadOnly = true;
            this.upSNRTextBox.Size = new System.Drawing.Size(20, 13);
            this.upSNRTextBox.TabIndex = 80;
            this.upSNRTextBox.Text = "-";
            this.upSNRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // upSNRLabel
            // 
            this.upSNRLabel.AutoSize = true;
            this.upSNRLabel.Location = new System.Drawing.Point(7, 30);
            this.upSNRLabel.Name = "upSNRLabel";
            this.upSNRLabel.Size = new System.Drawing.Size(30, 13);
            this.upSNRLabel.TabIndex = 81;
            this.upSNRLabel.Text = "SNR";
            // 
            // upRSSITextBox
            // 
            this.upRSSITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upRSSITextBox.Location = new System.Drawing.Point(111, 12);
            this.upRSSITextBox.Name = "upRSSITextBox";
            this.upRSSITextBox.ReadOnly = true;
            this.upRSSITextBox.Size = new System.Drawing.Size(20, 13);
            this.upRSSITextBox.TabIndex = 58;
            this.upRSSITextBox.Text = "-";
            this.upRSSITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // upLQTextBox
            // 
            this.upLQTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upLQTextBox.Location = new System.Drawing.Point(47, 12);
            this.upLQTextBox.Name = "upLQTextBox";
            this.upLQTextBox.ReadOnly = true;
            this.upLQTextBox.Size = new System.Drawing.Size(20, 13);
            this.upLQTextBox.TabIndex = 46;
            this.upLQTextBox.Text = "-";
            this.upLQTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // upRSSILabel
            // 
            this.upRSSILabel.AutoSize = true;
            this.upRSSILabel.Location = new System.Drawing.Point(72, 12);
            this.upRSSILabel.Name = "upRSSILabel";
            this.upRSSILabel.Size = new System.Drawing.Size(32, 13);
            this.upRSSILabel.TabIndex = 74;
            this.upRSSILabel.Text = "RSSI";
            // 
            // upLQLabel
            // 
            this.upLQLabel.AutoSize = true;
            this.upLQLabel.Location = new System.Drawing.Point(7, 13);
            this.upLQLabel.Name = "upLQLabel";
            this.upLQLabel.Size = new System.Drawing.Size(21, 13);
            this.upLQLabel.TabIndex = 75;
            this.upLQLabel.Text = "LQ";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(323, 118);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(258, 257);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 3;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(347, 403);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(210, 218);
            this.headingIndicatorInstrumentControl1.TabIndex = 4;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1013, 643);
            this.Controls.Add(this.RadioGroupBox);
            this.Controls.Add(this.MagHeadingTextBox);
            this.Controls.Add(this.execPercentLabel);
            this.Controls.Add(this.WhereGroupBox);
            this.Controls.Add(this.CalibrateAccZeroButton);
            this.Controls.Add(this.KMLComboBox);
            this.Controls.Add(this.WPActionTextBox);
            this.Controls.Add(this.BootLoadButton);
            this.Controls.Add(this.CalibrationGroupBox);
            this.Controls.Add(this.execPeakPercentLabel);
            this.Controls.Add(this.AlarmsButton);
            this.Controls.Add(this.DumpBBButton);
            this.Controls.Add(this.GPSPassThruButton);
            this.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.Controls.Add(this.WarningPictureBox);
            this.Controls.Add(this.MissionTimeTextBox);
            this.Controls.Add(this.DrivesGroupBox);
            this.Controls.Add(this.AltitudeGroupBox);
            this.Controls.Add(this.CommsGroupBox);
            this.Controls.Add(this.StartParametersButton);
            this.Controls.Add(this.StartNavigationButton);
            this.Controls.Add(this.SpeechGroupBox);
            this.Controls.Add(this.ROCLabel);
            this.Controls.Add(this.ROC);
            this.Controls.Add(this.NavState);
            this.Controls.Add(this.CalibrateIMUButton);
            this.Controls.Add(this.ReplayNumericUpDown);
            this.Controls.Add(this.CalibrateMagButton);
            this.Controls.Add(this.Airframe);
            this.Controls.Add(this.ReplayProgressBar);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.FlightState);
            this.Controls.Add(this.EmulationTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AltitudeSource);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.CurrentAltitude);
            this.Controls.Add(this.GPSStatusBox);
            this.Controls.Add(this.FlagsGroupBox);
            this.Controls.Add(this.AlarmState);
            this.Controls.Add(this.BatteryGroupBox);
            this.Controls.Add(this.AccelerationsGroupBox);
            this.Controls.Add(this.AttitudeGroupBox);
            this.Controls.Add(this.ControlsGroupBox);
            this.Controls.Add(this.GyroGroupBox);
            this.Controls.Add(this.NavGroupBox);
            this.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.RightToLeftLayout = true;
            this.Text = "UAVXGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GyroGroupBox.ResumeLayout(false);
            this.GyroGroupBox.PerformLayout();
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            this.AttitudeGroupBox.ResumeLayout(false);
            this.AttitudeGroupBox.PerformLayout();
            this.AccelerationsGroupBox.ResumeLayout(false);
            this.AccelerationsGroupBox.PerformLayout();
            this.CommsGroupBox.ResumeLayout(false);
            this.CommsGroupBox.PerformLayout();
            this.BatteryGroupBox.ResumeLayout(false);
            this.BatteryGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FlagsGroupBox.ResumeLayout(false);
            this.GPSStatusBox.ResumeLayout(false);
            this.GPSStatusBox.PerformLayout();
            this.AltitudeGroupBox.ResumeLayout(false);
            this.AltitudeGroupBox.PerformLayout();
            this.NavGroupBox.ResumeLayout(false);
            this.NavGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayNumericUpDown)).EndInit();
            this.SpeechGroupBox.ResumeLayout(false);
            this.SpeechGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakIntervalNumericUpDown)).EndInit();
            this.DrivesGroupBox.ResumeLayout(false);
            this.DrivesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).EndInit();
            this.CalibrationGroupBox.ResumeLayout(false);
            this.CalibrationGroupBox.PerformLayout();
            this.WhereGroupBox.ResumeLayout(false);
            this.WhereGroupBox.PerformLayout();
            this.RadioGroupBox.ResumeLayout(false);
            this.RadioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private Instruments.AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private Instruments.HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private System.Windows.Forms.TextBox RollAngle;
        private System.Windows.Forms.TextBox PitchAngle;
        private System.Windows.Forms.TextBox BatteryVolts;
        private System.Windows.Forms.TextBox BatteryCurrent;
        private System.Windows.Forms.TextBox RCGlitches;
        private System.Windows.Forms.TextBox DesiredThrottle;
        private System.Windows.Forms.TextBox DesiredRoll;
        private System.Windows.Forms.TextBox DesiredPitch;
        private System.Windows.Forms.TextBox DesiredYaw;
        private System.Windows.Forms.TextBox YawGyro;
        private System.Windows.Forms.TextBox PitchRate;
        private System.Windows.Forms.TextBox RollRate;
        private System.Windows.Forms.TextBox LRAcc;
        private System.Windows.Forms.TextBox YawAngle;
        private System.Windows.Forms.TextBox DUAcc;
        private System.Windows.Forms.TextBox FBAcc;
        private System.Windows.Forms.Label VoltsLabel;
        private System.Windows.Forms.Label LRAccLabel;
        private System.Windows.Forms.Label FBAccLabel;
        private System.Windows.Forms.Label DUAccLabel;
        private System.Windows.Forms.Label DesiredYawLabel;
        private System.Windows.Forms.Label DesiredPitchLabel;
        private System.Windows.Forms.Label DesiredRollLabel;
        private System.Windows.Forms.Label DesiredThrottleLabel;
        private System.Windows.Forms.Label RCGlitchesLabel;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.TextBox GPShAcc;
        private System.Windows.Forms.TextBox RangefinderAltitude;
        private System.Windows.Forms.TextBox BaroAltitude;
        private System.Windows.Forms.TextBox GPSFix;
        private System.Windows.Forms.TextBox ROC;
        private System.Windows.Forms.TextBox GPSNoOfSats;
        private System.Windows.Forms.TextBox AlarmState;
        private System.Windows.Forms.TextBox GPSAltitude;
        private System.Windows.Forms.Label ROCLabel;
        private System.Windows.Forms.Label hAccLabel;
        private System.Windows.Forms.Label RangefinderAltLabel;
        private System.Windows.Forms.Label GPSFixLabel;
        private System.Windows.Forms.Label GPSNoOfSatsLabel;
        private System.Windows.Forms.Label GPSAltLabel;
        private System.Windows.Forms.Label BaroAltitudeLabel;
        private System.Windows.Forms.Label YawGyroLabel;
        private System.Windows.Forms.Label PitchRateLabel;
        private System.Windows.Forms.Label RollRateLabel;
        private System.Windows.Forms.TextBox RxTypeErr;
        private System.Windows.Forms.TextBox RxCSumErr;
        private System.Windows.Forms.TextBox RxLenErr;
        private System.Windows.Forms.Label RxTypeLabel;
        private System.Windows.Forms.Label RxCSumLabel;
        private System.Windows.Forms.Label RxLenLabel;
        private System.Windows.Forms.TextBox FlightState;
        private System.Windows.Forms.GroupBox GyroGroupBox;
        private System.Windows.Forms.GroupBox ControlsGroupBox;
        private System.Windows.Forms.GroupBox AttitudeGroupBox;
        private System.Windows.Forms.GroupBox AccelerationsGroupBox;
        private System.Windows.Forms.GroupBox CommsGroupBox;
        private System.Windows.Forms.GroupBox BatteryGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox AltHoldBox;
        private System.Windows.Forms.TextBox TurnToPOIBox;
        private System.Windows.Forms.TextBox RapidDescentHazardFlagBox;
        private System.Windows.Forms.TextBox LandingSwitchBox;
        private System.Windows.Forms.TextBox NearLevelBox;
        private System.Windows.Forms.TextBox LowBatteryBox;
        private System.Windows.Forms.TextBox GPSValidBox;
        private System.Windows.Forms.TextBox NavValidBox;
        private System.Windows.Forms.TextBox BaroFailBox;
        private System.Windows.Forms.TextBox IMUFailBox;
        private System.Windows.Forms.TextBox MagFailBox;
        private System.Windows.Forms.TextBox GPSFailBox;
        private System.Windows.Forms.TextBox AttitudeHoldBox;
        private System.Windows.Forms.TextBox ThrottleMovingBox;
        private System.Windows.Forms.TextBox HoldingAltBox;
        private System.Windows.Forms.TextBox NavigateBox;
        private System.Windows.Forms.TextBox AngleControlBox;
        private System.Windows.Forms.TextBox ProximityBox;
        private System.Windows.Forms.TextBox CloseProximityBox;
        private System.Windows.Forms.TextBox UseRTHAutoDescendBox;
        private System.Windows.Forms.TextBox BaroAltValidBox;
        private System.Windows.Forms.TextBox RangefinderAltValidBox;
        private System.Windows.Forms.TextBox UsingRangefinderBox;
        private System.Windows.Forms.GroupBox FlagsGroupBox;
        private System.Windows.Forms.GroupBox GPSStatusBox;
        private System.Windows.Forms.GroupBox AltitudeGroupBox;
        private System.Windows.Forms.Label WayHeadingLabel;
        private System.Windows.Forms.Label GPSLongitudeLabel;
        private System.Windows.Forms.Label GPSLatitudeLabel;
        private System.Windows.Forms.Label GPSVelLabel;
        private System.Windows.Forms.Label CurrWPLabel;
        private System.Windows.Forms.TextBox GPSLatitude;
        private System.Windows.Forms.TextBox GPSLongitude;
        private System.Windows.Forms.TextBox NavState;
        private System.Windows.Forms.TextBox CurrWP;
        private System.Windows.Forms.TextBox WayHeading;
        private System.Windows.Forms.Label AltitudeErrorLabel;
        private System.Windows.Forms.TextBox GPSVel;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.TextBox DesiredAltitude;
        private System.Windows.Forms.TextBox Heading;
        private System.Windows.Forms.Label WPDistanceLabel;
        private System.Windows.Forms.TextBox DistanceToDesired;
        private System.Windows.Forms.GroupBox NavGroupBox;
        private System.Windows.Forms.TextBox CurrentAltitude;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox AltitudeSource;
        private System.Windows.Forms.Label WhereBearingLabel;
        private System.Windows.Forms.Label WhereDistanceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AltComp;
        private System.Windows.Forms.TextBox TiltFFComp;
        private System.Windows.Forms.Label TiltFFCompLabel;
        private System.Windows.Forms.Label AltCompLabel;
        private System.Windows.Forms.Label NavStateTimeoutLabel;
        private System.Windows.Forms.TextBox NavStateTimeout;
        private System.Windows.Forms.TextBox BatteryCharge;
        private System.Windows.Forms.Label BatteryChargeLabel;
        private System.Windows.Forms.TextBox EmulationTextBox;
        private System.Windows.Forms.OpenFileDialog OpenLogFileDialog;
        private System.Windows.Forms.ToolStripComboBox COMSelectComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox COMBaudRateComboBox;
        private System.Windows.Forms.TextBox SensorTemp;
        private System.Windows.Forms.TextBox WhereDistance;
        private System.Windows.Forms.TextBox WhereBearing;
        private System.Windows.Forms.Button ReplayButton;
        public System.Windows.Forms.ProgressBar ReplayProgressBar;
        private System.Windows.Forms.Label YawLabel;
        private System.Windows.Forms.Label PitchLabel;
        private System.Windows.Forms.Label RollLabel;
        private System.Windows.Forms.TextBox BypassBox;
        private System.Windows.Forms.TextBox Airframe;
        private System.Windows.Forms.NumericUpDown ReplayNumericUpDown;
        private System.Windows.Forms.TextBox GPSAltitudeBox;
        private System.Windows.Forms.TextBox NavSensitivity;
        private System.Windows.Forms.Label NavSensitivityLabel;
        private System.Windows.Forms.TextBox NavYCorr;
        private System.Windows.Forms.TextBox NavRCorr;
        private System.Windows.Forms.TextBox NavPCorr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GPSHeadingLabel;
        private System.Windows.Forms.TextBox GPSHeading;
        private System.Windows.Forms.Label AccConfidenceLabel;
        private System.Windows.Forms.TextBox AccConfidence;
        private System.Windows.Forms.Label CrossTrackErrorLabel;
        private System.Windows.Forms.TextBox CrossTrackError;
        private System.Windows.Forms.GroupBox SpeechGroupBox;
        private System.Windows.Forms.NumericUpDown SpeakIntervalNumericUpDown;
        private System.Windows.Forms.CheckBox SpeechEnableCheckBox;
        private System.Windows.Forms.CheckBox SpeakNavCheckBox;
        private System.Windows.Forms.CheckBox SpeakAltitudeCheckBox;
        private System.Windows.Forms.CheckBox SpeakWhereCheckBox;
        private System.Windows.Forms.CheckBox SpeakVoltsCheckBox;
        private System.Windows.Forms.Timer timer_announce;
        private System.Windows.Forms.Timer timer_telemetry;
        private System.Windows.Forms.Button StartParametersButton;
        private System.Windows.Forms.Button CalibrateIMUButton;
        private System.Windows.Forms.Button CalibrateMagButton;
        private System.Windows.Forms.Label SpeakIntervalLabel;
        private System.Windows.Forms.GroupBox DrivesGroupBox;
        private System.Windows.Forms.TextBox PWMT9;
        private System.Windows.Forms.TextBox PWMT8;
        private System.Windows.Forms.TextBox PWMT7;
        private System.Windows.Forms.TextBox PWMT6;
        private System.Windows.Forms.TextBox PWMT5;
        private System.Windows.Forms.TextBox PWMT4;
        private System.Windows.Forms.TextBox PWMT3;
        private System.Windows.Forms.TextBox PWMT2;
        private System.Windows.Forms.TextBox PWMT1;
        private System.Windows.Forms.TextBox PWMT0;
        private System.Windows.Forms.ProgressBar PWMT0ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT6ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT1ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT9ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT5ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT8ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT2ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT7ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT4ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT3ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.Windows.Forms.TextBox MissionTimeTextBox;
        public System.Windows.Forms.Button StartNavigationButton;
        private System.Windows.Forms.PictureBox WarningPictureBox;
        public static System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button GPSPassThruButton;
        private System.Windows.Forms.CheckBox SpeakVarioCheckBox;
        private System.Windows.Forms.Button DumpBBButton;
        private System.Windows.Forms.Button AlarmsButton;
        private System.Windows.Forms.Label execPeakPercentLabel;
        private System.Windows.Forms.TextBox BaroPressure;
        private System.Windows.Forms.TextBox BaroTemperature;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BattFFLabel;
        private System.Windows.Forms.TextBox BattFFComp;
        private System.Windows.Forms.GroupBox CalibrationGroupBox;
        private System.Windows.Forms.Label UDAccMLabel;
        private System.Windows.Forms.Label BFAccMLabel;
        private System.Windows.Forms.Label LRAccMLabel;
        private System.Windows.Forms.Label UDAccCLabel;
        private System.Windows.Forms.Label BFAccCLabel;
        private System.Windows.Forms.Label LRAccCLabel;
        private System.Windows.Forms.Label YawGyroCLabel;
        private System.Windows.Forms.Label RollGyroCLabel;
        private System.Windows.Forms.Label YawGyroMLabel;
        private System.Windows.Forms.Label YawCalLabel;
        private System.Windows.Forms.Label PitchGyroCLabel;
        private System.Windows.Forms.Label PitchCalLabel;
        private System.Windows.Forms.Label RollCalLabel;
        private System.Windows.Forms.Label RollGyroMLabel;
        private System.Windows.Forms.Label PitchGyroMLabel;
        private System.Windows.Forms.Label CalTRefLabel;
        private System.Windows.Forms.Label MZCalBiasLabel;
        private System.Windows.Forms.Label MYCalBiasLabel;
        private System.Windows.Forms.Label MXCalBiasLabel;
        private System.Windows.Forms.Label MZBiasLabel;
        private System.Windows.Forms.Label MXBiasLabel;
        private System.Windows.Forms.Label MYBiasLabel;
        private System.Windows.Forms.Label MZScaleLabel;
        private System.Windows.Forms.Label MXScaleLabel;
        private System.Windows.Forms.Label MYScaleLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox OffsetOriginValidBox;
        private System.Windows.Forms.TextBox FWGlideOffsetAngle;
        private System.Windows.Forms.Label FWGlideAngleOffsetLabel;
        private System.Windows.Forms.TextBox GPSsAcc;
        private System.Windows.Forms.Label GPSsAccLabel;
        private System.Windows.Forms.TextBox FWRateEnergy;
        private System.Windows.Forms.Label RateEnergyLabel;
        private System.Windows.Forms.TextBox GPScAcc;
        private System.Windows.Forms.Label GPScAccLabel;
        private System.Windows.Forms.TextBox GPSvAcc;
        private System.Windows.Forms.Label GPSvAccLabel;
        private System.Windows.Forms.TextBox CruiseThrottle;
        private System.Windows.Forms.Label CruiseThrottleLabel;
        private System.Windows.Forms.Label NyquistMargin;
        private System.Windows.Forms.Label GyroLPF;
        private System.Windows.Forms.Label AccLPF;
        private System.Windows.Forms.Label NyquistMarginLabel;
        private System.Windows.Forms.Label AccLPFLabel;
        private System.Windows.Forms.Label PitchRollGyroLabel;
        private System.Windows.Forms.CheckBox DiagnosticCheckBox;
        private System.Windows.Forms.Label YawPitchRollGyroLabel;
        private System.Windows.Forms.Label ImbalanceLabel;
        private System.Windows.Forms.Button BootLoadButton;
        private System.Windows.Forms.TextBox WPActionTextBox;
        private System.Windows.Forms.TextBox NavBox;
        private System.Windows.Forms.TextBox RTHBox;
        public System.Windows.Forms.ComboBox KMLComboBox;
        private System.Windows.Forms.Button CalibrateAccZeroButton;
        private System.Windows.Forms.Label DesiredAltitudeLabel;
        private System.Windows.Forms.TextBox AltitudeError;
        private System.Windows.Forms.TextBox TrackBaroVariance;
        private System.Windows.Forms.Label BaroVarianceLabel;
        private System.Windows.Forms.TextBox TrackAccUVariance;
        private System.Windows.Forms.Label AccVarianceLabel;
        private System.Windows.Forms.Label IMUTempLabel;
        private System.Windows.Forms.TextBox SerailBRxEntries;
        private System.Windows.Forms.TextBox SerialBTxEntries;
        private System.Windows.Forms.Label SerialBLabel;
        private System.Windows.Forms.TextBox SerialARxEntries;
        private System.Windows.Forms.TextBox SerialATxEntries;
        private System.Windows.Forms.Label SerialAlLabel;
        private System.Windows.Forms.GroupBox WhereGroupBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar SerialBRxProgressBar;
        private System.Windows.Forms.ProgressBar SerialARxProgressBar;
        private System.Windows.Forms.ProgressBar SerialBTxProgressBar;
        private System.Windows.Forms.ProgressBar SerialATxProgressBar;
        private System.Windows.Forms.Label execPercentLabel;
        private System.Windows.Forms.Label PWM1Label;
        private System.Windows.Forms.Label PWM2Label;
        private System.Windows.Forms.Label PWM3Label;
        private System.Windows.Forms.Label PWM4Label;
        private System.Windows.Forms.Label PWM5Label;
        private System.Windows.Forms.Label PWM6Label;
        private System.Windows.Forms.Label PWM7Label;
        private System.Windows.Forms.Label PWM0Label;
        private System.Windows.Forms.Label PWM8Label;
        private System.Windows.Forms.Label PWM9Label;
        private System.Windows.Forms.ProgressBar progressBarQ8;
        private System.Windows.Forms.ProgressBar progressBarQ6;
        private System.Windows.Forms.ProgressBar progressBarQ4;
        private System.Windows.Forms.ProgressBar progressBarQ2;
        private System.Windows.Forms.ProgressBar progressBarQ7;
        private System.Windows.Forms.ProgressBar progressBarQ5;
        private System.Windows.Forms.ProgressBar progressBarQ3;
        private System.Windows.Forms.ProgressBar progressBarQ1;
        private System.Windows.Forms.TextBox GPSHWVersionTextBox;
        private System.Windows.Forms.Label GPSHWVersionLabel;
        private System.Windows.Forms.TextBox GPSdTTextBox;
        private System.Windows.Forms.Label GPSdTLabel;
        private System.Windows.Forms.TextBox MagHeadingTextBox;
        private System.Windows.Forms.GroupBox RadioGroupBox;
        private System.Windows.Forms.TextBox upSNRTextBox;
        private System.Windows.Forms.Label upSNRLabel;
        private System.Windows.Forms.TextBox upRSSITextBox;
        private System.Windows.Forms.TextBox upLQTextBox;
        private System.Windows.Forms.Label upRSSILabel;
        private System.Windows.Forms.Label upLQLabel;
        private System.Windows.Forms.TextBox RCSignalLossesTextBox;
        private System.Windows.Forms.Label RCSignalLossesLabel;
        private System.Windows.Forms.TextBox RCFailsafesTextBox;
        private System.Windows.Forms.Label RCFailsafesLabel;
        private System.Windows.Forms.TextBox DCMotorsBox;
    }
}

