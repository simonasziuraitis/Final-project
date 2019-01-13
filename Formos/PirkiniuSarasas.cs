using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApsipirkimoSkaiciuokle
{
    public partial class PirkiniuSarasas : Form
    {
        public PirkiniuSarasas()
        {
            InitializeComponent();
            var sarasas = new Sarasas();
            var skaiciuokle = new Skaiciuokle(sarasas.SukurtiPatiekaluSarasa());
            dataGridView1.DataSource = skaiciuokle.SuskaiciuotiProduktus();
 
        }
    }
}
