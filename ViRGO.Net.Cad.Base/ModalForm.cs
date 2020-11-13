using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViRGO.Net.Cad.Base
{
    public partial class ModalForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public ModalForm()
        {
            InitializeComponent();
        }

        private void lbl_Close_MouseHover(object sender, EventArgs e)
        {
            lbl_Close.ForeColor = Color.DarkGray;
        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            lbl_Close.ForeColor = Color.WhiteSmoke;
        }

        private void ModalForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ModalForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void ModalForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lbl_minimize_MouseHover(object sender, EventArgs e)
        {
            lbl_minimize.ForeColor = Color.DarkGray;
        }

        private void lbl_minimize_MouseLeave(object sender, EventArgs e)
        {
            lbl_minimize.ForeColor = Color.WhiteSmoke;
        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ModalForm_Load(object sender, EventArgs e)
        {
            lbl_Close.Top = 3;
            lbl_Close.Left = this.Width - 20;
            lbl_minimize.Top = 1;
            lbl_minimize.Left = this.Width - 40;
        }
    }
}
