using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySQLapp.Utils;

namespace Roshin
{
    public partial class Form1 : Form
    {
        Point LastPoint;
        public Form1()
        {

            {
                InitializeComponent();
                this.password.AutoSize = false;
                this.password.Size = new Size(this.password.Size.Width, this.login.Size.Height);
                login.Text = "Введите логин";
                login.ForeColor = Color.Gray;
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
                button1.BackColor = Color.Gray;
                this.button1.BackColor = Color.Gray;
                updateButtonTheme();

            }
        }

        public User User { get; private set; }

        private void updateButtonTheme()
        {
            if (this.login.ForeColor == Color.Black && this.password.ForeColor == Color.Black && this.checkBox1.Checked)
            {
                this.button1.BackColor = Color.LightGray;
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.BackColor = Color.Gray;
                this.button1.Enabled = false;
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (!this.checkBox1.Checked)
            {
                return;
            }
            var loginuser = login.Text;
            var passworduser = password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `sec` WHERE `login` = @ul AND `Password` = @up", DatabaseManager.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passworduser;


            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                {
                    System.Console.WriteLine(table.Rows[i].ToString());

                }
                User = new User(Convert.ToUInt16(table.Rows[0][0]), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString(), table.Rows[0][4].ToString(), table.Rows[0][5].ToString(), table.Rows[0][6].ToString(), table.Rows[0][7].ToString());
                Form Form1 = new Korol(this);
                Form1.Show();
                this.Hide();
            }
            else
            {
                if (l2.Visible == false)
                {
                    this.l2.Visible = true;
                }
                else
                {
                    this.l2.Visible = false;
                    this.l2.Visible = true;
                }
                if (l1.Visible == false)
                {
                    this.l1.Visible = true;
                }
                else
                {
                    this.l1.Visible = false;
                    this.l1.Visible = true;
                }


                this.login.Text = "Введите логин";
                this.password.Text = "Введите пароль";
                this.password.UseSystemPasswordChar = false;
                this.password.ForeColor = Color.Gray;
                this.login.ForeColor = Color.Gray;
                this.checkBox1.Checked = false;
                this.checkBox1.Checked = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка открытия ссылки.");
            }
        }

        private void VisitLink()
        {
            tt1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/189C_INb1NZOKDjGXHlAOjnVBV22nLKTx2vqAirUQQos/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink2();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка открытия ссылки.");
            }
        }
        private void VisitLink2()
        {
            tt2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://policies.google.com/terms");
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);

        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Введите логин")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {

                login.Text = "Введите логин";
                login.ForeColor = Color.Gray;

            }
            updateButtonTheme();


        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                this.password.UseSystemPasswordChar = true;
            }
            updateButtonTheme();

        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                this.password.UseSystemPasswordChar = false;
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
            }
            updateButtonTheme();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateButtonTheme();
        }
    }
}

