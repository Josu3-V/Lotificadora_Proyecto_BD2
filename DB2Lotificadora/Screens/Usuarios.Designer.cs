namespace DB2Lotificadora.Screens
{
    partial class Usuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNuevoUser = new System.Windows.Forms.Button();
            this.tbIngresoMensual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.btnActua = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnGuar = new System.Windows.Forms.Button();
            this.btnCance = new System.Windows.Forms.Button();
            this.dgvClientesf = new System.Windows.Forms.DataGridView();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDeuda = new System.Windows.Forms.TextBox();
            this.deuda = new System.Windows.Forms.Label();
            this.tbEvaluacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesf)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(60, 28);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(72, 37);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Atras";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB2Lotificadora.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(382, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIOS";
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(102, 379);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(347, 20);
            this.txBuscar.TabIndex = 5;
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(455, 379);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btNuevoUser
            // 
            this.btNuevoUser.Location = new System.Drawing.Point(770, 128);
            this.btNuevoUser.Name = "btNuevoUser";
            this.btNuevoUser.Size = new System.Drawing.Size(136, 23);
            this.btNuevoUser.TabIndex = 9;
            this.btNuevoUser.Text = "Nuevo Usuario";
            this.btNuevoUser.UseVisualStyleBackColor = true;
            this.btNuevoUser.Click += new System.EventHandler(this.btNuevoUser_Click);
            // 
            // tbIngresoMensual
            // 
            this.tbIngresoMensual.Location = new System.Drawing.Point(161, 238);
            this.tbIngresoMensual.Name = "tbIngresoMensual";
            this.tbIngresoMensual.Size = new System.Drawing.Size(220, 20);
            this.tbIngresoMensual.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ingreso Mensual";
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.Location = new System.Drawing.Point(161, 201);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(220, 20);
            this.tbEmpresa.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Empresa/Empleo";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(161, 162);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(469, 20);
            this.tbDireccion.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Direccion";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(319, 128);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(390, 20);
            this.tbNombre.TabIndex = 16;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(261, 133);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(44, 13);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.Text = "Nombre";
            // 
            // btnActua
            // 
            this.btnActua.Location = new System.Drawing.Point(770, 177);
            this.btnActua.Name = "btnActua";
            this.btnActua.Size = new System.Drawing.Size(136, 23);
            this.btnActua.TabIndex = 23;
            this.btnActua.Text = "Actualizar";
            this.btnActua.UseVisualStyleBackColor = true;
            this.btnActua.Click += new System.EventHandler(this.btnActua_Click);
            // 
            // btnElim
            // 
            this.btnElim.Location = new System.Drawing.Point(770, 221);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(136, 23);
            this.btnElim.TabIndex = 24;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnGuar
            // 
            this.btnGuar.Location = new System.Drawing.Point(59, 329);
            this.btnGuar.Name = "btnGuar";
            this.btnGuar.Size = new System.Drawing.Size(136, 23);
            this.btnGuar.TabIndex = 25;
            this.btnGuar.Text = "Guardar";
            this.btnGuar.UseVisualStyleBackColor = true;
            this.btnGuar.Click += new System.EventHandler(this.btnGuar_Click);
            // 
            // btnCance
            // 
            this.btnCance.Location = new System.Drawing.Point(313, 329);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(136, 23);
            this.btnCance.TabIndex = 26;
            this.btnCance.Text = "Cancelar";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // dgvClientesf
            // 
            this.dgvClientesf.AllowUserToAddRows = false;
            this.dgvClientesf.AllowUserToDeleteRows = false;
            this.dgvClientesf.AllowUserToOrderColumns = true;
            this.dgvClientesf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesf.Location = new System.Drawing.Point(12, 433);
            this.dgvClientesf.Name = "dgvClientesf";
            this.dgvClientesf.ReadOnly = true;
            this.dgvClientesf.Size = new System.Drawing.Size(960, 116);
            this.dgvClientesf.TabIndex = 27;
            this.dgvClientesf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesf_CellContentClick);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(489, 205);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(220, 20);
            this.tbTelefono.TabIndex = 29;
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(412, 208);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 28;
            this.Telefono.Text = "Telefono";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(164, 130);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(59, 20);
            this.tbId.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Id";
            // 
            // tbDeuda
            // 
            this.tbDeuda.Location = new System.Drawing.Point(162, 278);
            this.tbDeuda.Name = "tbDeuda";
            this.tbDeuda.ReadOnly = true;
            this.tbDeuda.Size = new System.Drawing.Size(220, 20);
            this.tbDeuda.TabIndex = 33;
            // 
            // deuda
            // 
            this.deuda.AutoSize = true;
            this.deuda.Location = new System.Drawing.Point(57, 281);
            this.deuda.Name = "deuda";
            this.deuda.Size = new System.Drawing.Size(96, 13);
            this.deuda.TabIndex = 32;
            this.deuda.Text = "Deudad Pendiente";
            // 
            // tbEvaluacion
            // 
            this.tbEvaluacion.Location = new System.Drawing.Point(517, 282);
            this.tbEvaluacion.Name = "tbEvaluacion";
            this.tbEvaluacion.ReadOnly = true;
            this.tbEvaluacion.Size = new System.Drawing.Size(220, 20);
            this.tbEvaluacion.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Evaluacion de Pago";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tbEvaluacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDeuda);
            this.Controls.Add(this.deuda);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.dgvClientesf);
            this.Controls.Add(this.btnCance);
            this.Controls.Add(this.btnGuar);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnActua);
            this.Controls.Add(this.tbIngresoMensual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btNuevoUser);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txBuscar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "btnLimpiar";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNuevoUser;
        private System.Windows.Forms.TextBox tbIngresoMensual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Button btnActua;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnGuar;
        private System.Windows.Forms.Button btnCance;
        private System.Windows.Forms.DataGridView dgvClientesf;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDeuda;
        private System.Windows.Forms.Label deuda;
        private System.Windows.Forms.TextBox tbEvaluacion;
        private System.Windows.Forms.Label label8;
    }
}