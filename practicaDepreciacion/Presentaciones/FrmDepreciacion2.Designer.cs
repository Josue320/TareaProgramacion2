
namespace practicaDepreciacion
{
    partial class FrmDepreciacion2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.nudVidaUtil = new System.Windows.Forms.NumericUpDown();
            this.nudValorResidual = new System.Windows.Forms.NumericUpDown();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblVidaUtil = new System.Windows.Forms.Label();
            this.lblValorResidual = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVidaUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorResidual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEmpleado);
            this.groupBox1.Controls.Add(this.lblEmpleado);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.nudVidaUtil);
            this.groupBox1.Controls.Add(this.nudValorResidual);
            this.groupBox1.Controls.Add(this.nudValor);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblVidaUtil);
            this.groupBox1.Controls.Add(this.lblValorResidual);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(193, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Activo";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(76, 141);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(103, 21);
            this.cmbEstado.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(5, 144);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(30, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(61, 198);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(50, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // nudVidaUtil
            // 
            this.nudVidaUtil.Location = new System.Drawing.Point(76, 118);
            this.nudVidaUtil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudVidaUtil.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudVidaUtil.Name = "nudVidaUtil";
            this.nudVidaUtil.Size = new System.Drawing.Size(103, 18);
            this.nudVidaUtil.TabIndex = 7;
            this.nudVidaUtil.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVidaUtil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudVidaUtil_KeyPress);
            // 
            // nudValorResidual
            // 
            this.nudValorResidual.Location = new System.Drawing.Point(76, 92);
            this.nudValorResidual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudValorResidual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValorResidual.Name = "nudValorResidual";
            this.nudValorResidual.Size = new System.Drawing.Size(103, 18);
            this.nudValorResidual.TabIndex = 6;
            this.nudValorResidual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudValorResidual_KeyPress);
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(76, 66);
            this.nudValor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(103, 18);
            this.nudValor.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(103, 18);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblVidaUtil
            // 
            this.lblVidaUtil.AutoSize = true;
            this.lblVidaUtil.Location = new System.Drawing.Point(5, 120);
            this.lblVidaUtil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVidaUtil.Name = "lblVidaUtil";
            this.lblVidaUtil.Size = new System.Drawing.Size(37, 13);
            this.lblVidaUtil.TabIndex = 3;
            this.lblVidaUtil.Text = "Vida Util:";
            // 
            // lblValorResidual
            // 
            this.lblValorResidual.AutoSize = true;
            this.lblValorResidual.Location = new System.Drawing.Point(5, 94);
            this.lblValorResidual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorResidual.Name = "lblValorResidual";
            this.lblValorResidual.Size = new System.Drawing.Size(57, 13);
            this.lblValorResidual.TabIndex = 2;
            this.lblValorResidual.Text = "Valor Residual:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(5, 68);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(26, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 43);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(34, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 221);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(440, 328);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(50, 23);
            this.btnRecargar.TabIndex = 5;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(260, 328);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(50, 23);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Delete";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(8, 174);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(40, 13);
            this.lblEmpleado.TabIndex = 11;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(76, 171);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(103, 21);
            this.cmbEmpleado.TabIndex = 12;
            // 
            // FrmDepreciacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(604, 375);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmDepreciacion2";
            this.Text = "FrmDepreciacion2";
            this.Load += new System.EventHandler(this.FrmDepreciacion2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVidaUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorResidual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown nudVidaUtil;
        private System.Windows.Forms.NumericUpDown nudValorResidual;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblVidaUtil;
        private System.Windows.Forms.Label lblValorResidual;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
    }
}