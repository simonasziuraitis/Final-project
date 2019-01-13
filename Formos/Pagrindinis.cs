using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApsipirkimoSkaiciuokle
{
    public partial class Pagrindinis : Form
    {
        public Pagrindinis()
        {
            InitializeComponent();
            UzpildytiNustatymus();
            SukuriDataGridViewMitybosPlanas();
        }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Simas\source\repos\ApsipirkimoSkaiciuokle\Receptai.mdf;Integrated Security=True";

        //PAGRINDINIAI MYGTUKAI

        private void buttonMitybosPlanas_Click(object sender, EventArgs e)
        {
            groupBoxReceptai.Hide();
            groupBoxNustatymai.Hide();
            groupBoxMitybosPlanas.Show();
            dataGridViewMitybosPlanas.Columns.Clear();
            SukuriDataGridViewMitybosPlanas();
        }

        private void buttonReceptai_Click(object sender, EventArgs e)
        {
            groupBoxMitybosPlanas.Hide();
            groupBoxNustatymai.Hide();
            groupBoxReceptai.Show();
        }

        private void buttonNustatymai_Click(object sender, EventArgs e)
        {
            groupBoxMitybosPlanas.Hide();
            groupBoxReceptai.Hide();
            groupBoxNustatymai.Show();
            UzpildytiNustatymus();
        }

        //GROUPBOX RECEPTAI COMBOBOX
        private void comboBoxReceptaiReceptoPavadinimas_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxReceptaiReceptoPavadinimas.Items.Clear();
            SqlConnection sql = new SqlConnection(connection);
            try
            {
                string querry = @"SELECT DISTINCT (ReceptoPavadinimas) FROM Receptai";
                using (SqlCommand command = new SqlCommand(querry, sql))
                {
                    sql.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string sPavadinimas = reader["ReceptoPavadinimas"].ToString();
                        comboBoxReceptaiReceptoPavadinimas.Items.Add(sPavadinimas);
                    }
                    sql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxReceptaiReceptoPavadinimas_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();

                string pasirinkimas = comboBoxReceptaiReceptoPavadinimas.Text;
                string querry = @"SELECT Ingridientas, Kiekis, Vienetas FROM Receptai WHERE ReceptoPavadinimas ='" + pasirinkimas + "'";

                SqlDataAdapter sqlData = new SqlDataAdapter(querry, sql);
                DataTable dataTable = new DataTable();

                sqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        //GROUPBOX RECEPTAI MYGTUKAI
        private void buttonReceptaiNaujas_Click(object sender, EventArgs e)
        {
            NaujasReceptas form2 = new NaujasReceptas();
            form2.Show();
        }

        private void buttonReceptaiAtnaujinti_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(connection);
            string querry = @"DELETE FROM Receptai WHERE Receptopavadinimas = '" + comboBoxReceptaiReceptoPavadinimas.Text + "';";
            using (SqlCommand command = new SqlCommand(querry, sql))
            {
                sql.Open();
                command.ExecuteNonQuery();
                sql.Close();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    string querry2 = "INSERT INTO Receptai(ReceptoPavadinimas, Ingridientas, Kiekis, Vienetas) VALUES(@ReceptoPavadinimas, @Ingridientas, @Kiekis, @Vienetas)";

                    using (SqlCommand command1 = new SqlCommand(querry2, sql))
                    {
                        command1.Parameters.AddWithValue("@ReceptoPavadinimas", comboBoxReceptaiReceptoPavadinimas.Text);
                        command1.Parameters.AddWithValue("@Ingridientas", dataGridView1.Rows[i].Cells[0].Value);
                        command1.Parameters.AddWithValue("@Kiekis", dataGridView1.Rows[i].Cells[1].Value);
                        command1.Parameters.AddWithValue("@Vienetas", dataGridView1.Rows[i].Cells[2].Value);

                        sql.Open();
                        command1.ExecuteNonQuery();
                        sql.Close();
                    }
                }
                MessageBox.Show("Receptas atnaujintas!");
                dataGridViewMitybosPlanas.Columns.Clear();
                SukuriDataGridViewMitybosPlanas();
            }
        }

        private void buttonReceptaiIstrinti_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(connection);
            string querry = "DELETE FROM Receptai WHERE ReceptoPavadinimas ='" + comboBoxReceptaiReceptoPavadinimas.Text + "'";
            using (SqlCommand command = new SqlCommand(querry, sql))
            {
                sql.Open();
                command.ExecuteNonQuery();
                sql.Close();
            }
            MessageBox.Show("Receptas Istrintas");
            comboBoxReceptaiReceptoPavadinimas.Text = null;
            dataGridViewMitybosPlanas.Columns.Clear();
            SukuriDataGridViewMitybosPlanas();
        }

        private void buttonReceptaiIstrintiEilute_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Pasirinkimas istrintas!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Negalima istrinti tuscios eilutes!");
            }
        }

        //GROUPBOX MITYBOS PLANAS
        private void buttonMitybosPlanasSkaiciuoti_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(connection))
                {
                    //ISTRINAMA IR SUKURIAMA NAUJA TUSCIA LENTELE PLANAS
                    string querry1 = "DROP TABLE Planas;CREATE TABLE Planas (Diena INT, Receptas NVARCHAR(50), Porcijos FLOAT(53))";
                    SqlCommand command1 = new SqlCommand(querry1, sql);
                    sql.Open();
                    command1.ExecuteNonQuery();
                    sql.Close();

                    //IRASOMA INFORMACIJA IS DATAGRIDVIEWMITYBOSPLANAS I TUSCIA LENTELE
                    sql.Open();
                    for (int i = 0; i < dataGridViewMitybosPlanas.RowCount - 1; i++)
                    {
                        string querry2 = "INSERT INTO Planas(Diena, Receptas, Porcijos) VALUES(@Diena, @Receptas, @Porcijos)";

                        using (SqlCommand command = new SqlCommand(querry2, sql))
                        {
                            command.Parameters.AddWithValue("@Diena", dataGridViewMitybosPlanas.Rows[i].Cells[0].Value);
                            command.Parameters.AddWithValue("@Receptas", dataGridViewMitybosPlanas.Rows[i].Cells[1].Value);
                            command.Parameters.AddWithValue("@Porcijos", dataGridViewMitybosPlanas.Rows[i].Cells[2].Value);

                            command.ExecuteNonQuery();
                        }
                    }
                    sql.Close();
                }

                //ATIDARO NAUJA LANGA IR SUDARO PIRKINIUS
                PirkiniuSarasas form1 = new PirkiniuSarasas();
                form1.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Uzpildykite visa reikiama informacija teisingai!");
            }          
        }

        private void buttonMitybosPlanasIstrinti_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewMitybosPlanas.SelectedRows)
                {
                    dataGridViewMitybosPlanas.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Pasirinkimas istrintas!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Negalima istrinti tuscios eilutes!");
            } 
        }

        private void buttonMitybosPlanasIstrintiPlana_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(connection);
            string querry = "DROP TABLE Planas;CREATE TABLE Planas (Diena INT, Receptas NVARCHAR(50), Porcijos FLOAT(53))";
            SqlCommand command = new SqlCommand(querry, sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
            dataGridViewMitybosPlanas.Columns.Clear();
            SukuriDataGridViewMitybosPlanas();
            MessageBox.Show("Planas istrintas!");
        }

        //GROUPBOX NUSTATYMAI
        private void buttonAtnaujintiNustatymus_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(connection);
            string querry = "UPDATE Nustatymai SET DienuSkaicius=@DienuSkaicius, PorcijuSkaicius=@PorcijuSkaicius";
            try
            {
                DialogResult dialogResult = MessageBox.Show("Atnaujinus nustatymus mitybos planas bus istrintas! Testi?", "Ispejimas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand(querry, sql);
                    command.Parameters.AddWithValue("@DienuSkaicius", int.Parse(textBoxNustatymaiDienuSkaicius.Text));
                    command.Parameters.AddWithValue("@PorcijuSkaicius", int.Parse(textBoxNustatymaiPorcijuKiekis.Text));
                    sql.Open();
                    command.ExecuteNonQuery();
                    sql.Close();
                    dataGridViewMitybosPlanas.Columns.Clear();
                    SukuriDataGridViewMitybosPlanas();
                    MessageBox.Show("Nustatymai atnaujinti!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                } 
            }
            catch (Exception)
            {
                MessageBox.Show("Iveskite teisinga informacija!");
            }
        }

        //PAPILDOMI METODAI
        private void UzpildytiNustatymus()
        {
            SqlConnection sql = new SqlConnection(connection);
            string querry = "SELECT * FROM Nustatymai";

            SqlCommand command = new SqlCommand(querry, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBoxNustatymaiDienuSkaicius.Text = reader["DienuSkaicius"].ToString();
                textBoxNustatymaiPorcijuKiekis.Text = reader["PorcijuSkaicius"].ToString();
            }
            sql.Close();
        }

        public void SukuriDataGridViewMitybosPlanas()
        {
            DataTable table = new DataTable();
            dataGridViewMitybosPlanas.DataSource = table;

            DataGridViewComboBoxColumn dcombo1 = new DataGridViewComboBoxColumn();
            dcombo1.HeaderText = "Diena";


            for (int i = 1; i <= int.Parse(textBoxNustatymaiDienuSkaicius.Text); i++)
            {
                dcombo1.Items.Add(i.ToString());
            }

            DataGridViewComboBoxColumn dcombo2 = new DataGridViewComboBoxColumn();
            dcombo2.HeaderText = "Receptas";

            SqlConnection sql = new SqlConnection(connection);
            string querry = @"SELECT DISTINCT (ReceptoPavadinimas) FROM Receptai";
            SqlCommand command = new SqlCommand(querry, sql);

            sql.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dcombo2.Items.Add(reader.GetString(0));
            }
            sql.Close();

            DataGridViewComboBoxColumn dcombo3 = new DataGridViewComboBoxColumn();
            dcombo3.HeaderText = "Porcijos";

            for (int i = 1; i <= int.Parse(textBoxNustatymaiPorcijuKiekis.Text); i++)
            {
                dcombo3.Items.Add(i.ToString());
            }

            dataGridViewMitybosPlanas.Columns.Add(dcombo1);
            dataGridViewMitybosPlanas.Columns.Add(dcombo2);
            dataGridViewMitybosPlanas.Columns.Add(dcombo3);
        }
    }
}

