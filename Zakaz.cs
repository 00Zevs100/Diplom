using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void OfZakaz_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = textBox1.Text;
            save.InitialDirectory = @"C:\";
            save.Filter = "TXT files (.txt)|.txt|All files (.)|.";
            save.FilterIndex = 1;
            save.Title ="Оформить заказ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(save.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (StreamWriter wr = new StreamWriter(fs))
                    {
                        wr.WriteLine(" AVTOTO ");
                        wr.WriteLine(" ");
                        wr.WriteLine("Номер заказу: " + textBox1.Text + " ");
                        wr.WriteLine(" ");
                        wr.WriteLine("ПІБ Покупця: " + textBox2.Text);
                       
                        wr.WriteLine("Сума замовлення: " + textBox4.Text);
                        wr.WriteLine(" ");
                        wr.WriteLine("Дата замовлення " + DateTime.Now + " ");
                        wr.WriteLine(" ");
                        wr.WriteLine("ПІБ продаця: " + textBox3.Text);
                        wr.Flush();
                        wr.Close();
                    }
                    fs.Close();
                    MessageBox.Show("Заказ оформлено");
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Zakruto_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Zakruto_MouseEnter(object sender, EventArgs e)
        {
            Zakruto.ForeColor = Color.Red;
        }

        private void OfZakaz_MouseEnter(object sender, EventArgs e)
        {
            OfZakaz.ForeColor = Color.Red;
        }

        private void OfZakaz_MouseLeave(object sender, EventArgs e)
        {
            OfZakaz.ForeColor = Color.YellowGreen;
        }

        private void Zakruto_MouseLeave(object sender, EventArgs e)
        {
            Zakruto.ForeColor = Color.YellowGreen;
        }

        Point lastPoint;

        private void Zakaz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Zakaz_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
    
}
