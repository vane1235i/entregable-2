namespace HUELLITAS
{
    partial class Mascotas
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(182, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(561, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR NUEVA MASCOTA";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(64, 111);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 18);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(649, 111);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(84, 18);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "ESPECIE:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(357, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(64, 227);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(55, 18);
            this.lblRaza.TabIndex = 4;
            this.lblRaza.Text = "RAZA:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(357, 229);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(53, 16);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "EDAD:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(649, 227);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(80, 18);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "ESTADO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigo.Location = new System.Drawing.Point(67, 142);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(179, 22);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(360, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtRaza
            // 
            this.txtRaza.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRaza.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRaza.Location = new System.Drawing.Point(67, 258);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(179, 22);
            this.txtRaza.TabIndex = 11;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEdad.Location = new System.Drawing.Point(360, 258);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(179, 22);
            this.txtEdad.TabIndex = 12;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(652, 140);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(179, 24);
            this.cmbEspecie.TabIndex = 13;
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(652, 256);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(179, 24);
            this.cmbEstado.TabIndex = 14;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(52, 444);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 24;
            this.dgvMascotas.Size = new System.Drawing.Size(818, 142);
            this.dgvMascotas.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(52, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 62);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(222, 366);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 62);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(395, 366);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 62);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(571, 366);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 62);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(748, 366);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 62);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicio.Location = new System.Drawing.Point(12, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(98, 33);
            this.btnInicio.TabIndex = 21;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(926, 628);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Mascotas";
            this.Text = "MASCOTAS";
            this.Load += new System.EventHandler(this.Mascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInicio;
    }
}