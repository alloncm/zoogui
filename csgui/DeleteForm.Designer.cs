namespace csgui
{
    partial class DeleteForm
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
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.IdToDel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IdToDel)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(79, 49);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(108, 13);
            this.DeleteLabel.TabIndex = 0;
            this.DeleteLabel.Text = "Enter an id to delete  ";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(82, 146);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // IdToDel
            // 
            this.IdToDel.Location = new System.Drawing.Point(82, 89);
            this.IdToDel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IdToDel.Name = "IdToDel";
            this.IdToDel.Size = new System.Drawing.Size(120, 20);
            this.IdToDel.TabIndex = 3;
            this.IdToDel.ValueChanged += new System.EventHandler(this.IdToDel_ValueChanged);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.IdToDel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DeleteLabel);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.IdToDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.NumericUpDown IdToDel;
    }
}