﻿namespace LaserGRBL.UI.Forms.RasterConverter
{
	partial class SetupLaser
	{
		/// <summary> 
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Liberare le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione componenti

		/// <summary> 
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupLaser));
			this.GB = new System.Windows.Forms.GroupBox();
			this.TLP = new System.Windows.Forms.TableLayoutPanel();
			this.label26 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.LblModWhiteCode = new System.Windows.Forms.Label();
			this.LblWhatModulate = new System.Windows.Forms.Label();
			this.CbModulate = new LaserGRBL.UserControls.EnumComboBox();
			this.LblModWhite = new System.Windows.Forms.Label();
			this.LblFilling = new System.Windows.Forms.Label();
			this.LblBorders = new System.Windows.Forms.Label();
			this.LblModBlack = new System.Windows.Forms.Label();
			this.IIModWhite = new LaserGRBL.UserControls.IntegerInput.IntegerInputRanged();
			this.LblModBlackCode = new System.Windows.Forms.Label();
			this.IIModBlack = new LaserGRBL.UserControls.IntegerInput.IntegerInputRanged();
			this.LblBorderUM = new System.Windows.Forms.Label();
			this.IIBorder = new LaserGRBL.UserControls.IntegerInput.IntegerInputRanged();
			this.LblBorderCode = new System.Windows.Forms.Label();
			this.LblFillingCode = new System.Windows.Forms.Label();
			this.IIFilling = new LaserGRBL.UserControls.IntegerInput.IntegerInputRanged();
			this.LblFillingUM = new System.Windows.Forms.Label();
			this.CBLaserON = new System.Windows.Forms.ComboBox();
			this.CBLaserOFF = new System.Windows.Forms.ComboBox();
			this.BtnOnOffInfo = new LaserGRBL.UserControls.ImageButton();
			this.BtnModulationInfo = new LaserGRBL.UserControls.ImageButton();
			this.LblModWhiteUM = new System.Windows.Forms.Label();
			this.LblModBlackUM = new System.Windows.Forms.Label();
			this.PbLink = new System.Windows.Forms.PictureBox();
			this.LblPower = new System.Windows.Forms.Label();
			this.LblPowerCode = new System.Windows.Forms.Label();
			this.IIPower = new LaserGRBL.UserControls.IntegerInput.IntegerInputRanged();
			this.LblPowerUM = new System.Windows.Forms.Label();
			this.GB.SuspendLayout();
			this.TLP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbLink)).BeginInit();
			this.SuspendLayout();
			// 
			// GB
			// 
			this.GB.AutoSize = true;
			this.GB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GB.Controls.Add(this.TLP);
			this.GB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GB.Location = new System.Drawing.Point(0, 0);
			this.GB.Name = "GB";
			this.GB.Size = new System.Drawing.Size(195, 203);
			this.GB.TabIndex = 3;
			this.GB.TabStop = false;
			this.GB.Text = "Laser";
			// 
			// TLP
			// 
			this.TLP.AutoSize = true;
			this.TLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TLP.ColumnCount = 5;
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.Controls.Add(this.LblPowerUM, 4, 3);
			this.TLP.Controls.Add(this.IIPower, 3, 3);
			this.TLP.Controls.Add(this.LblPowerCode, 2, 3);
			this.TLP.Controls.Add(this.LblPower, 0, 3);
			this.TLP.Controls.Add(this.label26, 0, 7);
			this.TLP.Controls.Add(this.label18, 0, 6);
			this.TLP.Controls.Add(this.LblModWhiteCode, 2, 1);
			this.TLP.Controls.Add(this.LblWhatModulate, 0, 0);
			this.TLP.Controls.Add(this.CbModulate, 2, 0);
			this.TLP.Controls.Add(this.LblModWhite, 0, 1);
			this.TLP.Controls.Add(this.LblFilling, 0, 5);
			this.TLP.Controls.Add(this.LblBorders, 0, 4);
			this.TLP.Controls.Add(this.LblModBlack, 0, 2);
			this.TLP.Controls.Add(this.IIModWhite, 3, 1);
			this.TLP.Controls.Add(this.LblModBlackCode, 2, 2);
			this.TLP.Controls.Add(this.IIModBlack, 3, 2);
			this.TLP.Controls.Add(this.LblBorderUM, 4, 4);
			this.TLP.Controls.Add(this.IIBorder, 3, 4);
			this.TLP.Controls.Add(this.LblBorderCode, 2, 4);
			this.TLP.Controls.Add(this.LblFillingCode, 2, 5);
			this.TLP.Controls.Add(this.IIFilling, 3, 5);
			this.TLP.Controls.Add(this.LblFillingUM, 4, 5);
			this.TLP.Controls.Add(this.CBLaserON, 2, 6);
			this.TLP.Controls.Add(this.CBLaserOFF, 2, 7);
			this.TLP.Controls.Add(this.BtnOnOffInfo, 4, 6);
			this.TLP.Controls.Add(this.BtnModulationInfo, 4, 7);
			this.TLP.Controls.Add(this.LblModWhiteUM, 4, 1);
			this.TLP.Controls.Add(this.LblModBlackUM, 4, 2);
			this.TLP.Controls.Add(this.PbLink, 1, 0);
			this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TLP.Location = new System.Drawing.Point(3, 16);
			this.TLP.Name = "TLP";
			this.TLP.RowCount = 8;
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TLP.Size = new System.Drawing.Size(189, 184);
			this.TLP.TabIndex = 0;
			// 
			// label26
			// 
			this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label26.AutoSize = true;
			this.TLP.SetColumnSpan(this.label26, 2);
			this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label26.Location = new System.Drawing.Point(3, 164);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(56, 13);
			this.label26.TabIndex = 21;
			this.label26.Text = "Laser OFF";
			// 
			// label18
			// 
			this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label18.AutoSize = true;
			this.TLP.SetColumnSpan(this.label18, 2);
			this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label18.Location = new System.Drawing.Point(3, 137);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(52, 13);
			this.label18.TabIndex = 19;
			this.label18.Text = "Laser ON";
			// 
			// LblModWhiteCode
			// 
			this.LblModWhiteCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblModWhiteCode.AutoSize = true;
			this.LblModWhiteCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblModWhiteCode.Location = new System.Drawing.Point(67, 29);
			this.LblModWhiteCode.Margin = new System.Windows.Forms.Padding(0);
			this.LblModWhiteCode.Name = "LblModWhiteCode";
			this.LblModWhiteCode.Size = new System.Drawing.Size(14, 13);
			this.LblModWhiteCode.TabIndex = 26;
			this.LblModWhiteCode.Text = "S";
			// 
			// LblWhatModulate
			// 
			this.LblWhatModulate.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblWhatModulate.AutoSize = true;
			this.LblWhatModulate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblWhatModulate.Location = new System.Drawing.Point(3, 6);
			this.LblWhatModulate.Name = "LblWhatModulate";
			this.LblWhatModulate.Size = new System.Drawing.Size(51, 13);
			this.LblWhatModulate.TabIndex = 25;
			this.LblWhatModulate.Text = "Modulate";
			// 
			// CbModulate
			// 
			this.TLP.SetColumnSpan(this.CbModulate, 3);
			this.CbModulate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbModulate.FormattingEnabled = true;
			this.CbModulate.Location = new System.Drawing.Point(69, 2);
			this.CbModulate.Margin = new System.Windows.Forms.Padding(2);
			this.CbModulate.Name = "CbModulate";
			this.CbModulate.SelectedItem = null;
			this.CbModulate.Size = new System.Drawing.Size(107, 21);
			this.CbModulate.TabIndex = 24;
			this.CbModulate.SelectedIndexChanged += new System.EventHandler(this.CbModulate_SelectedIndexChanged);
			// 
			// LblModWhite
			// 
			this.LblModWhite.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblModWhite.AutoSize = true;
			this.LblModWhite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblModWhite.Location = new System.Drawing.Point(3, 29);
			this.LblModWhite.Name = "LblModWhite";
			this.LblModWhite.Size = new System.Drawing.Size(35, 13);
			this.LblModWhite.TabIndex = 13;
			this.LblModWhite.Text = "White";
			// 
			// LblFilling
			// 
			this.LblFilling.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblFilling.AutoSize = true;
			this.TLP.SetColumnSpan(this.LblFilling, 2);
			this.LblFilling.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblFilling.Location = new System.Drawing.Point(3, 113);
			this.LblFilling.Name = "LblFilling";
			this.LblFilling.Size = new System.Drawing.Size(33, 13);
			this.LblFilling.TabIndex = 13;
			this.LblFilling.Text = "Filling";
			// 
			// LblBorders
			// 
			this.LblBorders.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblBorders.AutoSize = true;
			this.TLP.SetColumnSpan(this.LblBorders, 2);
			this.LblBorders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblBorders.Location = new System.Drawing.Point(3, 92);
			this.LblBorders.Name = "LblBorders";
			this.LblBorders.Size = new System.Drawing.Size(38, 13);
			this.LblBorders.TabIndex = 23;
			this.LblBorders.Text = "Border";
			// 
			// LblModBlack
			// 
			this.LblModBlack.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblModBlack.AutoSize = true;
			this.LblModBlack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblModBlack.Location = new System.Drawing.Point(3, 50);
			this.LblModBlack.Name = "LblModBlack";
			this.LblModBlack.Size = new System.Drawing.Size(34, 13);
			this.LblModBlack.TabIndex = 17;
			this.LblModBlack.Text = "Black";
			// 
			// IIModWhite
			// 
			this.IIModWhite.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.IIModWhite.ForcedText = null;
			this.IIModWhite.ForceMinMax = false;
			this.IIModWhite.Location = new System.Drawing.Point(84, 28);
			this.IIModWhite.MaxValue = 999;
			this.IIModWhite.MinValue = 0;
			this.IIModWhite.Name = "IIModWhite";
			this.IIModWhite.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.IIModWhite.Size = new System.Drawing.Size(52, 15);
			this.IIModWhite.TabIndex = 11;
			// 
			// LblModBlackCode
			// 
			this.LblModBlackCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblModBlackCode.AutoSize = true;
			this.LblModBlackCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblModBlackCode.Location = new System.Drawing.Point(67, 50);
			this.LblModBlackCode.Margin = new System.Windows.Forms.Padding(0);
			this.LblModBlackCode.Name = "LblModBlackCode";
			this.LblModBlackCode.Size = new System.Drawing.Size(14, 13);
			this.LblModBlackCode.TabIndex = 27;
			this.LblModBlackCode.Text = "S";
			// 
			// IIModBlack
			// 
			this.IIModBlack.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.IIModBlack.CurrentValue = 255;
			this.IIModBlack.ForcedText = null;
			this.IIModBlack.ForceMinMax = false;
			this.IIModBlack.Location = new System.Drawing.Point(84, 49);
			this.IIModBlack.MaxValue = 1000;
			this.IIModBlack.MinValue = 1;
			this.IIModBlack.Name = "IIModBlack";
			this.IIModBlack.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.IIModBlack.Size = new System.Drawing.Size(52, 15);
			this.IIModBlack.TabIndex = 12;
			// 
			// LblBorderUM
			// 
			this.LblBorderUM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblBorderUM.AutoSize = true;
			this.LblBorderUM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblBorderUM.Location = new System.Drawing.Point(142, 92);
			this.LblBorderUM.Name = "LblBorderUM";
			this.LblBorderUM.Size = new System.Drawing.Size(44, 13);
			this.LblBorderUM.TabIndex = 22;
			this.LblBorderUM.Text = "mm/min";
			// 
			// IIBorder
			// 
			this.IIBorder.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.IIBorder.CurrentValue = 1000;
			this.IIBorder.ForcedText = null;
			this.IIBorder.ForceMinMax = false;
			this.IIBorder.Location = new System.Drawing.Point(84, 91);
			this.IIBorder.MaxValue = 4000;
			this.IIBorder.MinValue = 1;
			this.IIBorder.Name = "IIBorder";
			this.IIBorder.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.IIBorder.Size = new System.Drawing.Size(52, 15);
			this.IIBorder.TabIndex = 6;
			// 
			// LblBorderCode
			// 
			this.LblBorderCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblBorderCode.AutoSize = true;
			this.LblBorderCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblBorderCode.Location = new System.Drawing.Point(67, 92);
			this.LblBorderCode.Margin = new System.Windows.Forms.Padding(0);
			this.LblBorderCode.Name = "LblBorderCode";
			this.LblBorderCode.Size = new System.Drawing.Size(13, 13);
			this.LblBorderCode.TabIndex = 28;
			this.LblBorderCode.Text = "F";
			// 
			// LblFillingCode
			// 
			this.LblFillingCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblFillingCode.AutoSize = true;
			this.LblFillingCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblFillingCode.Location = new System.Drawing.Point(67, 113);
			this.LblFillingCode.Margin = new System.Windows.Forms.Padding(0);
			this.LblFillingCode.Name = "LblFillingCode";
			this.LblFillingCode.Size = new System.Drawing.Size(13, 13);
			this.LblFillingCode.TabIndex = 29;
			this.LblFillingCode.Text = "F";
			// 
			// IIFilling
			// 
			this.IIFilling.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.IIFilling.CurrentValue = 1000;
			this.IIFilling.ForcedText = null;
			this.IIFilling.ForceMinMax = false;
			this.IIFilling.Location = new System.Drawing.Point(84, 112);
			this.IIFilling.MaxValue = 4000;
			this.IIFilling.MinValue = 1;
			this.IIFilling.Name = "IIFilling";
			this.IIFilling.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.IIFilling.Size = new System.Drawing.Size(52, 15);
			this.IIFilling.TabIndex = 7;
			// 
			// LblFillingUM
			// 
			this.LblFillingUM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblFillingUM.AutoSize = true;
			this.LblFillingUM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblFillingUM.Location = new System.Drawing.Point(142, 113);
			this.LblFillingUM.Name = "LblFillingUM";
			this.LblFillingUM.Size = new System.Drawing.Size(44, 13);
			this.LblFillingUM.TabIndex = 15;
			this.LblFillingUM.Text = "mm/min";
			// 
			// CBLaserON
			// 
			this.TLP.SetColumnSpan(this.CBLaserON, 2);
			this.CBLaserON.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CBLaserON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBLaserON.FormattingEnabled = true;
			this.CBLaserON.Items.AddRange(new object[] {
            "M3",
            "M4"});
			this.CBLaserON.Location = new System.Drawing.Point(70, 133);
			this.CBLaserON.Name = "CBLaserON";
			this.CBLaserON.Size = new System.Drawing.Size(66, 21);
			this.CBLaserON.TabIndex = 24;
			// 
			// CBLaserOFF
			// 
			this.TLP.SetColumnSpan(this.CBLaserOFF, 2);
			this.CBLaserOFF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CBLaserOFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBLaserOFF.FormattingEnabled = true;
			this.CBLaserOFF.Items.AddRange(new object[] {
            "M5"});
			this.CBLaserOFF.Location = new System.Drawing.Point(70, 160);
			this.CBLaserOFF.Name = "CBLaserOFF";
			this.CBLaserOFF.Size = new System.Drawing.Size(66, 21);
			this.CBLaserOFF.TabIndex = 25;
			// 
			// BtnOnOffInfo
			// 
			this.BtnOnOffInfo.AltImage = null;
			this.BtnOnOffInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnOnOffInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnOnOffInfo.Coloration = System.Drawing.Color.Empty;
			this.BtnOnOffInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnOnOffInfo.Image")));
			this.BtnOnOffInfo.Location = new System.Drawing.Point(142, 135);
			this.BtnOnOffInfo.Name = "BtnOnOffInfo";
			this.BtnOnOffInfo.Size = new System.Drawing.Size(17, 17);
			this.BtnOnOffInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
			this.BtnOnOffInfo.TabIndex = 22;
			this.BtnOnOffInfo.UseAltImage = false;
			// 
			// BtnModulationInfo
			// 
			this.BtnModulationInfo.AltImage = null;
			this.BtnModulationInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnModulationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnModulationInfo.Coloration = System.Drawing.Color.Empty;
			this.BtnModulationInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnModulationInfo.Image")));
			this.BtnModulationInfo.Location = new System.Drawing.Point(142, 162);
			this.BtnModulationInfo.Name = "BtnModulationInfo";
			this.BtnModulationInfo.Size = new System.Drawing.Size(17, 17);
			this.BtnModulationInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
			this.BtnModulationInfo.TabIndex = 23;
			this.BtnModulationInfo.UseAltImage = false;
			// 
			// LblModWhiteUM
			// 
			this.LblModWhiteUM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblModWhiteUM.AutoSize = true;
			this.LblModWhiteUM.Location = new System.Drawing.Point(142, 29);
			this.LblModWhiteUM.Name = "LblModWhiteUM";
			this.LblModWhiteUM.Size = new System.Drawing.Size(34, 13);
			this.LblModWhiteUM.TabIndex = 30;
			this.LblModWhiteUM.Text = "PWM";
			// 
			// LblModBlackUM
			// 
			this.LblModBlackUM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblModBlackUM.AutoSize = true;
			this.LblModBlackUM.Location = new System.Drawing.Point(142, 50);
			this.LblModBlackUM.Name = "LblModBlackUM";
			this.LblModBlackUM.Size = new System.Drawing.Size(34, 13);
			this.LblModBlackUM.TabIndex = 31;
			this.LblModBlackUM.Text = "PWM";
			// 
			// PbLink
			// 
			this.PbLink.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PbLink.Image = ((System.Drawing.Image)(resources.GetObject("PbLink.Image")));
			this.PbLink.Location = new System.Drawing.Point(57, 3);
			this.PbLink.Margin = new System.Windows.Forms.Padding(0);
			this.PbLink.Name = "PbLink";
			this.TLP.SetRowSpan(this.PbLink, 3);
			this.PbLink.Size = new System.Drawing.Size(10, 61);
			this.PbLink.TabIndex = 32;
			this.PbLink.TabStop = false;
			// 
			// LblPower
			// 
			this.LblPower.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblPower.AutoSize = true;
			this.LblPower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblPower.Location = new System.Drawing.Point(3, 71);
			this.LblPower.Name = "LblPower";
			this.LblPower.Size = new System.Drawing.Size(37, 13);
			this.LblPower.TabIndex = 33;
			this.LblPower.Text = "Power";
			// 
			// LblPowerCode
			// 
			this.LblPowerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblPowerCode.AutoSize = true;
			this.LblPowerCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LblPowerCode.Location = new System.Drawing.Point(67, 71);
			this.LblPowerCode.Margin = new System.Windows.Forms.Padding(0);
			this.LblPowerCode.Name = "LblPowerCode";
			this.LblPowerCode.Size = new System.Drawing.Size(14, 13);
			this.LblPowerCode.TabIndex = 34;
			this.LblPowerCode.Text = "S";
			// 
			// IIPower
			// 
			this.IIPower.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.IIPower.CurrentValue = 255;
			this.IIPower.ForcedText = null;
			this.IIPower.ForceMinMax = false;
			this.IIPower.Location = new System.Drawing.Point(84, 70);
			this.IIPower.MaxValue = 1000;
			this.IIPower.MinValue = 1;
			this.IIPower.Name = "IIPower";
			this.IIPower.NormalBorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.IIPower.Size = new System.Drawing.Size(52, 15);
			this.IIPower.TabIndex = 35;
			// 
			// LblPowerUM
			// 
			this.LblPowerUM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LblPowerUM.AutoSize = true;
			this.LblPowerUM.Location = new System.Drawing.Point(142, 71);
			this.LblPowerUM.Name = "LblPowerUM";
			this.LblPowerUM.Size = new System.Drawing.Size(34, 13);
			this.LblPowerUM.TabIndex = 36;
			this.LblPowerUM.Text = "PWM";
			// 
			// SetupLaser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.GB);
			this.Name = "SetupLaser";
			this.Size = new System.Drawing.Size(195, 203);
			this.GB.ResumeLayout(false);
			this.GB.PerformLayout();
			this.TLP.ResumeLayout(false);
			this.TLP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbLink)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox GB;
		private System.Windows.Forms.TableLayoutPanel TLP;
		private System.Windows.Forms.Label LblBorders;
		private System.Windows.Forms.Label LblBorderUM;
		private UserControls.IntegerInput.IntegerInputRanged IIBorder;
		private UserControls.IntegerInput.IntegerInputRanged IIFilling;
		private System.Windows.Forms.Label LblFillingUM;
		private System.Windows.Forms.Label LblFilling;
		private UserControls.ImageButton BtnModulationInfo;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label LblModBlack;
		private UserControls.IntegerInput.IntegerInputRanged IIModBlack;
		private System.Windows.Forms.Label label18;
		private UserControls.ImageButton BtnOnOffInfo;
		private System.Windows.Forms.ComboBox CBLaserON;
		private System.Windows.Forms.ComboBox CBLaserOFF;
		private System.Windows.Forms.Label LblWhatModulate;
		private UserControls.EnumComboBox CbModulate;
		private System.Windows.Forms.Label LblModBlackCode;
		private System.Windows.Forms.Label LblBorderCode;
		private System.Windows.Forms.Label LblFillingCode;
		private System.Windows.Forms.Label LblModBlackUM;
		private System.Windows.Forms.PictureBox PbLink;
		private System.Windows.Forms.Label LblModWhiteCode;
		private System.Windows.Forms.Label LblModWhite;
		private UserControls.IntegerInput.IntegerInputRanged IIModWhite;
		private System.Windows.Forms.Label LblModWhiteUM;
		private System.Windows.Forms.Label LblPower;
		private System.Windows.Forms.Label LblPowerCode;
		private System.Windows.Forms.Label LblPowerUM;
		private UserControls.IntegerInput.IntegerInputRanged IIPower;

	}
}
