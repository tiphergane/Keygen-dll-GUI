﻿using System;
using System.Windows.Forms;

namespace KeygenDLLGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Keygen";
            this.button1.Text = "&Générer";
            this.button2.Text = "&About";
            this.button3.Text = "&Quitter";
            this.textBox2.Text = "entrez un pseudonyme dans la première box";
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.textBox2.TextAlign = HorizontalAlignment.Center;
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                KeygenDLL.Class1 Code = new KeygenDLL.Class1();
                textBox2.Text = Code.mIRC(textBox1.Text);
        }

        #region About
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keygen for:\tMultiple Application DLL based\r" + Environment.NewLine + "Protection:\tAll depend the Application\r" + Environment.NewLine + "greetz fly to:\tRax| Haiklr et tout les autres\r", "About meoow");
        }
        #endregion
        #region Quitter
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}