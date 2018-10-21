namespace csgui
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.TableName = new System.Windows.Forms.Label();
            this.CategoryTable = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(250, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(788, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(21, 97);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add Animal";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TableName.Location = new System.Drawing.Point(605, 40);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(66, 25);
            this.TableName.TabIndex = 2;
            this.TableName.Text = "Table";
            // 
            // CategoryTable
            // 
            this.CategoryTable.DisplayMember = "0";
            this.CategoryTable.FormattingEnabled = true;
            this.CategoryTable.Items.AddRange(new object[] {
            "Predator",
            "GrassEater",
            "Bird",
            "Crawl",
            "Fish",
            "DobleLife"});
            this.CategoryTable.Location = new System.Drawing.Point(250, 40);
            this.CategoryTable.Name = "CategoryTable";
            this.CategoryTable.Size = new System.Drawing.Size(121, 21);
            this.CategoryTable.TabIndex = 3;
            this.CategoryTable.SelectedIndexChanged += new System.EventHandler(this.CategoryTable_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(21, 143);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete Animal";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(21, 188);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(86, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update Animal";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(21, 237);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(86, 23);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CategoryTable);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.ComboBox CategoryTable;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button FilterButton;
    }
}

