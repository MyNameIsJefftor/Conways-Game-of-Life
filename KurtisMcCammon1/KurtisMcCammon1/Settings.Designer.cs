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
            this.TimeSize = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BirthCell_txtpre = new KurtisMcCammon1.GraphicsPanel();
            this.DyeCell_txtpre = new KurtisMcCammon1.GraphicsPanel();
            this.LivingCell_txtpre = new KurtisMcCammon1.GraphicsPanel();
            this.BirthFontColor = new System.Windows.Forms.Button();
            this.DyingFontColor = new System.Windows.Forms.Button();
            this.LivingFontColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeadCell_pre = new KurtisMcCammon1.GraphicsPanel();
            this.LivingCell_pre = new KurtisMcCammon1.GraphicsPanel();
            this.DeadCellColor = new System.Windows.Forms.Button();
            this.LivingCellColor = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.TabPage();
            this.BorderColor_pre = new KurtisMcCammon1.GraphicsPanel();
            this.BorderColor = new System.Windows.Forms.Button();
            this.SettingsMenu.SuspendLayout();
            this.TimeSize.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(275, 340);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.Controls.Add(this.TimeSize);
            this.SettingsMenu.Controls.Add(this.Color);
            this.SettingsMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsMenu.Location = new System.Drawing.Point(12, 12);
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.SelectedIndex = 0;
            this.SettingsMenu.Size = new System.Drawing.Size(423, 326);
            this.SettingsMenu.TabIndex = 2;
            // 
            // TimeSize
            // 
            this.TimeSize.Controls.Add(this.groupBox2);
            this.TimeSize.Controls.Add(this.groupBox1);
            this.TimeSize.Location = new System.Drawing.Point(4, 22);
            this.TimeSize.Name = "TimeSize";
            this.TimeSize.Padding = new System.Windows.Forms.Padding(3);
            this.TimeSize.Size = new System.Drawing.Size(415, 300);
            this.TimeSize.TabIndex = 0;
            this.TimeSize.Text = "Color";
            this.TimeSize.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            // 
            // DyingFontColor
            // 
            this.DyingFontColor.Location = new System.Drawing.Point(7, 97);
            this.DyingFontColor.Name = "DyingFontColor";
            this.DyingFontColor.Size = new System.Drawing.Size(75, 23);
            this.DyingFontColor.TabIndex = 1;
            this.DyingFontColor.Text = "Dying Font";
            this.DyingFontColor.UseVisualStyleBackColor = true;
            // 
            // LivingFontColor
            // 
            this.LivingFontColor.Location = new System.Drawing.Point(7, 42);
            this.LivingFontColor.Name = "LivingFontColor";
            this.LivingFontColor.Size = new System.Drawing.Size(75, 23);
            this.LivingFontColor.TabIndex = 0;
            this.LivingFontColor.Text = "Living Cell";
            this.LivingFontColor.UseVisualStyleBackColor = true;
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
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(4, 22);
            this.Color.Name = "Color";
            this.Color.Padding = new System.Windows.Forms.Padding(3);
            this.Color.Size = new System.Drawing.Size(424, 371);
            this.Color.TabIndex = 1;
            this.Color.Text = "Time & Size";
            this.Color.UseVisualStyleBackColor = true;
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
            this.SettingsMenu.ResumeLayout(false);
            this.TimeSize.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TabControl SettingsMenu;
        private System.Windows.Forms.TabPage TimeSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Color;
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
    }
}