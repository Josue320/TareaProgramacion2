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

namespace practicaDepreciacion.Presentaciones
{
    public partial class FrmEmpleados : Form
    {
        IEmpleadoService empleadoService;
        public FrmEmpleados(IEmpleadoService empleadoService)
        {
            this.empleadoService = empleadoService;
            InitializeComponent();
            cmbEstado.Items.AddRange(Enum.GetValues(typeof(EstadoEmpleado)).Cast<object>().ToArray());
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado()
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Cedula = txtCedula.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Estado = (EstadoEmpleado)cmbEstado.SelectedIndex
            };
            empleadoService.Add(empleado);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleadoService.Read();
        }

        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {

                return false;
            }
            return true;
        }

        private void limpiar()
        {
            this.txtNombre.Text = String.Empty;
            this.txtApellido.Text = String.Empty;
            this.txtDireccion.Text = String.Empty;
            this.txtCedula.Text = String.Empty;
            this.txtTelefono.Text = String.Empty;
            this.txtEmail.Text = String.Empty;
        }
    }
}
