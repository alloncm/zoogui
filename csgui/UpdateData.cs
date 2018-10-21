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
    public partial class UpdateData : Form
    {
        private DataBase db;

        private int id;
        private int height;
        private int weight;
        private string name;
        private string notes;
        private Animal toUpdate;

        public UpdateData(DataBase d, int i)
        {
            InitializeComponent();
            db = d;
            id = i;

            toUpdate = db.GetAnimal(id);

            NameText.Text = toUpdate.Name;
            HeightText.Value = (decimal)toUpdate.Height;
            WeightText.Value = (decimal)toUpdate.Weight;
            NotesText.Text = toUpdate.SpecialNotes;
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

        private void Update_Click(object sender, EventArgs e)
        {
            bool isGood = true;
            if (notes == null)
            {
                notes = "";
            }
            if (name == null)
            {
                isGood = false;
            }
            else if (toUpdate.Name !=name && db.GetId(name) != -1)
            {
                isGood = false;
            }

            else if (height == 0)
            {
                isGood = false;
            }
            else if (weight == 0)
            {
                isGood = false;
            }
            

            if (isGood)
            {
                string sql = "UPDATE " + toUpdate.category.ToString() + " SET ";
                int count = 0;
                if(toUpdate.Name!=name)
                {
                    sql += "name = '" + name+"'";
                    count++;
                    toUpdate.Name = name;
                }
                if(toUpdate.Height!=height)
                {
                    if(count!=0)
                    {
                        sql += ", ";
                    }
                    sql += "height = " + height;
                    count++;
                    toUpdate.Height = height;
                }
                if(toUpdate.Weight!=weight)
                {
                    if (count != 0)
                    {
                        sql += ", ";
                    }
                    sql += "weight = " + weight;
                    count++;
                    toUpdate.Weight = weight;
                }
                if(toUpdate.SpecialNotes!=notes)
                {
                    if (count != 0)
                    {
                        sql += ", ";
                    }
                    sql += "notes = '" + notes+"'";
                    count++;
                    toUpdate.SpecialNotes = notes;
                }
                if(count!=0)
                {
                    db.Update(id, sql);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter all the data for the Form");
            }
        }
    }
}
