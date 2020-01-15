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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Color = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SettingsMenu.SuspendLayout();
            this.TimeSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(360, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(279, 415);
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
            this.SettingsMenu.Size = new System.Drawing.Size(432, 397);
            this.SettingsMenu.TabIndex = 2;
            // 
            // TimeSize
            // 
            this.TimeSize.Controls.Add(this.groupBox2);
            this.TimeSize.Controls.Add(this.groupBox1);
            this.TimeSize.Location = new System.Drawing.Point(4, 22);
            this.TimeSize.Name = "TimeSize";
            this.TimeSize.Padding = new System.Windows.Forms.Padding(3);
            this.TimeSize.Size = new System.Drawing.Size(424, 371);
            this.TimeSize.TabIndex = 0;
            this.TimeSize.Text = "Color";
            this.TimeSize.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 203);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cell Color";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.SettingsMenu);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Text = "Form2";
            this.SettingsMenu.ResumeLayout(false);
            this.TimeSize.ResumeLayout(false);
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}