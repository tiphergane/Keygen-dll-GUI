using System;
using System.Windows.Forms;

namespace KeygenDLLGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Configuration GUI
            this.button1.Text = "&Générer";
            this.button2.Text = "&About";
            this.button3.Text = "&Quitter";
            this.textBox2.Text = "entrez un pseudonyme dans la première box";
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.textBox2.TextAlign = HorizontalAlignment.Center;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.groupBox1.Text = "Choisissez votre générateur dans la liste";
            KeygenDLL.Class1 Source = new KeygenDLL.Class1();
            this.comboBox1.DataSource = Source.Data();
            this.comboBox1.SelectedText = "keygen1";
            this.comboBox1.Refresh();
            this.Text = "Keygen";
            #endregion
        }

        #region Générer
        /// <summary>
        /// Pour envoyer les informations de la GUI vers la DLL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            GetKey();
        }
        /// <summary>
        /// Pour envoyer les informations de la GUI vers la DLL quand on change le nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetKey();
        }

        /// <summary>
        /// Pour envoyer les informations de la GUI vers la DLL quand on change le Keygen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetKey();
        }

        #endregion

        #region About
        private void button2_Click(object sender, EventArgs e)
        {
            string Nombre = this.comboBox1.Items.Count.ToString();
            MessageBox.Show("Keygen for:\t" + Nombre +" Application DLL based\r" + Environment.NewLine + "Protection:\tAll depend the Application\r" + Environment.NewLine + "greetz fly to:\tRax| Haiklr et tous les autres\r", "About meoow");
        }
        #endregion

       private void GetKey()
        {
            KeygenDLL.Class1 Code = new KeygenDLL.Class1();
            textBox2.Text = Code.Choix(comboBox1.Text, textBox1.Text);
        }

        #region Quitter
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion
    }
}
