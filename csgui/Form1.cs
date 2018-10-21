using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace csgui
{
    public partial class Form1 : Form
    {
        private DataBase db;

        private Category catergorySelected = Category.Predator;
        public Form1()
        {
            InitializeComponent();
            System.IO.BinaryReader fin = new System.IO.BinaryReader(File.Open("database.sqlite", FileMode.OpenOrCreate));
            fin.Close();
            db = new DataBase("database.sqlite");
            db.Load();
            db.Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetDataTable(catergorySelected);
            dataGridView1.DataSource = dt;

            //gets the table the title
            TableName.Text = catergorySelected.ToString();
        }
        

        private void AddButtonClick(object sender, EventArgs e)
        {
            Form2 form = new Form2(db);
            form.ShowDialog();

            DataTable dt = db.GetDataTable(catergorySelected);
            dataGridView1.DataSource = dt;
        }

        private void CategoryTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox t = (System.Windows.Forms.ComboBox)sender;
            catergorySelected = (Category)t.SelectedIndex;

            DataTable dt = db.GetDataTable(catergorySelected);
            dataGridView1.DataSource = dt;

            //gets the table the title
            TableName.Text = catergorySelected.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GetDataTable(catergorySelected);
            DeleteForm delete = new DeleteForm(db);
            delete.ShowDialog();
            dt = db.GetDataTable(catergorySelected);
            dataGridView1.DataSource = dt;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GetDataTable(catergorySelected);
            csgui.Update update = new csgui.Update (db);
            update.ShowDialog();
            dt = db.GetDataTable(catergorySelected);
            dataGridView1.DataSource = dt;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterForm ff = new FilterForm(db);
            ff.ShowDialog();
        }
    }
}
