﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Tiempos_Platillos : Form
    {
        public Tiempos_Platillos()
        {
            InitializeComponent();
        }

        public void crear_comanda(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            comanda.Show();
        }
    }
}
