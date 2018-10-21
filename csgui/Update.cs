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
    public partial class Update : Form
    {
        private DataBase db;
        int id;
        public Update(DataBase d)
        {
            InitializeComponent();
            db = d;
            id = -1;
        }

        private void IdToUP_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.NumericUpDown t = (System.Windows.Forms.NumericUpDown)sender;
            id = (int)t.Value;
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            var a = db.GetAnimal(id);
            if (id == -1 || a == null)
            {
                MessageBox.Show("Please enter valid Id");
            }
            else
            {
                UpdateData ud = new UpdateData(db, id);
                ud.ShowDialog();
                this.Close();
            }
        }
    }
}
