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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CheckPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPass2.Checked)
            {
                Pasfield.UseSystemPasswordChar = true;
                Pasfield2.UseSystemPasswordChar = true;
            }
            else
            {
                Pasfield.UseSystemPasswordChar = false;
                Pasfield2.UseSystemPasswordChar = false;
            }
        }

       

        private void Back_Click(object sender, EventArgs e)
        {
            
            Авторизация LogForm = new Авторизация(database);
            LogForm.Show();
            this.Hide();
        }
    }
    
}
