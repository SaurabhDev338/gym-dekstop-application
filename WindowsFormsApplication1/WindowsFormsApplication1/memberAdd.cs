using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class memberAdd : Form
    {
        public memberAdd()
        {
            InitializeComponent();
        }

        private void memberAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
