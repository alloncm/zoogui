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
    public partial class ShowData : Form
    {
        private DataTable dt;
        public ShowData(DataTable d)
        {
            InitializeComponent();
            dt = d;
            Table.DataSource = d;
        }
    }
}
