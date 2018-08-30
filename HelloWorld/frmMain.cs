// frmMain.cs
// CS 1181
// Katherine Wilsdon
// 29 August 2018
// Dr. Cody Permann
// Description - Produces a Message Box that displays Hello {Entry in the textbox}!.
// WOW: Click the Exit button to close Hello App.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e) {
            // Produces a Message Box that displays Hello {Entry in the textbox}!.
            MessageBox.Show("Hello " + txtName.Text + "!");
        }

        private void btnExit_Click(object sender, EventArgs e) {
            // Close Hello App.
            this.Close();
        }
    }
}
