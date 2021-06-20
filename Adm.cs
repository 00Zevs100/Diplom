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
    public partial class Adm : Form
    {
       public static string connection = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb";
       private OleDbConnection dbConnection;
        

        public Adm()
        {
            
            InitializeComponent();
      
            dbConnection = new OleDbConnection(connection);
           dbConnection.Open();
        }
                

        private void button1_Click(object sender, EventArgs e)
        {

            
            dbConnection.Close();
            //звернення до бази
            dbConnection.Open();//відкривається з'єднання 
            string query = "SELECT * FROM Worker";//рядок запиту
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
                    Vuvod_BD.Rows.Add(dbReader["id"], dbReader["Nik"], dbReader["Vurobnik"], dbReader["Cina"], dbReader["Kilk"]);
                }
            }
            

            //Закриття з’єднання з  БД
            dbReader.Close();
            dbConnection.Close();
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.YellowGreen;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

      

        private void Dobavut_Click(object sender, EventArgs e)
        {
            
            BDdobav bDdobav = new BDdobav();
            bDdobav.Show();

        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            Delete.ForeColor = Color.Red;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.ForeColor = Color.YellowGreen;
        }

        private void Dobavut_MouseEnter(object sender, EventArgs e)
        {
            Dobavut.ForeColor = Color.Red;
        }

        private void Dobavut_MouseLeave(object sender, EventArgs e)
        {
            Dobavut.ForeColor = Color.YellowGreen;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Adm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Adm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.YellowGreen;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            dbConnection.Open();
            //Видалення деталей по id деталі
            if (textid.Text != "")
            {
                int ID = Convert.ToInt32(textid.Text);
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
            textid.Clear();
            dbConnection.Close();

        }

        

        private void Redaktor_Click(object sender, EventArgs e)
        {
            dbConnection.Open();
            if (Idtext.Text != ""|| cinatext.Text != "")
            {
                int ID = Convert.ToInt32(Idtext.Text);
                string query = "UPDATE  Worker SET cina =" + cinatext.Text + " WHERE id=" + ID;
                OleDbCommand comand = new OleDbCommand(query, dbConnection);
                comand.ExecuteNonQuery();
                MessageBox.Show("Данні відредаговані.");
            }


            else
            {

                MessageBox.Show("Не всі данні введені!!");
                return;
            }
            Idtext.Clear();
            cinatext.Clear();
            dbConnection.Close();
        }

        private void Redaktor_MouseEnter(object sender, EventArgs e)
        {
            Redaktor.ForeColor = Color.Red;
        }

        private void Redaktor_MouseLeave(object sender, EventArgs e)
        {
            Redaktor.ForeColor = Color.YellowGreen;
        }

        private void pokypka_Click(object sender, EventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
        }

        private void pokypka_MouseEnter(object sender, EventArgs e)
        {
            pokypka.ForeColor = Color.Red;
        }

        private void pokypka_MouseLeave(object sender, EventArgs e)
        {
            pokypka.ForeColor = Color.YellowGreen;
        }

        private void Adm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Worker";//рядок запиту
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
                    Vuvod_BD.Rows.Add(dbReader["id"], dbReader["Nik"], dbReader["Vurobnik"], dbReader["Cina"], dbReader["Kilk"]);
                }
            }

            //Закриття з’єднання з  БД
            dbReader.Close();
            dbConnection.Close();
        }
    }
}
