﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LagerApp_final_
{
    public partial class OrdreMenu : Form
    {
        public OrdreMenu()
        {
            InitializeComponent();
            

        }

        public void buttonOrdreSearch_Click(object sender, EventArgs e)
        {
            int OrdreID = int.Parse(textBox1.Text);
            var ordreListe = Program.Database.ReadOrdre(OrdreID);
            dataGridViewOrdre.DataSource = ordreListe;
        }

    }
}