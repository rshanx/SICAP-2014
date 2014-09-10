﻿using CapaEntidades.GestionSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaInterfaz.ci_GestionReportes
{
    public partial class frmReporteFaltas : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmReporteFaltas()
        {
            InitializeComponent();
        }
        public void setUser(Usuarios s, Permisos per)
        {
            user = s;
            permiso = per;
        }
        private void frmReporteFaltas_Load(object sender, EventArgs e)
        {

        }

        public Usuarios user { get; set; }

        public Permisos permiso { get; set; }
    }
}