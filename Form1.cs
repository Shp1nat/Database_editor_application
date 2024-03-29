using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _3
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=sergeev;password=poi1lkj2MM;");
        int type = 0;
        public Form1()
        {
            InitializeComponent();      
        }

        private void knigi_Click(object sender, EventArgs e)
        {
            idKnigi.Visible= true;
            avtor_knigi.Visible= true;
            Nazvanie.Visible= true;
            dost_ekzemplyari.Visible= true;
            newNazvanie.Visible = true;
            newAvtor.Visible= true;
            newDE.Visible= true;
            iddd.Visible= true;
            LBavtor.Visible= true;
            LBde.Visible= true;
            LBnazvanie.Visible= true;

            idAvtor.Visible = false;
            imya.Visible= false;
            familiya.Visible= false;
            otchestvo.Visible= false;
            addImya.Visible= false;
            addFamiliya.Visible= false;
            addOtchestvo.Visible= false;
            LBimya.Visible = false;
            LBfamiliya.Visible= false;
            LBotchestvo.Visible= false;

            idFiliala.Visible= false;
            gorod.Visible= false;
            ylica.Visible= false;
            nomerDoma.Visible= false;
            addGorod.Visible= false;    
            addYlica.Visible= false;
            addNomerDoma.Visible = false;
            LBgorod.Visible = false;
            LBylica.Visible = false;
            LBdom.Visible = false;
            type = 1;
        }

        private void avtor_Click(object sender, EventArgs e)
        {
            idKnigi.Visible = false;
            avtor_knigi.Visible = false;
            Nazvanie.Visible = false;
            newNazvanie.Visible = false;
            newAvtor.Visible = false;
            dost_ekzemplyari.Visible = false;
            newDE.Visible = false;
            iddd.Visible = true;
            LBavtor.Visible = false;
            LBde.Visible = false;
            LBnazvanie.Visible = false;

            idAvtor.Visible = true;
            imya.Visible = true;
            familiya.Visible = true;
            otchestvo.Visible = true;
            addImya.Visible = true;
            addFamiliya.Visible = true;
            addOtchestvo.Visible = true;
            LBimya.Visible = true;
            LBfamiliya.Visible = true;
            LBotchestvo.Visible = true;

            idFiliala.Visible = false;
            gorod.Visible = false;
            ylica.Visible = false;
            nomerDoma.Visible = false;
            addGorod.Visible = false;
            addYlica.Visible = false;
            addNomerDoma.Visible = false;
            LBgorod.Visible = false;
            LBylica.Visible = false;
            LBdom.Visible = false;
            type = 2;
        }
        private void allClear()
        {
            idKnigi.Items.Clear();
            avtor_knigi.Items.Clear();
            Nazvanie.Items.Clear();
            idAvtor.Items.Clear();
            imya.Items.Clear();
            familiya.Items.Clear();
            otchestvo.Items.Clear();
            idFiliala.Items.Clear();
            gorod.Items.Clear();
            ylica.Items.Clear();
            nomerDoma.Items.Clear();
            dost_ekzemplyari.Items.Clear();
        }
        private void filial_Click(object sender, EventArgs e)
        {
            idKnigi.Visible = false;
            avtor_knigi.Visible = false;
            Nazvanie.Visible = false;
            newNazvanie.Visible = false;
            newAvtor.Visible = false;
            dost_ekzemplyari.Visible = false;
            newDE.Visible = false;
            iddd.Visible = true;
            LBavtor.Visible = false;
            LBde.Visible = false;
            LBnazvanie.Visible = false;

            idAvtor.Visible = false;
            imya.Visible = false;
            familiya.Visible = false;
            otchestvo.Visible = false;
            addImya.Visible = false;
            addFamiliya.Visible = false;
            addOtchestvo.Visible = false;
            LBimya.Visible = false;
            LBfamiliya.Visible = false;
            LBotchestvo.Visible = false;

            idFiliala.Visible = true;
            gorod.Visible = true;
            ylica.Visible = true;
            nomerDoma.Visible = true;
            addGorod.Visible = true;
            addYlica.Visible = true;
            addNomerDoma.Visible = true;
            LBgorod.Visible = true;
            LBylica.Visible = true;
            LBdom.Visible = true;
            type = 3;
        }

        private void update_Click(object sender, EventArgs e)
        {
            allClear();
            conn.Open();
            string query;
            MySqlCommand command;
            MySqlDataReader reader;
            switch (type)
            {
                case 1:
                    query = "SELECT * FROM книги";
                    command = new MySqlCommand(query, conn);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        idKnigi.Items.Add(reader[0].ToString());
                        avtor_knigi.Items.Add(reader[1].ToString());
                        Nazvanie.Items.Add(reader[2].ToString());
                        dost_ekzemplyari.Items.Add(reader[3].ToString());
                    }
                    reader.Close();
                    break;
                case 2:
                    query = "SELECT * FROM автор";
                    command = new MySqlCommand(query, conn);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        idAvtor.Items.Add(reader[0].ToString());
                        imya.Items.Add(reader[1].ToString());
                        familiya.Items.Add(reader[2].ToString());
                        otchestvo.Items.Add(reader[3].ToString());
                    }
                    reader.Close();
                    break;
                case 3:
                    query = "SELECT * FROM филиал";
                    command = new MySqlCommand(query, conn);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        idFiliala.Items.Add(reader[0].ToString());
                        gorod.Items.Add(reader[1].ToString());
                        ylica.Items.Add(reader[2].ToString());
                        nomerDoma.Items.Add(reader[3].ToString());
                    }
                    reader.Close();
                    break;
            }
            conn.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string query;
            MySqlCommand command;
            conn.Open();
            switch (type)
            {
                case 1:
                    query = "INSERT INTO книги(название, автор, доступные_экземпляры) VALUES('" + newAvtor.Text + "', '" + newNazvanie.Text + "', " + Convert.ToInt32(newDE.Text) + ");";
                    command  = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    break;
                case 2:
                    query = "INSERT INTO автор(имя, фамилия, отчество) VALUES('" + addImya.Text + "', '" + addFamiliya.Text + "', '" + addOtchestvo.Text + "');";
                    command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    break;
                case 3:
                    query = "INSERT INTO филиал(город, улица, номер_дома) VALUES('" + addGorod.Text + "', '" + addYlica.Text + "', " + Convert.ToInt32(addNomerDoma.Text) + ");";
                    command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    break;
            }
            conn.Close();
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            conn.Open();
            string idtodelete = deleteByInd.Text;
            string dl = "";
            switch (type)
            {
                case 1:
                    dl = "DELETE FROM книги WHERE(id_книги = '" + idtodelete + "'); " + "ALTER TABLE книги AUTO_INCREMENT = " + Convert.ToInt32(idtodelete) + ";";   
                    break;
                case 2:
                    dl = "DELETE FROM автор WHERE(id_автора = '" + idtodelete + "'); " + "ALTER TABLE автор AUTO_INCREMENT = " + Convert.ToInt32(idtodelete) + ";";
                    break;
                case 3:
                    dl = "DELETE FROM филиал WHERE(id_филиала = '" + idtodelete + "'); " + "ALTER TABLE филиал AUTO_INCREMENT = " + Convert.ToInt32(idtodelete) + ";";
                    break;
            }
            MySqlCommand command = new MySqlCommand(dl, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
