﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periodo2_1
{
    public partial class final : Form
    {
        public final(inicio_frm.datos informacion)
        {
            InitializeComponent();
            label2.Text = informacion.nombre;
        }

        private void final_Load(object sender, EventArgs e)
        {

        }
    }
}
