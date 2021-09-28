using ClasesActivos;
using ClasesActivos.Enums;
using ClasesActivos.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examenes
{
    public partial class FrmRegistrar : Form
    {
        public ActivoModel activos{ get;set;}
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(EnumsTipoActivo)).Cast<Object>().ToArray());

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se puede numeros");
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se puede numeros");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActivoFijo activo = new ActivoFijo()
            {
                codigo = txtCodigo.Text,
                descripcion = txtDescripcion.Text,
                FechaDeAdquisicion = dtpAdquision.Value,
                ValorActivo = upValorActivo.Value,
                ValorResidual = upValorResidual.Value,
                TipoActivo = (EnumsTipoActivo)cmbdepreciacion.SelectedItem,
                

            };
            activos.Add(activo);
        }

        private void Cmbdepreciacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdepreciacion.SelectedIndex == 0)
            {
                activos.SDA(activos.activos[0].ValorActivo, activos.activos[0].ValorResidual, activos.activos[0].TipoActivo);
            }
        }

        private void CmbTipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
