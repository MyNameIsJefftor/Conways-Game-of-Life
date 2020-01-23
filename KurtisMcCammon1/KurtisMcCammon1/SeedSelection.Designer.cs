namespace KurtisMcCammon1
{
    partial class SeedSelection
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
            this._UserSeedInput = new System.Windows.Forms.NumericUpDown();
            this._UserSeed = new System.Windows.Forms.RadioButton();
            this._SeedTime = new System.Windows.Forms.RadioButton();
            this._Apply = new System.Windows.Forms.Button();
            this._Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._UserSeedInput)).BeginInit();
            this.SuspendLayout();
            // 
            // _UserSeedInput
            // 
            this._UserSeedInput.Location = new System.Drawing.Point(127, 35);
            this._UserSeedInput.Maximum = new decimal(new int[] {
            552894464,
            46566,
            0,
            0});
            this._UserSeedInput.Name = "_UserSeedInput";
            this._UserSeedInput.Size = new System.Drawing.Size(101, 20);
            this._UserSeedInput.TabIndex = 0;
            // 
            // _UserSeed
            // 
            this._UserSeed.AutoSize = true;
            this._UserSeed.Location = new System.Drawing.Point(139, 12);
            this._UserSeed.Name = "_UserSeed";
            this._UserSeed.Size = new System.Drawing.Size(89, 17);
            this._UserSeed.TabIndex = 1;
            this._UserSeed.TabStop = true;
            this._UserSeed.Text = "Use My Seed";
            this._UserSeed.UseVisualStyleBackColor = true;
            this._UserSeed.CheckedChanged += new System.EventHandler(this._UserSeed_CheckedChanged);
            // 
            // _SeedTime
            // 
            this._SeedTime.AutoSize = true;
            this._SeedTime.Location = new System.Drawing.Point(12, 12);
            this._SeedTime.Name = "_SeedTime";
            this._SeedTime.Size = new System.Drawing.Size(70, 17);
            this._SeedTime.TabIndex = 2;
            this._SeedTime.TabStop = true;
            this._SeedTime.Text = "Use Time";
            this._SeedTime.UseVisualStyleBackColor = true;
            this._SeedTime.CheckedChanged += new System.EventHandler(this._SeedTime_CheckedChanged);
            // 
            // _Apply
            // 
            this._Apply.Location = new System.Drawing.Point(13, 63);
            this._Apply.Name = "_Apply";
            this._Apply.Size = new System.Drawing.Size(75, 23);
            this._Apply.TabIndex = 3;
            this._Apply.Text = "Apply";
            this._Apply.UseVisualStyleBackColor = true;
            this._Apply.Click += new System.EventHandler(this._Apply_Click);
            // 
            // _Cancel
            // 
            this._Cancel.Location = new System.Drawing.Point(165, 63);
            this._Cancel.Name = "_Cancel";
            this._Cancel.Size = new System.Drawing.Size(75, 23);
            this._Cancel.TabIndex = 4;
            this._Cancel.Text = "Cancel";
            this._Cancel.UseVisualStyleBackColor = true;
            this._Cancel.Click += new System.EventHandler(this._Cancel_Click);
            // 
            // SeedSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 98);
            this.Controls.Add(this._Cancel);
            this.Controls.Add(this._Apply);
            this.Controls.Add(this._SeedTime);
            this.Controls.Add(this._UserSeed);
            this.Controls.Add(this._UserSeedInput);
            this.Name = "SeedSelection";
            this.Text = "SeedSelection";
            this.Shown += new System.EventHandler(this.SeedSelection_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._UserSeedInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _UserSeedInput;
        private System.Windows.Forms.RadioButton _UserSeed;
        private System.Windows.Forms.RadioButton _SeedTime;
        private System.Windows.Forms.Button _Apply;
        private System.Windows.Forms.Button _Cancel;
    }
}