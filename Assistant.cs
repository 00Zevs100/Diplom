using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Assistant : Form
    {
        public static string connection = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Work.mdb";
        private OleDbConnection dbConnection;
        public Assistant()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(connection);
            dbConnection.Open();
        }

        private void BD_Click(object sender, EventArgs e)
        {
            

            
            string query = "SELECT * FROM Works";//рядок запиту
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //перевірка даних
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Дані не знайдені!", "ERROR");
            }
            else
            {

                while (dbReader.Read())
                {
                    //Виводим данні
                    Vuvod_BD.Rows.Add(dbReader["id"], dbReader["Nik"], dbReader["vurobnik"], dbReader["Cina"]);
                }
            }

            //Закриття з’єднання з  БД
            dbReader.Close();
            dbConnection.Close();
        }

        private void BD_MouseEnter(object sender, EventArgs e)
        {
            BD.ForeColor = Color.RoyalBlue;
        }

        private void BD_MouseLeave(object sender, EventArgs e)
        {
            BD.ForeColor = Color.YellowGreen;
        }     

        private void Dobavut_MouseEnter(object sender, EventArgs e)
        {
            Dobavut.ForeColor = Color.RoyalBlue;
        }
    

        private void Dobavut_MouseLeave(object sender, EventArgs e)
        {
            Dobavut.ForeColor = Color.YellowGreen;
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            Delete.ForeColor = Color.RoyalBlue;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.ForeColor = Color.YellowGreen;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.DarkGreen; 
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                string query = "DELETE FROM Worker WHERE [id] =" + ID;
                OleDbCommand comand = new OleDbCommand(query, dbConnection);
                comand.ExecuteNonQuery();
                MessageBox.Show("Данні видалені.");
            }
            else
            {
                MessageBox.Show("Ви не увели id");
                return;
            }
        }

        private void Dobavut_Click(object sender, EventArgs e)
        {
            AssistBD assistBD = new AssistBD();
            assistBD.Show();
        }


        Point lastPoint;

        private void Assistant_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Assistant_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        
    }
    
}