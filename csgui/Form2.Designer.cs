namespace csgui
{
    partial class Form2
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
            this.Add = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.NumericUpDown();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesText = new System.Windows.Forms.TextBox();
            this.CategoryType = new System.Windows.Forms.Label();
            this.CategoryList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeightText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightText)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(17, 433);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(120, 60);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(201, 20);
            this.NameText.TabIndex = 1;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NameLabel.Location = new System.Drawing.Point(12, 60);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HeightLabel.Location = new System.Drawing.Point(12, 104);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(74, 25);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "Height";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(120, 104);
            this.HeightText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(71, 20);
            this.HeightText.TabIndex = 5;
            this.HeightText.ValueChanged += new System.EventHandler(this.HeightText_ValueChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WeightLabel.Location = new System.Drawing.Point(12, 150);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(79, 25);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(120, 155);
            this.WeightText.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(71, 20);
            this.WeightText.TabIndex = 7;
            this.WeightText.ValueChanged += new System.EventHandler(this.WeightText_ValueChanged);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NotesLabel.Location = new System.Drawing.Point(12, 276);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(68, 25);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Notes";
            // 
            // NotesText
            // 
            this.NotesText.Location = new System.Drawing.Point(120, 282);
            this.NotesText.Multiline = true;
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(201, 118);
            this.NotesText.TabIndex = 9;
            this.NotesText.TextChanged += new System.EventHandler(this.NotesText_TextChanged);
            // 
            // CategoryType
            // 
            this.CategoryType.AutoSize = true;
            this.CategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CategoryType.Location = new System.Drawing.Point(12, 198);
            this.CategoryType.Name = "CategoryType";
            this.CategoryType.Size = new System.Drawing.Size(99, 25);
            this.CategoryType.TabIndex = 10;
            this.CategoryType.Text = "Category";
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Items.AddRange(new object[] {
            "Predator",
            "GrassEater",
            "Bird",
            "Crawl",
            "Fish",
            "DobleLif"});
            this.CategoryList.Location = new System.Drawing.Point(120, 198);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(121, 21);
            this.CategoryList.TabIndex = 11;
            this.CategoryList.SelectedIndexChanged += new System.EventHandler(this.CategoryList_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 483);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.CategoryType);
            this.Controls.Add(this.NotesText);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Add);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.HeightText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown HeightText;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.NumericUpDown WeightText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox NotesText;
        private System.Windows.Forms.Label CategoryType;
        private System.Windows.Forms.ComboBox CategoryList;
    }
}