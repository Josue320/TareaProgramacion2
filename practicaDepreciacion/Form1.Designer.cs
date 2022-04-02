
namespace practicaDepreciacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistroEmpleado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnRegistroEmpleado);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 402);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(52, 334);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(52, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Acerca de";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegistro.Location = new System.Drawing.Point(52, 136);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(62, 27);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo Depreciación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Location = new System.Drawing.Point(173, -1);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(592, 402);
            this.panelContenedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "BIENVENIDO";
            // 
            // btnRegistroEmpleado
            // 
            this.btnRegistroEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegistroEmpleado.Location = new System.Drawing.Point(52, 202);
            this.btnRegistroEmpleado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegistroEmpleado.Name = "btnRegistroEmpleado";
            this.btnRegistroEmpleado.Size = new System.Drawing.Size(62, 27);
            this.btnRegistroEmpleado.TabIndex = 2;
            this.btnRegistroEmpleado.Text = "Empleado";
            this.btnRegistroEmpleado.UseVisualStyleBackColor = false;
            this.btnRegistroEmpleado.Click += new System.EventHandler(this.btnRegistroEmpleado_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 399);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Principal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistroEmpleado;
    }
}