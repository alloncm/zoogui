namespace csgui
{
    partial class UpdateData
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
            this.NotesText = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeightText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightText)).BeginInit();
            this.SuspendLayout();
            // 
            // NotesText
            // 
            this.NotesText.Location = new System.Drawing.Point(131, 190);
            this.NotesText.Multiline = true;
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(201, 118);
            this.NotesText.TabIndex = 20;
            this.NotesText.TextChanged += new System.EventHandler(this.NotesText_TextChanged);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NotesLabel.Location = new System.Drawing.Point(23, 190);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(68, 25);
            this.NotesLabel.TabIndex = 19;
            this.NotesLabel.Text = "Notes";
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(131, 120);
            this.WeightText.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(71, 20);
            this.WeightText.TabIndex = 18;
            this.WeightText.ValueChanged += new System.EventHandler(this.WeightText_ValueChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WeightLabel.Location = new System.Drawing.Point(23, 115);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(79, 25);
            this.WeightLabel.TabIndex = 17;
            this.WeightLabel.Text = "Weight";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(131, 69);
            this.HeightText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(71, 20);
            this.HeightText.TabIndex = 16;
            this.HeightText.ValueChanged += new System.EventHandler(this.HeightText_ValueChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HeightLabel.Location = new System.Drawing.Point(23, 69);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(74, 25);
            this.HeightLabel.TabIndex = 15;
            this.HeightLabel.Text = "Height";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NameLabel.Location = new System.Drawing.Point(23, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 25);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(131, 25);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(201, 20);
            this.NameText.TabIndex = 13;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(28, 342);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 453);
            this.Controls.Add(this.NotesText);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Update);
            this.Name = "UpdateData";
            this.Text = "UpdateData";
            ((System.ComponentModel.ISupportInitialize)(this.WeightText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.NumericUpDown WeightText;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.NumericUpDown HeightText;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button Update;
    }
}