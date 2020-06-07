using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAM
{
    public partial class SAM : Form
    {
        public SAM()
        {
            InitializeComponent();
        }


        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            Form formPersonal = new FormPersonal();
            formPersonal.Show();
        }
    }
}
