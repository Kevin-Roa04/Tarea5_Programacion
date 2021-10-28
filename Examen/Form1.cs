using Appcore.Services;
using Dominio;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        private IService<ActivoFijo> service;
        public Form1(IService<ActivoFijo> service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ProductoNuevo frmNuevo = new ProductoNuevo(service);
            frmNuevo.ShowDialog();

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            rtbMostrar.Text += service.FindAll();
        }
    }
}
