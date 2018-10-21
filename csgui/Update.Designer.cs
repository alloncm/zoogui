namespace csgui
{
    partial class Update
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
            this.IdToUP = new System.Windows.Forms.NumericUpDown();
            this.Upd = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdToUP)).BeginInit();
            this.SuspendLayout();
            // 
            // IdToUP
            // 
            this.IdToUP.Location = new System.Drawing.Point(72, 93);
            this.IdToUP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IdToUP.Name = "IdToUP";
            this.IdToUP.Size = new System.Drawing.Size(120, 20);
            this.IdToUP.TabIndex = 6;
            this.IdToUP.ValueChanged += new System.EventHandler(this.IdToUP_ValueChanged);
            // 
            // Upd
            // 
            this.Upd.Location = new System.Drawing.Point(72, 150);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(75, 23);
            this.Upd.TabIndex = 5;
            this.Upd.Text = "Update";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(69, 52);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(111, 13);
            this.UpdateLabel.TabIndex = 4;
            this.UpdateLabel.Text = "Enter an id to Update ";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.IdToUP);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.UpdateLabel);
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.IdToUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdToUP;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Label UpdateLabel;
    }
}