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

        public Form2( )
        {
            InitializeComponent();
        }

        public Form2(DataBase db)
        {
            InitializeComponent();
        }
    }
}
