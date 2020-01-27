namespace KurtisMcCammon1
{
    partial class Settings
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.SettingsMenu = new System.Windows.Forms.TabControl();
            this._Color = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeadFont_pre = new KurtisMcCammon1.GraphicsPanel();
            this.DeadFont = new System.Windows.Forms.Button();
            this.BirthCell_txtpre = new KurtisMcCammon1.GraphicsPanel();
            this.DyeCell_txtpre = new KurtisMcCammon1.GraphicsPanel();
            this.LivingCell_txtpre = new KurtisMcCammon1.GraphicsPanel();
            this.BirthFontColor = new System.Windows.Forms.Button();
            this.DyingFontColor = new System.Windows.Forms.Button();
            this.LivingFontColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BorderColor_pre = new KurtisMcCammon1.GraphicsPanel();
            this.BorderColor = new System.Windows.Forms.Button();
            this.DeadCell_pre = new KurtisMcCammon1.GraphicsPanel();
            this.LivingCell_pre = new KurtisMcCammon1.GraphicsPanel();
            this.DeadCellColor = new System.Windows.Forms.Button();
            this.LivingCellColor = new System.Windows.Forms.Button();
            this._UniverseControl = new System.Windows.Forms.TabPage();
            this._NeighborState = new System.Windows.Forms.CheckBox();
            this._ReloadSettings = new System.Windows.Forms.Button();
            this._ResetSettings = new System.Windows.Forms.Button();
            this._GridOn = new System.Windows.Forms.CheckBox();
            this.Height = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._Toroidal = new System.Windows.Forms.CheckBox();
            this._Speed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._SetTickSpeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._SetUY = new System.Windows.Forms.Button();
            this._UWidth = new System.Windows.Forms.NumericUpDown();
            this._UHeight = new System.Windows.Forms.NumericUpDown();
            this.SettingsMenu.SuspendLayout();
            this._Color.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._UniverseControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._UWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._UHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(356, 340);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(275, 340);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.Controls.Add(this._Color);
            this.SettingsMenu.Controls.Add(this._UniverseControl);
            this.SettingsMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsMenu.Location = new System.Drawing.Point(12, 12);
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.SelectedIndex = 0;
            this.SettingsMenu.Size = new System.Drawing.Size(423, 326);
            this.SettingsMenu.TabIndex = 2;
            // 
            // _Color
            // 
            this._Color.Controls.Add(this.groupBox2);
            this._Color.Controls.Add(this.groupBox1);
            this._Color.Location = new System.Drawing.Point(4, 22);
            this._Color.Name = "_Color";
            this._Color.Padding = new System.Windows.Forms.Padding(3);
            this._Color.Size = new System.Drawing.Size(415, 300);
            this._Color.TabIndex = 0;
            this._Color.Text = "Color";
            this._Color.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeadFont_pre);
            this.groupBox2.Controls.Add(this.DeadFont);
            this.groupBox2.Controls.Add(this.BirthCell_txtpre);
            this.groupBox2.Controls.Add(this.DyeCell_txtpre);
            this.groupBox2.Controls.Add(this.LivingCell_txtpre);
            this.groupBox2.Controls.Add(this.BirthFontColor);
            this.groupBox2.Controls.Add(this.DyingFontColor);
            this.groupBox2.Controls.Add(this.LivingFontColor);
            this.groupBox2.Location = new System.Drawing.Point(0, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Color";
            // 
            // DeadFont_pre
            // 
            this.DeadFont_pre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeadFont_pre.Location = new System.Drawing.Point(284, 97);
            this.DeadFont_pre.Name = "DeadFont_pre";
            this.DeadFont_pre.Size = new System.Drawing.Size(23, 23);
            this.DeadFont_pre.TabIndex = 5;
            // 
            // DeadFont
            // 
            this.DeadFont.Location = new System.Drawing.Point(186, 97);
            this.DeadFont.Name = "DeadFont";
            this.DeadFont.Size = new System.Drawing.Size(75, 23);
            this.DeadFont.TabIndex = 4;
            this.DeadFont.Text = "Dead Font";
            this.DeadFont.UseVisualStyleBackColor = true;
            this.DeadFont.Click += new System.EventHandler(this.DeadFont_Click);
            // 
            // BirthCell_txtpre
            // 
            this.BirthCell_txtpre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BirthCell_txtpre.Location = new System.Drawing.Point(284, 42);
            this.BirthCell_txtpre.Name = "BirthCell_txtpre";
            this.BirthCell_txtpre.Size = new System.Drawing.Size(23, 23);
            this.BirthCell_txtpre.TabIndex = 3;
            // 
            // DyeCell_txtpre
            // 
            this.DyeCell_txtpre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DyeCell_txtpre.Location = new System.Drawing.Point(105, 97);
            this.DyeCell_txtpre.Name = "DyeCell_txtpre";
            this.DyeCell_txtpre.Size = new System.Drawing.Size(23, 23);
            this.DyeCell_txtpre.TabIndex = 3;
            // 
            // LivingCell_txtpre
            // 
            this.LivingCell_txtpre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LivingCell_txtpre.Location = new System.Drawing.Point(105, 42);
            this.LivingCell_txtpre.Name = "LivingCell_txtpre";
            this.LivingCell_txtpre.Size = new System.Drawing.Size(23, 23);
            this.LivingCell_txtpre.TabIndex = 3;
            // 
            // BirthFontColor
            // 
            this.BirthFontColor.Location = new System.Drawing.Point(186, 42);
            this.BirthFontColor.Name = "BirthFontColor";
            this.BirthFontColor.Size = new System.Drawing.Size(75, 23);
            this.BirthFontColor.TabIndex = 2;
            this.BirthFontColor.Text = "Birth Font";
            this.BirthFontColor.UseVisualStyleBackColor = true;
            this.BirthFontColor.Click += new System.EventHandler(this.BirthFontColor_Click);
            // 
            // DyingFontColor
            // 
            this.DyingFontColor.Location = new System.Drawing.Point(7, 97);
            this.DyingFontColor.Name = "DyingFontColor";
            this.DyingFontColor.Size = new System.Drawing.Size(75, 23);
            this.DyingFontColor.TabIndex = 1;
            this.DyingFontColor.Text = "Dying Font";
            this.DyingFontColor.UseVisualStyleBackColor = true;
            this.DyingFontColor.Click += new System.EventHandler(this.DyingFontColor_Click);
            // 
            // LivingFontColor
            // 
            this.LivingFontColor.Location = new System.Drawing.Point(7, 42);
            this.LivingFontColor.Name = "LivingFontColor";
            this.LivingFontColor.Size = new System.Drawing.Size(75, 23);
            this.LivingFontColor.TabIndex = 0;
            this.LivingFontColor.Text = "Living Cell";
            this.LivingFontColor.UseVisualStyleBackColor = true;
            this.LivingFontColor.Click += new System.EventHandler(this.LivingFontColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BorderColor_pre);
            this.groupBox1.Controls.Add(this.BorderColor);
            this.groupBox1.Controls.Add(this.DeadCell_pre);
            this.groupBox1.Controls.Add(this.LivingCell_pre);
            this.groupBox1.Controls.Add(this.DeadCellColor);
            this.groupBox1.Controls.Add(this.LivingCellColor);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cell Color";
            // 
            // BorderColor_pre
            // 
            this.BorderColor_pre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BorderColor_pre.Location = new System.Drawing.Point(284, 35);
            this.BorderColor_pre.Name = "BorderColor_pre";
            this.BorderColor_pre.Size = new System.Drawing.Size(23, 23);
            this.BorderColor_pre.TabIndex = 5;
            // 
            // BorderColor
            // 
            this.BorderColor.Location = new System.Drawing.Point(186, 35);
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(75, 23);
            this.BorderColor.TabIndex = 4;
            this.BorderColor.Text = "Border";
            this.BorderColor.UseVisualStyleBackColor = true;
            this.BorderColor.Click += new System.EventHandler(this.BorderColor_Click);
            // 
            // DeadCell_pre
            // 
            this.DeadCell_pre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeadCell_pre.Location = new System.Drawing.Point(105, 96);
            this.DeadCell_pre.Name = "DeadCell_pre";
            this.DeadCell_pre.Size = new System.Drawing.Size(23, 23);
            this.DeadCell_pre.TabIndex = 3;
            // 
            // LivingCell_pre
            // 
            this.LivingCell_pre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LivingCell_pre.Location = new System.Drawing.Point(105, 35);
            this.LivingCell_pre.Name = "LivingCell_pre";
            this.LivingCell_pre.Size = new System.Drawing.Size(23, 23);
            this.LivingCell_pre.TabIndex = 2;
            // 
            // DeadCellColor
            // 
            this.DeadCellColor.Location = new System.Drawing.Point(7, 96);
            this.DeadCellColor.Name = "DeadCellColor";
            this.DeadCellColor.Size = new System.Drawing.Size(75, 23);
            this.DeadCellColor.TabIndex = 1;
            this.DeadCellColor.Text = "Dead Cell";
            this.DeadCellColor.UseVisualStyleBackColor = true;
            this.DeadCellColor.Click += new System.EventHandler(this.DeadCellColor_Click);
            // 
            // LivingCellColor
            // 
            this.LivingCellColor.Location = new System.Drawing.Point(6, 35);
            this.LivingCellColor.Name = "LivingCellColor";
            this.LivingCellColor.Size = new System.Drawing.Size(75, 23);
            this.LivingCellColor.TabIndex = 0;
            this.LivingCellColor.Text = "Living Cell";
            this.LivingCellColor.UseVisualStyleBackColor = true;
            this.LivingCellColor.Click += new System.EventHandler(this.LivingCellColor_Click);
            // 
            // _UniverseControl
            // 
            this._UniverseControl.Controls.Add(this._NeighborState);
            this._UniverseControl.Controls.Add(this._ReloadSettings);
            this._UniverseControl.Controls.Add(this._ResetSettings);
            this._UniverseControl.Controls.Add(this._GridOn);
            this._UniverseControl.Controls.Add(this.Height);
            this._UniverseControl.Controls.Add(this.label3);
            this._UniverseControl.Controls.Add(this._Toroidal);
            this._UniverseControl.Controls.Add(this._Speed);
            this._UniverseControl.Controls.Add(this.label2);
            this._UniverseControl.Controls.Add(this._SetTickSpeed);
            this._UniverseControl.Controls.Add(this.label1);
            this._UniverseControl.Controls.Add(this._SetUY);
            this._UniverseControl.Controls.Add(this._UWidth);
            this._UniverseControl.Controls.Add(this._UHeight);
            this._UniverseControl.Location = new System.Drawing.Point(4, 22);
            this._UniverseControl.Name = "_UniverseControl";
            this._UniverseControl.Padding = new System.Windows.Forms.Padding(3);
            this._UniverseControl.Size = new System.Drawing.Size(415, 300);
            this._UniverseControl.TabIndex = 1;
            this._UniverseControl.Text = "Universe";
            this._UniverseControl.UseVisualStyleBackColor = true;
            // 
            // _NeighborState
            // 
            this._NeighborState.AutoSize = true;
            this._NeighborState.Location = new System.Drawing.Point(9, 226);
            this._NeighborState.Name = "_NeighborState";
            this._NeighborState.Size = new System.Drawing.Size(117, 17);
            this._NeighborState.TabIndex = 14;
            this._NeighborState.Text = "Neighbor Count On";
            this._NeighborState.UseVisualStyleBackColor = true;
            // 
            // _ReloadSettings
            // 
            this._ReloadSettings.Location = new System.Drawing.Point(304, 242);
            this._ReloadSettings.Name = "_ReloadSettings";
            this._ReloadSettings.Size = new System.Drawing.Size(105, 23);
            this._ReloadSettings.TabIndex = 13;
            this._ReloadSettings.Text = "Reload Settings";
            this._ReloadSettings.UseVisualStyleBackColor = true;
            this._ReloadSettings.Click += new System.EventHandler(this._ReloadSettings_Click);
            // 
            // _ResetSettings
            // 
            this._ResetSettings.Location = new System.Drawing.Point(304, 271);
            this._ResetSettings.Name = "_ResetSettings";
            this._ResetSettings.Size = new System.Drawing.Size(105, 23);
            this._ResetSettings.TabIndex = 12;
            this._ResetSettings.Text = "Reset Settings";
            this._ResetSettings.UseVisualStyleBackColor = true;
            this._ResetSettings.Click += new System.EventHandler(this._ResetSettings_Click);
            // 
            // _GridOn
            // 
            this._GridOn.AutoSize = true;
            this._GridOn.Location = new System.Drawing.Point(9, 203);
            this._GridOn.Name = "_GridOn";
            this._GridOn.Size = new System.Drawing.Size(62, 17);
            this._GridOn.TabIndex = 11;
            this._GridOn.Text = "Grid On";
            this._GridOn.UseVisualStyleBackColor = true;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(96, 29);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(35, 13);
            this.Height.TabIndex = 10;
            this.Height.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // _Toroidal
            // 
            this._Toroidal.AutoSize = true;
            this._Toroidal.Location = new System.Drawing.Point(9, 180);
            this._Toroidal.Name = "_Toroidal";
            this._Toroidal.Size = new System.Drawing.Size(70, 17);
            this._Toroidal.TabIndex = 8;
            this._Toroidal.Text = "Toroidal?";
            this._Toroidal.UseVisualStyleBackColor = true;
            // 
            // _Speed
            // 
            this._Speed.Location = new System.Drawing.Point(96, 124);
            this._Speed.Maximum = new decimal(new int[] {
            -1474836480,
            4,
            0,
            0});
            this._Speed.Name = "_Speed";
            this._Speed.Size = new System.Drawing.Size(87, 20);
            this._Speed.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set the Tickspeed ( in milliseconds )";
            // 
            // _SetTickSpeed
            // 
            this._SetTickSpeed.Location = new System.Drawing.Point(7, 124);
            this._SetTickSpeed.Name = "_SetTickSpeed";
            this._SetTickSpeed.Size = new System.Drawing.Size(75, 23);
            this._SetTickSpeed.TabIndex = 5;
            this._SetTickSpeed.Text = "Set";
            this._SetTickSpeed.UseVisualStyleBackColor = true;
            this._SetTickSpeed.Click += new System.EventHandler(this._SetTickSpeed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set the Universe Width and Height";
            // 
            // _SetUY
            // 
            this._SetUY.Location = new System.Drawing.Point(6, 67);
            this._SetUY.Name = "_SetUY";
            this._SetUY.Size = new System.Drawing.Size(75, 23);
            this._SetUY.TabIndex = 3;
            this._SetUY.Text = "Set";
            this._SetUY.UseVisualStyleBackColor = true;
            this._SetUY.Click += new System.EventHandler(this._SetUniverse);
            // 
            // _UWidth
            // 
            this._UWidth.Location = new System.Drawing.Point(6, 45);
            this._UWidth.Name = "_UWidth";
            this._UWidth.Size = new System.Drawing.Size(87, 20);
            this._UWidth.TabIndex = 1;
            // 
            // _UHeight
            // 
            this._UHeight.Location = new System.Drawing.Point(99, 45);
            this._UHeight.Name = "_UHeight";
            this._UHeight.Size = new System.Drawing.Size(87, 20);
            this._UHeight.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 373);
            this.Controls.Add(this.SettingsMenu);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.SettingsMenu.ResumeLayout(false);
            this._Color.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this._UniverseControl.ResumeLayout(false);
            this._UniverseControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._UWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._UHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TabControl SettingsMenu;
        private System.Windows.Forms.TabPage _Color;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage _UniverseControl;
        private System.Windows.Forms.Button DeadCellColor;
        private System.Windows.Forms.Button LivingCellColor;
        private System.Windows.Forms.Button BirthFontColor;
        private System.Windows.Forms.Button DyingFontColor;
        private System.Windows.Forms.Button LivingFontColor;
        private GraphicsPanel BirthCell_txtpre;
        private GraphicsPanel DyeCell_txtpre;
        private GraphicsPanel LivingCell_txtpre;
        private GraphicsPanel DeadCell_pre;
        private GraphicsPanel LivingCell_pre;
        private GraphicsPanel BorderColor_pre;
        private System.Windows.Forms.Button BorderColor;
        private System.Windows.Forms.NumericUpDown _UWidth;
        private System.Windows.Forms.NumericUpDown _UHeight;
        private System.Windows.Forms.Button _SetUY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _SetTickSpeed;
        private System.Windows.Forms.NumericUpDown _Speed;
        private System.Windows.Forms.CheckBox _Toroidal;
        private GraphicsPanel DeadFont_pre;
        private System.Windows.Forms.Button DeadFont;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox _GridOn;
        private System.Windows.Forms.Button _ResetSettings;
        private System.Windows.Forms.Button _ReloadSettings;
        private System.Windows.Forms.CheckBox _NeighborState;
    }
}