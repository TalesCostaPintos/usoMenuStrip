using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appExemplomenu
{
    public partial class FrmVermelho : Form
    {
        public FrmVermelho()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo();
            this.Hide();
            frm.ShowDialog();
        }

        private void ExibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul();
            this.Hide();
            frm.ShowDialog();
        }

        private void ExibirFormVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho();
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
