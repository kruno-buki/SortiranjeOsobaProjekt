using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortiranjeOsobaSeminarskiRad
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {//klik na međuprostor

            table.Columns.Add("Ime i Prezime", typeof(string));
            table.Columns.Add("Spol", typeof(string));
            table.Columns.Add("Datum rođenja", typeof(DateTime));
            table.Columns.Add("Mjesto rođenje ", typeof(string));
        }
    }
}
