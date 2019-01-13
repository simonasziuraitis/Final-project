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
    public partial class NaujasReceptas : Form
    {
        public NaujasReceptas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Simas\source\repos\ApsipirkimoSkaiciuokle\Receptai.mdf;Integrated Security=True";
            using (SqlConnection sql = new SqlConnection(connection))
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    string querry = "INSERT INTO Receptai(ReceptoPavadinimas, Ingridientas, Kiekis, Vienetas) VALUES(@ReceptoPavadinimas, @Ingridientas, @Kiekis, @Vienetas)";
                    try
                    {
                        using (SqlCommand command = new SqlCommand(querry, sql))
                        {
                            command.Parameters.AddWithValue("@ReceptoPavadinimas", tbPavadinimas.Text);
                            command.Parameters.AddWithValue("@Ingridientas", dataGridView1.Rows[i].Cells[0].Value);
                            command.Parameters.AddWithValue("@Kiekis", dataGridView1.Rows[i].Cells[1].Value);
                            command.Parameters.AddWithValue("@Vienetas", dataGridView1.Rows[i].Cells[2].Value);
                            sql.Open();
                            command.ExecuteNonQuery();
                            sql.Close();
                            
                        }                      
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Iveskite reikiama informacija teisingai!");
                    }
                }
                MessageBox.Show("Receptas issaugotas!");
            }
        }
    }
}

