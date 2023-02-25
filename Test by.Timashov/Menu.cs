using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_by.Timashov
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            SetRoundedShape(panel1, 25);
        }


        bool help = false;

        public void aboutProgram()
        {
            About about = new About();
            about.Show();
        }


        #region private_event
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goSetting_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = true;
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            int y = 10000000;
            if (min10.Checked == true)
                y = 10;
            else if (min15.Checked == true)
                y = 15;
            else if (min20.Checked == true)
                y = 20;
            else if (min30.Checked == true)
                y = 30;

            Test test = new Test(help, y);
            test.Show();
            this.Hide();
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
        }

        private void timerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (timerCB.Enabled == false)
            {
                min10.Checked = false; min15.Checked = false;
                min20.Checked = false; min30.Checked = false;
            }

            min10.Enabled = timerCB.Checked; min15.Enabled = timerCB.Checked;
            min20.Enabled = timerCB.Checked; min30.Enabled = timerCB.Checked;
            
        }        

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutProgram();
        }


        #endregion
        #region etc
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
        #endregion

        private void helpCB_CheckedChanged(object sender, EventArgs e)
        {
            help = helpCB.Checked;
        }
    }
}
