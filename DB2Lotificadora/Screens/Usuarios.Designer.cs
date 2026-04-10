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
            this.btnLim = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbLote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.txBuscar.Location = new System.Drawing.Point(103, 414);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(347, 20);
            this.txBuscar.TabIndex = 5;
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(456, 414);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(770, 272);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(136, 23);
            this.btnLim.TabIndex = 8;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
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
            this.tbNombre.Location = new System.Drawing.Point(161, 125);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(469, 20);
            this.tbNombre.TabIndex = 16;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(56, 128);
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
            // 
            // btnCance
            // 
            this.btnCance.Location = new System.Drawing.Point(313, 329);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(136, 23);
            this.btnCance.TabIndex = 26;
            this.btnCance.Text = "Cancelar";
            this.btnCance.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(960, 91);
            this.dataGridView1.TabIndex = 27;
            // 
            // tbLote
            // 
            this.tbLote.Location = new System.Drawing.Point(164, 279);
            this.tbLote.Name = "tbLote";
            this.tbLote.Size = new System.Drawing.Size(220, 20);
            this.tbLote.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Lote";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(161, 99);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(469, 20);
            this.tbId.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Id";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.btnLim);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnLim;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbLote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label7;
    }
}