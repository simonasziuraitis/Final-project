using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ApsipirkimoSkaiciuokle
{
    class Sarasas
    {
        public Sarasas()
        {

        }

        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Simas\source\repos\ApsipirkimoSkaiciuokle\Receptai.mdf;Integrated Security=True";
        

        public List<Patiekalas> SukurtiPatiekaluSarasa()
        {
            SqlConnection sql = new SqlConnection(connection);
            string querry = @"SELECT Planas.Receptas, Receptai.Ingridientas, Receptai.Kiekis, Receptai.Vienetas, Planas.Porcijos FROM Planas RIGHT JOIN Receptai ON Planas.Receptas = Receptai.ReceptoPavadinimas WHERE Planas.Receptas IS NOT NULL;";
            SqlCommand command = new SqlCommand(querry, sql);
            sql.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Patiekalas> patiekaluSarasas = new List<Patiekalas>();

            while (reader.Read())
            {
                patiekaluSarasas.Add(new Patiekalas(reader.GetString(0), new List<Ingridientas>() { new Ingridientas(reader.GetString(1), (reader.GetDouble(2) * reader.GetDouble(4)), reader.GetString(3)) }));
            }
            sql.Close();

            return patiekaluSarasas;
        }

       
    }
}
