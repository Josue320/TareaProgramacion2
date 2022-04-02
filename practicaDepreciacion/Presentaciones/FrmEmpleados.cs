﻿using AppCore.IServices;
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
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {

                EstadoEmpleado conversion = (EstadoEmpleado)cmbEstado.SelectedIndex;
                Empleado empleado = new Empleado()
                {
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Cedula = txtCedula.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Estado = conversion.ToString(),
                };
                empleadoService.Add(empleado);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = empleadoService.Read();
            }
        }

        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrEmpty(txtEmail.Text) || cmbEstado.SelectedIndex.Equals(-1))
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                lblApellido.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(txtApellido.Text))
            {
                lblApellido.ForeColor = Color.Black;

            }
            else
            {

                lblApellido.ForeColor = Color.Green;

            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                lblCedula.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(txtCedula.Text))
            {

                lblCedula.ForeColor = Color.Black;

            }
            else
            {

                lblCedula.ForeColor = Color.Green;

            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                lblDireccion.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(txtDireccion.Text))
            {

                lblDireccion.ForeColor = Color.Black;

            }
            else
            {

                lblDireccion.ForeColor = Color.Green;

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                lblTelefono.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(txtTelefono.Text))
            {

                lblTelefono.ForeColor = Color.Black;

            }
            else
            {

                lblTelefono.ForeColor = Color.Green;

            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                lblEmail.ForeColor = Color.Red;

            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {

                lblEmail.ForeColor = Color.Black;

            }
            else
            {

                lblEmail.ForeColor = Color.Green;

            }
        }
    }
}