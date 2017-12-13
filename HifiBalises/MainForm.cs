using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HifiBalises
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            /* Mise en forme */
            string bal1 = TxtBal1.Text.ToUpper();
            string bal2 = TxtBal2.Text.ToUpper();
            string bal3 = TxtBal3.Text.ToUpper();
            string bal4 = TxtBal4.Text.ToUpper();
            string bal5 = TxtBal5.Text.ToUpper();
            string bal6 = TxtBal6.Text.ToUpper();
            string bal7 = TxtBal7.Text.ToUpper();
            string bal8 = TxtBal8.Text.ToUpper();
            string bal9 = TxtBal9.Text.ToUpper();
            string bal10 = TxtBal10.Text.ToUpper();
            string bal11 = TxtBal11.Text.ToUpper();
            string bal12 = TxtBal12.Text.ToUpper();
            string bal13 = TxtBal13.Text.ToUpper();
            string bal14 = TxtBal14.Text.ToUpper();

            PDF frm = new PDF(bal1, bal2, bal3, bal4, bal5, bal6, bal7, bal8, bal9, bal10, bal11, bal12, bal13, bal14);
            frm.ShowDialog();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtBal1.Text = "";
            TxtBal2.Text = "";
            TxtBal3.Text = "";
            TxtBal4.Text = "";
            TxtBal5.Text = "";
            TxtBal6.Text = "";
            TxtBal7.Text = "";
            TxtBal8.Text = "";
            TxtBal9.Text = "";
            TxtBal10.Text = "";
            TxtBal11.Text = "";
            TxtBal12.Text = "";
            TxtBal13.Text = "";
            TxtBal14.Text = "";

            TxtBal1.Focus();
        }
    }
}
