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

   

    public partial class FilterForm : Form
    {
        DataBase db;
        private Category cat;
        private Attrib attrib1;
        private Attrib attrib2;
        private string attrib1T;
        private string attrib2T;
        private AndOr ao;
        public FilterForm(DataBase d)
        {
            InitializeComponent();
            db = d;
            attrib1 = Attrib.None;
            attrib2 = Attrib.None;
            attrib1T = "";
            attrib2T = "";
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox t = (System.Windows.Forms.ComboBox)sender;
            cat = (Category)t.SelectedIndex;
        }

        private void Attrib1List_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox t = (System.Windows.Forms.ComboBox)sender;
            attrib1 = (Attrib)t.SelectedIndex;
        }

        private void AOList_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox t = (System.Windows.Forms.ComboBox)sender;
            ao = (AndOr)t.SelectedIndex;
        }

        private void Atrrib2List_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox t = (System.Windows.Forms.ComboBox)sender;
            attrib2 = (Attrib)t.SelectedIndex;
        }

        private void Attrib1Text_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)sender;
            attrib1T = t.Text;
        }

        private void Atrrib2Text_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)sender;
            attrib2T = t.Text;
        }

        private void ShowFilters_Click(object sender, EventArgs e)
        {
            char c = attrib1T[0];
            bool sign = c != '=' && c != '>' && c != '<';
            string s = attrib1T.Substring(1);
            int r;
            bool isInt = true;
            if (attrib1!=Attrib.name&&attrib1!=Attrib.notes)
            {
                isInt = Int32.TryParse(s, out r);
            }
            if (sign && !isInt)
            {
                MessageBox.Show("invalid Input");
            }
            else
            {
                if (attrib1 != Attrib.None && attrib1T != "")
                {
                    DataTable dt = db.GetDataTableQ(cat, attrib1, attrib1T);
                    ShowData sd = new ShowData(dt);
                    sd.ShowDialog();
                }
            }
        }
    }
}
