using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public partial class frmControleDeAcesso : Form
    {
        public frmControleDeAcesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in mspUsuarios.Items)
                MessageBox.Show(item.Name);
        }
    }
}
