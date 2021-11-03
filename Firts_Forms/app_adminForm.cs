using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firts_Forms
{
    public partial class App_adminForm : Form
    {
        public App_adminForm()
        {
            InitializeComponent();

            loginField.Text = "Вы вошли как: ";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;

            type_app_box.Hide();
            login_app_box.Hide();
            fullName_app_box.Hide();
            date_p_app_box.Hide();
            number_app_box.Hide();
            dob_app_box.Hide();
            pob_app_box.Hide();
            date_y_app_box.Hide();
            calendare_pannel.Hide();
            main_pannel.Hide();
            main_pannel_2.Hide();
            type_pp_2.Hide();
            t_field_2.Hide();
            type2_label.Hide();
        }

        Point lastPoint;


        private void type_pp_Click(object sender, EventArgs e)
        {
            String tfield = t_field.Text;
            String login = login_app_box.Text;
            String fullName = fullName_app_box.Text;
            String date_p = date_p_app_box.Text;
            String number = number_app_box.Text;
            String dop = dob_app_box.Text;
            String pob = pob_app_box.Text;
            String type_ap = type_app_box.Text;
            String date_y = date_y_app_box.Text;


            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `application` WHERE `type_app` = @tfield", db.getConnection());

            command.Parameters.Add("@tfield", MySqlDbType.VarChar).Value = tfield; // вставляю в заглушку переменную //


            adapter.SelectCommand = command;
            adapter.Fill(table);

            type_app_box.Text = table.Rows[0][1].ToString();
            login_app_box.Text = table.Rows[0][2].ToString();
            fullName_app_box.Text = table.Rows[0][3].ToString();
            date_p_app_box.Text = table.Rows[0][4].ToString();
            number_app_box.Text = table.Rows[0][5].ToString();
            dob_app_box.Text = table.Rows[0][6].ToString();
            pob_app_box.Text = table.Rows[0][7].ToString();
            date_y_app_box.Text = table.Rows[0][8].ToString();



            type_app_box.Show();
            login_app_box.Show();
            fullName_app_box.Show();
            date_p_app_box.Show();
            number_app_box.Show();
            dob_app_box.Show();
            pob_app_box.Show();
            date_y_app_box.Show();
            main_pannel.Show();


        }

        private void date_button_Click(object sender, EventArgs e)
        {
            calendare_pannel.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPannel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPannel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPannel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 249, 249);
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_form adminnform = new Admin_form();
            adminnform.Show();
        }

        private void return_button_MouseEnter(object sender, EventArgs e)
        {
            return_button.BackColor = Color.Red;
        }

        private void return_button_MouseLeave(object sender, EventArgs e)
        {
            return_button.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            type_pp_2.Show();
            t_field_2.Show();
            type2_label.Show();

            String date_y = date_y_app_box.Text;
            String type_app = type_app_box.Text;
            String login = login_app_box.Text;
            String fullName = fullName_app_box.Text;
            String date_p = date_p_app_box.Text;
            String number = number_app_box.Text;
            String Dob = dob_app_box.Text;
            String Pob = pob_app_box.Text;


            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO application_seal (type_app, login, Fullname, date_p, number, Dob, Pob, date_y) VALUES (@tp, @ul, @fn, @dp, @num, @d, @p, @dy)", db.getConnection());

            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = type_app; // вставляю в заглушку переменную //
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fullName;
            command.Parameters.Add("@dp", MySqlDbType.VarChar).Value = date_p;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@d", MySqlDbType.VarChar).Value = Dob;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = Pob;
            command.Parameters.Add("@dy", MySqlDbType.VarChar).Value = date_y;




            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Заявка на печать подана успешно");
            else
                MessageBox.Show("Ошибка, заявка не прошла регистрацию");

            db.closeConnection();



        }

        private string text = "";

        private void print_button_Click(object sender, EventArgs e)
        {
            string text = main_pannel.Text;

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void type_pp_2_Click(object sender, EventArgs e)
        {
            main_pannel_2.Show();

            String tfield = t_field_2.Text;
            String login = login_app_box2.Text;
            String fullName = fullName_app_box2.Text;
            String date_p = date_p_app_box2.Text;
            String number = number_app_box2.Text;
            String dop = dob_app_box2.Text;
            String pob = pob_app_box2.Text;
            String type_ap = type_app_box2.Text;
            String date_y = date_y_app_box2.Text;


            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `application_seal` WHERE `type_app` = @tfield", db.getConnection());

            command.Parameters.Add("@tfield", MySqlDbType.VarChar).Value = tfield; // вставляю в заглушку переменную //


            adapter.SelectCommand = command;
            adapter.Fill(table);

            type_app_box2.Text = table.Rows[0][1].ToString();
            login_app_box2.Text = table.Rows[0][2].ToString();
            fullName_app_box2.Text = table.Rows[0][3].ToString();
            date_p_app_box2.Text = table.Rows[0][4].ToString();
            number_app_box2.Text = table.Rows[0][5].ToString();
            dob_app_box2.Text = table.Rows[0][6].ToString();
            pob_app_box2.Text = table.Rows[0][7].ToString();
            date_y_app_box2.Text = table.Rows[0][8].ToString();
        }

        private void o_app_Click(object sender, EventArgs e)
        {

            String loginUser = login_app_box2.Text; // получаем данные от пользователя //


            DataBase db = new DataBase(); // создаём нужные объекты //

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE  FROM `application_seal` WHERE `login` = @uL", db.getConnection()); // ставим загрушки //
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; // вставляю в заглушку переменную //

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MessageBox.Show("Заявка отменена");



        }
    }
}
