﻿using System;
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

            table.Rows.Add("Mikec" + ", " + "Mirko", "Muškarac",
                "15.prosinca 1989",
                "Zagreb" + ","
                + "Hrvatska");
            table.Rows.Add("Riba" + ", " + "Pero", "Muškarac", "5.rujna 1992", "Karlovac" + ", " + "Hrvatska");
            table.Rows.Add("Kvržica" + ", " + "Perica", "Muškarac", "5.siječnja 1998", "Samobor" + ", " + "Hrvatska");
            table.Rows.Add("Marić" + ", " + "Mare", "Muško", "25.prosinca 1999", "Glina" + ", " + "Hrvatska");
            table.Rows.Add("Tinoslav" + ", " + "Tino", "Muškarac", "5.siječnja 1997", "Split" + ", " + "Hrvatska");
            table.Rows.Add("Domagojević" + ", " + "Domagoj", "Muškarac", "16.siječnja 1996", "Zagreb" + ", " + "Hrvatska");
            table.Rows.Add("Anić" + ", " + "Ana", "Žena", "5.siječnja 1993", "Ogulin" + ", " + "Hrvatska");
            table.Rows.Add("Filipović" + ", " + "Filip", "Muškarac", "5.prosinca 1997", "Varaždin" + ", " + "Hrvatska");
            table.Rows.Add("Petrarca" + ", " + "Patrik", "Muškarac", "6.siječnja 1994", "Zagreb" + ", " + "Hrvatska");
            table.Rows.Add("Makedonski" + ", " + "Aleksandar", "Muškarac", "18.siječnja 1968", "Zagreb" + ", " + "Hrvatska");
            table.Rows.Add("Krešimirović" + ", " + "Krešimir", "Muškarac", "5.siječnja 1989", "Zagreb" + ", " + "Hrvatska");
            table.Rows.Add("Bunar" + ", " + "Zdenka", "Žena", "5.siječnja 1956", "Osijek" + ", " + "Hrvatska");
            table.Rows.Add("Virginia" + ", " + "Anamarija", "Muško", "17.siječnja 1987", "Osijek" + ", " + "Hrvatska");
            table.Rows.Add("Romanovska" + ", " + "Patricija", "Žena", "5.prosinca 1990", "Zagreb" + ", " + "Hrvatska");
            table.Rows.Add("Brane" + ", " + "Branislav", "Muškarac", "5.siječnja 1997", "Rijeka" + ", " + "Hrvatska");
            table.Rows.Add("Kraljević" + ", " + "Krunoslav", "Muškarac", "5.svibnja 1995", "Dubrovnik" + ", " + "Hrvatska");
            table.Rows.Add("Svetlana" + ", " + "Tanja", "Žena", "13.srpnja 1990", "Zagreb" + ", " + "Hrvatska");
            table.Rows.Add("Knez" + ", " + "Borna", "Muškarac", "1.siječnja 1990", "Sisak" + ", " + "Hrvatska");

            dataGridView1.DataSource = table;
        }
    }
}
