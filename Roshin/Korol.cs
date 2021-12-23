using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Roshin
{
    public partial class Korol : Form
    {
        Point LastPoint;
        public Korol(Form1 form1)
        {
            InitializeComponent();
            listfio.Text = form1.User.FIONepolnoe;
            ReverseLabel(listfio);
            comboBox1.Items.Add("Пользователи");
            comboBox1.Items.Add("Оператор");
            comboBox1.Items.Add("Межоператор");
            comboBox1.Items.Add("Пакет");
            comboBox1.Items.Add("Персональный оператор");
            comboBox1.Items.Add("Тип");
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            ONE.Visible = false;
            TWO.Visible = false;
            THREE.Visible = false;
            FOUR.Visible = false;
            FIVE.Visible = false;
            SIX.Visible = false;
            SEVEN.Visible = false;
            ONEBOX.Visible = false;
            TWOBOX.Visible = false;
            THREEBOX.Visible = false;
            FOURBOX.Visible = false;
            CREATE.Visible = false;
            UPDATE.Visible = false;
            DELETE.Visible = false;
            FULL1.Visible = false;
            FULL2.Visible = false;
            FULL3.Visible = false;
            FULL4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            ONE.Text = "";
            TWO.Text = "";
            THREE.Text = "";
            FOUR.Text = "";
            FIVE.Text = "";
            SIX.Text = "";
            SEVEN.Text = "";
            ONEBOX.Text = "";
            TWOBOX.Text = "";
            THREE.Text = "";
            FOURBOX.Text = "";
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                FILDT.DataSource = Database.DR();
                FILDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = true;
                FIVE.Visible = true;
                SIX.Visible = true;
                SEVEN.Visible = true;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREE.Text = "";
                FOURBOX.Text = "";

            }

            if (comboBox1.SelectedItem as String == "Оператор")
            {
                FILDT.DataSource = Database.VB();
                FILDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = true;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = true;
                THREEBOX.Visible = true;
                FOURBOX.Visible = true;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                FULL1.Visible = true;
                FULL2.Visible = true;
                FULL3.Visible = true;
                FULL4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Text = "Тип";
                label3.Text = "Пакет";
                label4.Text = "Оператор";
                label5.Text = "Межоператор";
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREE.Text = "";
                FOURBOX.Text = "";
                MySqlConnection con1 = new MySqlConnection
               ("server= 127.0.0.1;database=operator; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tip", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "Naim";
                ONEBOX.ValueMember = "ID_Tip";

                MySqlConnection con2 = new MySqlConnection
               ("server= 127.0.0.1;database=operator; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da2 = new MySqlDataAdapter
                    ("Select * From packet", con2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                TWOBOX.DataSource = dt2;
                TWOBOX.DisplayMember = "Naim";
                TWOBOX.ValueMember = "ID_Packet";

                MySqlConnection con3 = new MySqlConnection
               ("server= 127.0.0.1;database=operator; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da3 = new MySqlDataAdapter
                    ("Select * From persoper", con3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                THREEBOX.DataSource = dt3;
                THREEBOX.DisplayMember = "FIO";
                THREEBOX.ValueMember = "ID_PersOper";

                MySqlConnection con4 = new MySqlConnection
               ("server= 127.0.0.1;database=operator; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da4 = new MySqlDataAdapter
                    ("Select * From mejoper", con4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                FOURBOX.DataSource = dt4;
                FOURBOX.DisplayMember = "Naim";
                FOURBOX.ValueMember = "ID_Mejpoper";

            }
            if (comboBox1.SelectedItem as String == "Межоператор")
            {
                FILDT.DataSource = Database.MEJPOPER();
                FILDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREE.Text = "";
                FOURBOX.Text = "";
            }
            if (comboBox1.SelectedItem as String == "Пакет")
            {
                FILDT.DataSource = Database.PACKET();
                FILDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = true;
                FIVE.Visible = true;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREE.Text = "";
                FOURBOX.Text = "";
            }
            if (comboBox1.SelectedItem as String == "Персональный оператор")
            {
                FILDT.DataSource = Database.PERSOPAPER();
                FILDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREE.Text = "";
                FOURBOX.Text = "";
            }
            if (comboBox1.SelectedItem as String == "Тип")
            {
                FILDT.DataSource = Database.TIP();
                FILDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREE.Text = "";
                FOURBOX.Text = "";
            }

        }

        private void ReverseLabel(Label label)
        {
            int witdh = label.Width;
            label.Location = new Point(label.Location.X - witdh, label.Location.Y);
            label.TextAlign = ContentAlignment.MiddleRight;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {

            LastPoint = new Point(e.X, e.Y);
        }
        int idd;
        public void SECDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idd = Convert.ToInt32(FILDT[0, e.RowIndex].Value);
            if (comboBox1.Text == "Пользователи")
            {
                int id = Convert.ToInt32(FILDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From sec " +
                    "where ID_SEC=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
                FOUR.Text = dt1.Rows[0][4].ToString();
                FIVE.Text = dt1.Rows[0][5].ToString();
                SIX.Text = dt1.Rows[0][6].ToString();
                SEVEN.Text = dt1.Rows[0][7].ToString();
            }
            if (comboBox1.Text == "Оператор")
            {
                int id = Convert.ToInt32(FILDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From operator " +
                    "where ID_Client=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();
                TWO.Text = dt1.Rows[0][3].ToString();
                THREE.Text = dt1.Rows[0][4].ToString();
                TWOBOX.SelectedValue = dt1.Rows[0][5].ToString();
                THREEBOX.SelectedValue = dt1.Rows[0][6].ToString();
                FOURBOX.SelectedValue = dt1.Rows[0][7].ToString();
                FOUR.Text = dt1.Rows[0][8].ToString();
            }
            if (comboBox1.Text == "Межоператор")
            {
                int id = Convert.ToInt32(FILDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From mejoper " +
                    "where ID_Mejpoper=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
            }
            if (comboBox1.Text == "Пакет")
            {
                int id = Convert.ToInt32(FILDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                    ("server=127.0.0.1;database=operator;Uid=Admin;Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From packet " +
                    "where ID_Packet=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
                FOUR.Text = dt1.Rows[0][4].ToString();
                FIVE.Text = dt1.Rows[0][5].ToString();
            }
            if (comboBox1.Text == "Персональный оператор")
            {
                int id = Convert.ToInt32(FILDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                    ("server=127.0.0.1;database=operator;Uid=Admin;Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From persoper " +
                    "where ID_PersOper=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
            }
            if (comboBox1.Text == "Тип")
            {
                int id = Convert.ToInt32(FILDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                    ("server=127.0.0.1;database=operator;Uid=Admin;Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tip " +
                    "where ID_Tip=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
            }

        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"Insert into security.sec(FIO,FIONepolnoe,Dolg,Login,Password,level,Mesto)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}', '{THREE.Text}', '{FOUR.Text}', '{FIVE.Text}', {SIX.Text}, '{SEVEN.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.DR();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Межоператор")
            {
                var q = $"Insert into operator.mejoper(Naim,Price)\n" +
                    $"values ('{ONE.Text}','{TWO.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.MEJPOPER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Оператор")
            {
                var q = $"Insert into operator.operator(FIO,ID_Tip,Nomer,Source,ID_Paket,ID_Pers,ID_Mejpoper,Price)\n" +
                    $"values ('{ONE.Text}','{ONEBOX.SelectedValue}', '{TWO.Text}', '{THREE.Text}', '{TWOBOX.SelectedValue}', '{THREEBOX.SelectedValue}', '{FOURBOX.SelectedValue}', '{FOUR.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.VB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Пакет")
            {
                var q = $"Insert into operator.packet(Naim, Zvon, Wifi, Sms, Price)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}', '{THREE.Text}', '{FOUR.Text}', '{FIVE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.PACKET();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Персональный оператор")
            {
                var q = $"Insert into operator.persoper(FIO,Kontakt,Price)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}', '{THREE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.PERSOPAPER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"Insert into operator.tip(Naim)\n" +
                    $"values ('{ONE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.TIP();

                }
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"UPDATE `sec` SET `FIO`='{ONE.Text}',`FIONepolnoe`='{TWO.Text}',`Dolg`='{THREE.Text}',`Login`='{FOUR.Text}',`Password`='{FIVE.Text}',`level`='{SIX.Text}',`Mesto`='{SEVEN.Text}' WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.DR();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Межоператор")
            {
                var q = $"UPDATE `mejoper` SET `Naim`='{ONE.Text}',`Price`='{TWO.Text}' WHERE ID_Mejpoper = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.MEJPOPER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Оператор")
            {

                var q = $"UPDATE `operator` SET `FIO`='{ONE.Text}', `ID_Tip`='{ONEBOX.SelectedValue}', `Nomer`='{TWO.Text}', `Source`='{THREE.Text}', `ID_Paket`='{TWOBOX.SelectedValue}', `ID_Pers`='{THREEBOX.SelectedValue}', `ID_Mejpoper`='{FOURBOX.SelectedValue}', `Price`='{FOUR.Text}' WHERE ID_Client = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.VB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Пакет")
            {
                var q = $"UPDATE `packet` SET `Naim`='{ONE.Text}', `Zvon`='{TWO.Text}', `Wifi`='{THREE.Text}', `Sms`='{FOUR.Text}', `Price`='{FIVE.Text}' WHERE ID_Packet = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.PACKET();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Персональный оператор")
            {
                var q = $"UPDATE `persoper` SET `FIO`='{ONE.Text}', `Kontakt`='{TWO.Text}', `Price`='{THREE.Text}' WHERE ID_PersOper = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.PERSOPAPER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"UPDATE `tip` SET `Naim`='{ONE.Text}' WHERE ID_Tip = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.TIP();

                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"DELETE FROM `sec` WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.DR();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Межоператор")
            {
                var q = $"DELETE FROM `mejoper` WHERE ID_Mejpoper = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.MEJPOPER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Оператор")
            {

                var q = $"DELETE FROM `operator` WHERE ID_Client = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.VB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Пакет")
            {
                var q = $"DELETE FROM `packet` WHERE ID_Packet = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.PACKET();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Персональный оператор")
            {
                var q = $"DELETE FROM `persoper` WHERE ID_PersOper = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.PERSOPAPER();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"DELETE FROM `tip` WHERE ID_Tip = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FILDT.DataSource = Database.TIP();

                }
            }
        }
    }
}
