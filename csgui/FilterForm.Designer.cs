namespace csgui
{
    partial class FilterForm
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
            this.CategoryList = new System.Windows.Forms.ComboBox();
            this.CategoryType = new System.Windows.Forms.Label();
            this.Atrrib1Label = new System.Windows.Forms.Label();
            this.Attrib2Label = new System.Windows.Forms.Label();
            this.Attrib1List = new System.Windows.Forms.ComboBox();
            this.Atrrib2List = new System.Windows.Forms.ComboBox();
            this.AOLabel = new System.Windows.Forms.Label();
            this.AOList = new System.Windows.Forms.ComboBox();
            this.ShowFilters = new System.Windows.Forms.Button();
            this.Attrib1Text = new System.Windows.Forms.TextBox();
            this.Atrrib2Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            "DobleLife"});
            this.CategoryList.Location = new System.Drawing.Point(115, 30);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(121, 21);
            this.CategoryList.TabIndex = 13;
            this.CategoryList.SelectedIndexChanged += new System.EventHandler(this.CategoryList_SelectedIndexChanged);
            // 
            // CategoryType
            // 
            this.CategoryType.AutoSize = true;
            this.CategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CategoryType.Location = new System.Drawing.Point(7, 30);
            this.CategoryType.Name = "CategoryType";
            this.CategoryType.Size = new System.Drawing.Size(99, 25);
            this.CategoryType.TabIndex = 12;
            this.CategoryType.Text = "Category";
            // 
            // Atrrib1Label
            // 
            this.Atrrib1Label.AutoSize = true;
            this.Atrrib1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Atrrib1Label.Location = new System.Drawing.Point(12, 97);
            this.Atrrib1Label.Name = "Atrrib1Label";
            this.Atrrib1Label.Size = new System.Drawing.Size(74, 25);
            this.Atrrib1Label.TabIndex = 14;
            this.Atrrib1Label.Text = "Attrib1";
            // 
            // Attrib2Label
            // 
            this.Attrib2Label.AutoSize = true;
            this.Attrib2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Attrib2Label.Location = new System.Drawing.Point(12, 232);
            this.Attrib2Label.Name = "Attrib2Label";
            this.Attrib2Label.Size = new System.Drawing.Size(74, 25);
            this.Attrib2Label.TabIndex = 15;
            this.Attrib2Label.Text = "Attrib2";
            // 
            // Attrib1List
            // 
            this.Attrib1List.FormattingEnabled = true;
            this.Attrib1List.Items.AddRange(new object[] {
            "id",
            "name",
            "height",
            "weight",
            "notes",
            "None"});
            this.Attrib1List.Location = new System.Drawing.Point(115, 97);
            this.Attrib1List.Name = "Attrib1List";
            this.Attrib1List.Size = new System.Drawing.Size(121, 21);
            this.Attrib1List.TabIndex = 16;
            this.Attrib1List.SelectedIndexChanged += new System.EventHandler(this.Attrib1List_SelectedIndexChanged);
            // 
            // Atrrib2List
            // 
            this.Atrrib2List.FormattingEnabled = true;
            this.Atrrib2List.Items.AddRange(new object[] {
            "id",
            "name",
            "height",
            "weight",
            "notes",
            "None"});
            this.Atrrib2List.Location = new System.Drawing.Point(115, 232);
            this.Atrrib2List.Name = "Atrrib2List";
            this.Atrrib2List.Size = new System.Drawing.Size(121, 21);
            this.Atrrib2List.TabIndex = 17;
            this.Atrrib2List.SelectedIndexChanged += new System.EventHandler(this.Atrrib2List_SelectedIndexChanged);
            // 
            // AOLabel
            // 
            this.AOLabel.AutoSize = true;
            this.AOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AOLabel.Location = new System.Drawing.Point(12, 162);
            this.AOLabel.Name = "AOLabel";
            this.AOLabel.Size = new System.Drawing.Size(93, 25);
            this.AOLabel.TabIndex = 18;
            this.AOLabel.Text = "AND/OR";
            // 
            // AOList
            // 
            this.AOList.FormattingEnabled = true;
            this.AOList.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.AOList.Location = new System.Drawing.Point(115, 162);
            this.AOList.Name = "AOList";
            this.AOList.Size = new System.Drawing.Size(121, 21);
            this.AOList.TabIndex = 19;
            this.AOList.SelectedIndexChanged += new System.EventHandler(this.AOList_SelectedIndexChanged);
            // 
            // ShowFilters
            // 
            this.ShowFilters.Location = new System.Drawing.Point(17, 315);
            this.ShowFilters.Name = "ShowFilters";
            this.ShowFilters.Size = new System.Drawing.Size(75, 23);
            this.ShowFilters.TabIndex = 20;
            this.ShowFilters.Text = "Show";
            this.ShowFilters.UseVisualStyleBackColor = true;
            this.ShowFilters.Click += new System.EventHandler(this.ShowFilters_Click);
            // 
            // Attrib1Text
            // 
            this.Attrib1Text.Location = new System.Drawing.Point(265, 97);
            this.Attrib1Text.Name = "Attrib1Text";
            this.Attrib1Text.Size = new System.Drawing.Size(100, 20);
            this.Attrib1Text.TabIndex = 21;
            this.Attrib1Text.TextChanged += new System.EventHandler(this.Attrib1Text_TextChanged);
            // 
            // Atrrib2Text
            // 
            this.Atrrib2Text.Location = new System.Drawing.Point(265, 232);
            this.Atrrib2Text.Name = "Atrrib2Text";
            this.Atrrib2Text.Size = new System.Drawing.Size(100, 20);
            this.Atrrib2Text.TabIndex = 22;
            this.Atrrib2Text.TextChanged += new System.EventHandler(this.Atrrib2Text_TextChanged);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 366);
            this.Controls.Add(this.Atrrib2Text);
            this.Controls.Add(this.Attrib1Text);
            this.Controls.Add(this.ShowFilters);
            this.Controls.Add(this.AOList);
            this.Controls.Add(this.AOLabel);
            this.Controls.Add(this.Atrrib2List);
            this.Controls.Add(this.Attrib1List);
            this.Controls.Add(this.Attrib2Label);
            this.Controls.Add(this.Atrrib1Label);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.CategoryType);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryList;
        private System.Windows.Forms.Label CategoryType;
        private System.Windows.Forms.Label Atrrib1Label;
        private System.Windows.Forms.Label Attrib2Label;
        private System.Windows.Forms.ComboBox Attrib1List;
        private System.Windows.Forms.ComboBox Atrrib2List;
        private System.Windows.Forms.Label AOLabel;
        private System.Windows.Forms.ComboBox AOList;
        private System.Windows.Forms.Button ShowFilters;
        private System.Windows.Forms.TextBox Attrib1Text;
        private System.Windows.Forms.TextBox Atrrib2Text;
    }
}