﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Modern_Flat_UI
{
    public partial class Form1 : Form
    {
        //Fields
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnPlc_Click(object sender, EventArgs e)
        {

        }

        private void btnModbus_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {

        }

        private void btnY_Click(object sender, EventArgs e)
        {

        }

        private void btnBuffer_Click(object sender, EventArgs e)
        {

        }
    }
}
