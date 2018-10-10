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
        public Form1()
        {
            InitializeComponent();
            System.IO.BinaryReader fin = new System.IO.BinaryReader(File.Open("database.sqlite", FileMode.OpenOrCreate));
            fin.Close();
            db = new DataBase("database.sqlite");
            db.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetDataTable();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
