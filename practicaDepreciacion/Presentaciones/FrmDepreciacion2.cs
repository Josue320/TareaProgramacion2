using AppCore.IServices;
using Domain.Entities;
using Domain.Enum;
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
    public partial class FrmDepreciacion2 : Form
    {
        IActivoServices activoServices;
        IEmpleadoService empleadoService;
        private int idSeleccionado;
       


        public FrmDepreciacion2(IActivoServices ActivoServices, IEmpleadoService EmpleadoService)
        {
            this.activoServices = ActivoServices;
            this.empleadoService = EmpleadoService;
            InitializeComponent();
            
            cmbEstado.Items.AddRange(Enum.GetValues(typeof(EstadoActivo)).Cast<object>().ToArray());
            AgregarEmpleado();


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            List<Empleado> empleados = empleadoService.Read();
            int id = (int)cmbEmpleado.SelectedIndex;
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {

                EstadoActivo conversion = (EstadoActivo)cmbEstado.SelectedIndex;
                if (id == -1)
                {
                    Activo activo = new Activo()
                    {
                        Nombre = txtNombre.Text,
                        Valor = ((double)nudValor.Value),
                        ValorResidual = ((double)nudValorResidual.Value),
                        VidaUtil = ((int)nudVidaUtil.Value),
                        Estado = conversion.ToString()
                    };
                    activoServices.Add(activo);
                }
                else
                {
                    Activo activo = new Activo()
                    {
                        Nombre = txtNombre.Text,
                        Valor = ((double)nudValor.Value),
                        ValorResidual = ((double)nudValorResidual.Value),
                        VidaUtil = ((int)nudVidaUtil.Value),
                        Estado = conversion.ToString(),
                        Empleado = empleados[id]
                    };
                    activoServices.Add(activo);
                }
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }


        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || cmbEstado.SelectedIndex.Equals(-1))
            {

                return false;
            }
            return true;

        }

        private void limpiar()
        {
            this.txtNombre.Text = String.Empty;
            this.nudValor.Value = 0;
            this.nudValorResidual.Value = 0;
            this.nudVidaUtil.Value = 1;
            
        }

        private void FrmDepreciacion2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = activoServices.Read();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmDepreciar depreciacion = new FrmDepreciar(activoServices.Read()[e.RowIndex], activoServices, empleadoService);
                depreciacion.ShowDialog();

            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = activoServices.Read();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                //se puede cambiar a que solo reciba el id
                Activo activo = activoServices.GetById(idSeleccionado);
                if (activoServices.Delete(activo))
                {
                    MessageBox.Show($"El elemento con {idSeleccionado} fue exitosamente eliminado");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = activoServices.Read();
                }
                else
                {
                    MessageBox.Show("El elemento no fue eliminado correctamente");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado nada");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(idSeleccionado.ToString());

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

        public void AgregarEmpleado()
        {
             List<Empleado> empleados = empleadoService.Read();
            foreach (Empleado emp in empleados)
            {
                cmbEmpleado.Items.Add(emp.Nombres +" "+emp.Apellidos);
            }
        }



    }
}