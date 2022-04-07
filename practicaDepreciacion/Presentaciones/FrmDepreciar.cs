using AppCore.Factories;
using AppCore.IServices;
using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class FrmDepreciar : Form
    {
        private Activo activo;
        IActivoServices activoServices;
        public FrmDepreciar(Activo Activo, IActivoServices activoServices)
        {
            this.activo = Activo;
            this.activoServices = activoServices;
            InitializeComponent();
            cmbMetodo.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());
            cmbEstado.Items.AddRange(Enum.GetValues(typeof(EstadoActivo)).Cast<object>().ToArray());
        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbDatos.Text = String.Empty;
            double total = 0;
            IDepreciacionModel depreciacion = FactoryDeducciones.FactoryDepreciacion((Depreciacion)cmbMetodo.SelectedIndex);
            List<double> depreciaciones = depreciacion.Depreciacion(activo);
            for (int i = 0; i < depreciaciones.Count; i++)
            {
                rtbDatos.Text += $"Depreciacion: {i + 1}: {depreciaciones[i]}\n";
                total += depreciaciones[i];
            }
            rtbDatos.Text += $"Total: {total}\n";
            rtbDatos.Text += $"Valor residual: {activo.ValorResidual}";
        }

      
        private void FrmDepreciar_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool verificado = verificar();
            EstadoActivo conversion = (EstadoActivo)cmbEstado.SelectedIndex;
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            Activo activo2 = new Activo()
            {
                Nombre = txtNombre.Text,
                Valor = ((double)nudValor.Value),
                ValorResidual = ((double)nudValorResidual.Value),
                VidaUtil = ((int)nudVidaUtil.Value),
                Id = activo.Id,
                Estado = conversion.ToString(),

            };
            activoServices.Update(activo2);
            MessageBox.Show("El update ha sido realizado con exito");
            this.Close();
        }
        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {

                return false;
            }
            return true;
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                lblNombre.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(txtNombre.Text))
            {

                lblNombre.ForeColor = Color.Black;

            }
            else
            {

                lblNombre.ForeColor = Color.Green;

            }
        }

        private void nudValor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
                lblValor.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(nudValor.Text))
            {

                lblValor.ForeColor = Color.Black;

            }
            else
            {

                lblValor.ForeColor = Color.Green;

            }

        }

        private void nudValorResidual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
                lblValorResidual.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(nudValorResidual.Text))
            {

                lblValorResidual.ForeColor = Color.Black;

            }
            else
            {

                lblValorResidual.ForeColor = Color.Green;


            }
        }

        private void nudVidaUtil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                lblVidaUtil.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(nudVidaUtil.Text))
            {

                lblVidaUtil.ForeColor = Color.Black;


            }
            else
            {

                lblVidaUtil.ForeColor = Color.Green;

            }

        }
    }

}