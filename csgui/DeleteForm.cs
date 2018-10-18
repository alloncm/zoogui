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
    public partial class DeleteForm : Form
    {
        private Category cat;
        private DataBase db;
        private int id;
        public DeleteForm(DataBase d,Category c)
        {
            InitializeComponent();
            db = d;
            cat = c;
            DeleteLabel.Text += cat.ToString();
            id = -1;
        }

        private void IdToDel_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.NumericUpDown t = (System.Windows.Forms.NumericUpDown)sender;
            id = (int)t.Value;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Please enter valid Id for this table");
            }
            else
            {
                db.Delete(db.GetAnimal(id).Name);
                this.Close();
            }
            
        }
    }
}
