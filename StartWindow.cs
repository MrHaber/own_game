using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new SettingsWindow().Show();
            
            this.Hide();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new DBViewer().Show();

            this.Hide();

        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

        }

        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
