using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Golovna : Form
    {
        public Golovna()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void Golovna_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Golovna_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin")
            {
                if (textBox2.Text == "12345")
                {
                    this.Hide();
                    Adm adm = new Adm();
                    adm.Show();
                }
            }

            else
            {
                MessageBox.Show("Не коректний логін або пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }


         private void Log_MouseEnter(object sender, EventArgs e)
         {
            Log.ForeColor = Color.YellowGreen;
         }
 
        private void Log_MouseLeave(object sender, EventArgs e)
        {
            Log.ForeColor = Color.Red;
        }

        private void Assist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assistant assistant = new Assistant();
            assistant.Show();
        }

        private void Assist_MouseEnter(object sender, EventArgs e)
        {
            Assist.ForeColor = Color.YellowGreen;
        }

        private void Assist_MouseLeave(object sender, EventArgs e)
        {
            Assist.ForeColor = Color.Red;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.YellowGreen;
        }

       

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red; 
        }
        // не бачити пароль
        private void NotSea_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                Sea.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        // бачити пароль
        private void Sea_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                NotSea.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
    }
}
