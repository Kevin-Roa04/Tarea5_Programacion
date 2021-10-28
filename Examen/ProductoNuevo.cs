using Appcore.Services;
using Dominio;
using Dominio.Enums;
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
    public partial class ProductoNuevo : Form
    {
        private IService<ActivoFijo> service;
        public ProductoNuevo(IService<ActivoFijo> service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int validacion = Verificar();
            if (validacion == 0)
            {
                MessageBox.Show("Por favor rellene toda la informacion", "Error por campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ActivoFijo Activo = new ActivoFijo()
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    ValorActivo = decimal.Parse(txtValorActivo.Text),
                    ValorResidual = decimal.Parse(txtValorResidual.Text),
                    FechaAdquisicion = dtpFechaAdquisicon.Value,
                    TipoActivo = (TipoActivo) cmbTipoActivo.SelectedIndex,
                    MetodosDepreciacion = (MetodosDepreciacion) cmbMetodoDepreciacion.SelectedIndex
                };
                service.Create(Activo);
            }
        }

        private int Verificar()
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtValorActivo.Text == "" || txtValorResidual.Text == ""
                || cmbTipoActivo.Text == "" || cmbMetodoDepreciacion.Text == "")
            {
                return 0;
            }
            return 1;
        }
    }
}
