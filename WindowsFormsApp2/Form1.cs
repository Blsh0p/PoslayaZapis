using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            PassField.UseSystemPasswordChar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm();
            this.Hide();
        }


        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                PassField.UseSystemPasswordChar = true;
            }
            else
            {
                PassField.UseSystemPasswordChar = false;
            }
        }
        private void OpenRegistrationForm()
        {
            this.Hide();
            Form2 registrationForm = new Form2(database);
            registrationForm.ShowDialog();
           
        }

        private void Авторизация_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
