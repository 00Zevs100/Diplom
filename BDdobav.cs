using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Diplom
{
    public partial class BDdobav : Form
    {
        public static string connection = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
        private OleDbConnection dbConnection;
        
        public BDdobav()
        {
            InitializeComponent();
             dbConnection = new OleDbConnection(connection);
            dbConnection.Open();
        }


        private void DOBAka_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtname.Text != "" && txtvurobnuk.Text != "" && txtcina.Text != "" && txtkilk.Text != "")
            {
                int ID = Convert.ToInt32(txtID.Text);
                String Назва = txtname.Text;
                String Виробник = txtvurobnuk.Text;
                int Ціна = Convert.ToInt32(txtcina.Text);
                String Кількість = txtkilk.Text;
                String query = "INSERT INTO Worker (iD , Nik, vurobnik, cina,  Kilk) VALUES (" + ID + ",'" + Назва + "','" + Виробник + "'," + Ціна + ",'" + Кількість + "')";
                OleDbCommand comand = new OleDbCommand(query, dbConnection);
                comand.ExecuteNonQuery();
                MessageBox.Show("Предмет додано");
            }
            else
            {
                MessageBox.Show("Не всі дані введені", "ERROR");
                return;
            }
            txtname.Clear();
            txtID.Clear();
            txtcina.Clear();
            txtkilk.Clear();
        }

        private void Zakruto_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void DOBAka_MouseEnter(object sender, EventArgs e)
        {
            DOBAka.ForeColor = Color.Red;
        }

        private void Zakruto_MouseEnter(object sender, EventArgs e)
        {
            Zakruto.ForeColor = Color.Red;
        }

        private void Zakruto_MouseLeave(object sender, EventArgs e)
        {
            Zakruto.ForeColor = Color.Yellow;
        }

        private void DOBAka_MouseLeave(object sender, EventArgs e)
        {
            DOBAka.ForeColor = Color.Yellow;
        }

        Point lastPoint;
        private void BDdobav_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BDdobav_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        
    }
}
