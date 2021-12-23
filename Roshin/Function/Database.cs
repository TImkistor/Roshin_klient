using MySql.Data.MySqlClient;
using System.Data;

namespace Roshin
{
    static class Database
    {
        static MySqlConnection connectionSec = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
        static MySqlConnection connectionFil = new MySqlConnection("server=127.0.0.1;database=operator; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");

        public static DataTable DR()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_SEC`, `FIO` AS `ФИО`, `FIONepolnoe` AS `Сокращено` , `Dolg` AS `Должность` , `Login` AS `Логин`, `Password` AS `Пароль` , `level` AS `Уровень` FROM `sec`"
          , connectionSec);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }

        public static DataTable VB()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT operator.ID_Client, operator.FIO AS `ФИО` , tip.Naim AS `Тип` , operator.Nomer AS `Номер` , operator.Source AS `Паспорт/ИНН` ,  packet.Naim AS `Пакет`, persoper.FIO AS `Оператор` , mejoper.Naim AS `Международные звон`, operator.Price AS `Цена` FROM operator INNER JOIN tip ON operator.ID_Tip = tip.ID_Tip INNER JOIN packet ON operator.ID_Paket = packet.ID_Packet INNER JOIN persoper ON operator.ID_Pers = persoper.ID_PersOper INNER JOIN mejoper ON operator.ID_Mejpoper = mejoper.ID_Mejpoper", connectionFil);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable MEJPOPER()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT mejoper.ID_Mejpoper, mejoper.Naim AS  `Нзвание`, mejoper.Price AS `Цена` FROM mejoper", connectionFil);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static  DataTable PACKET()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT packet.`ID_Packet`, packet.Naim AS `Название`, packet.Zvon AS `Звонки`, packet.Wifi AS `Интернет`, packet.Sms AS `СМС`, packet.Price AS `Цена` FROM packet", connectionFil);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;

        }

        public static DataTable PERSOPAPER()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT persoper.ID_PersOper, persoper.FIO AS `ФИО`, persoper.Kontakt AS `Контакты`, persoper.Price AS `Цена` FROM persoper", connectionFil);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable TIP()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT tip.ID_Tip , tip.Naim AS `Название` FROM tip", connectionFil);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
       
    }
}
