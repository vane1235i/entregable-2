namespace Sistema_de_adopcion_de_mascotas
{
    partial class ADOPTANTES
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdAdoptante = new System.Windows.Forms.Label();
            this.lblDirecccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtIdAdoptante = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvAdoptantes = new System.Windows.Forms.DataGridView();
            this.btnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoptantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(192, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR NUEVO ADOPTANTE";
            // 
            // lblIdAdoptante
            // 
            this.lblIdAdoptante.AutoSize = true;
            this.lblIdAdoptante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAdoptante.Location = new System.Drawing.Point(25, 127);
            this.lblIdAdoptante.Name = "lblIdAdoptante";
            this.lblIdAdoptante.Size = new System.Drawing.Size(105, 18);
            this.lblIdAdoptante.TabIndex = 1;
            this.lblIdAdoptante.Text = "Id_Adoptante";
            // 
            // lblDirecccion
            // 
            this.lblDirecccion.AutoSize = true;
            this.lblDirecccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecccion.Location = new System.Drawing.Point(421, 130);
            this.lblDirecccion.Name = "lblDirecccion";
            this.lblDirecccion.Size = new System.Drawing.Size(89, 18);
            this.lblDirecccion.TabIndex = 2;
            this.lblDirecccion.Text = "Direcccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 216);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(421, 216);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(76, 18);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(25, 286);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 18);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtIdAdoptante
            // 
            this.txtIdAdoptante.Location = new System.Drawing.Point(150, 124);
            this.txtIdAdoptante.Name = "txtIdAdoptante";
            this.txtIdAdoptante.Size = new System.Drawing.Size(207, 22);
            this.txtIdAdoptante.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(538, 127);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(206, 22);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 210);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(527, 216);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(206, 22);
            this.txtApellidos.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 282);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(214, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(735, 363);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 62);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(558, 363);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 62);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(382, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 62);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(209, 363);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 62);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(39, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 62);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvAdoptantes
            // 
            this.dgvAdoptantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdoptantes.Location = new System.Drawing.Point(39, 441);
            this.dgvAdoptantes.Name = "dgvAdoptantes";
            this.dgvAdoptantes.RowHeadersWidth = 51;
            this.dgvAdoptantes.RowTemplate.Height = 24;
            this.dgvAdoptantes.Size = new System.Drawing.Size(818, 142);
            this.dgvAdoptantes.TabIndex = 21;
            this.dgvAdoptantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellContentClick);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicio.Location = new System.Drawing.Point(12, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(98, 33);
            this.btnInicio.TabIndex = 27;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // ADOPTANTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 595);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAdoptantes);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtIdAdoptante);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDirecccion);
            this.Controls.Add(this.lblIdAdoptante);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ADOPTANTES";
            this.Text = "ADOPTANTES";
            this.Load += new System.EventHandler(this.ADOPTANTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoptantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdAdoptante;
        private System.Windows.Forms.Label lblDirecccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtIdAdoptante;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvAdoptantes;
        private System.Windows.Forms.Button btnInicio;
    }
}