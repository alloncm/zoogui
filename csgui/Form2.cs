using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csgui
{
    public partial class Form2 : Form
    {
        private DataBase db;

        private int height;
        private int weight;
        private string name;
        private string notes;
        private Category cat;

        public Form2(DataBase d)
        {
            InitializeComponent();
            db = d;
            cat = Category.None;
        }

        private void Add_Click(object sender, EventArgs e)
        {

            bool isGood = true;
            if (notes == null)
            {
                notes = "";
            }
            if (name==null)
            {
                isGood = false;
            }
            else if(height==0)
            {
                isGood = false;
            }
            else if(weight==0)
            {
                isGood = false;
            }
            else if(cat==Category.None)
            {
                isGood = false;
            }

            if(isGood)
            {
                Animal a = new Animal(name, cat, height, weight, notes);
                db.AddAnimal(a);
                db.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter all the data for the Form");
            }
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)sender;
            name = t.Text;
        }

        private void HeightText_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.NumericUpDown t = (System.Windows.Forms.NumericUpDown)sender;
            height = (int)t.Value;
        }

        private void WeightText_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.NumericUpDown t = (System.Windows.Forms.NumericUpDown)sender;
            weight = (int)t.Value;
        }

        private void NotesText_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)sender;
            notes = t.Text;
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox t = (System.Windows.Forms.ComboBox)sender;
            cat = (Category)t.SelectedIndex;
        }
    }
}
