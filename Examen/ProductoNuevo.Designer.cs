
namespace Examen
{
    partial class ProductoNuevo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValorActivo = new System.Windows.Forms.Label();
            this.txtValorActivo = new System.Windows.Forms.TextBox();
            this.txtValorResidual = new System.Windows.Forms.TextBox();
            this.dtpFechaAdquisicon = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoActivo = new System.Windows.Forms.ComboBox();
            this.cmbMetodoDepreciacion = new System.Windows.Forms.ComboBox();
            this.lblValorResidual = new System.Windows.Forms.Label();
            this.LblFechaAdquisicion = new System.Windows.Forms.Label();
            this.lblTipoActivo = new System.Windows.Forms.Label();
            this.lblMetodoDepreciacion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(66, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(269, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(269, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(66, 144);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDescripcion.Location = new System.Drawing.Point(269, 106);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 68);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblValorActivo
            // 
            this.lblValorActivo.AutoSize = true;
            this.lblValorActivo.Location = new System.Drawing.Point(66, 192);
            this.lblValorActivo.Name = "lblValorActivo";
            this.lblValorActivo.Size = new System.Drawing.Size(80, 13);
            this.lblValorActivo.TabIndex = 6;
            this.lblValorActivo.Text = "Valor del activo";
            // 
            // txtValorActivo
            // 
            this.txtValorActivo.Location = new System.Drawing.Point(269, 189);
            this.txtValorActivo.Name = "txtValorActivo";
            this.txtValorActivo.Size = new System.Drawing.Size(100, 20);
            this.txtValorActivo.TabIndex = 7;
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.Location = new System.Drawing.Point(269, 226);
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Size = new System.Drawing.Size(100, 20);
            this.txtValorResidual.TabIndex = 8;
            // 
            // dtpFechaAdquisicon
            // 
            this.dtpFechaAdquisicon.Location = new System.Drawing.Point(269, 266);
            this.dtpFechaAdquisicon.Name = "dtpFechaAdquisicon";
            this.dtpFechaAdquisicon.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAdquisicon.TabIndex = 9;
            // 
            // cmbTipoActivo
            // 
            this.cmbTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoActivo.FormattingEnabled = true;
            this.cmbTipoActivo.Items.AddRange(new object[] {
            "Edificio",
            "Vehiculo",
            "Maquinaria",
            "Mobilirario\t",
            "Equipo de computo"});
            this.cmbTipoActivo.Location = new System.Drawing.Point(269, 302);
            this.cmbTipoActivo.Name = "cmbTipoActivo";
            this.cmbTipoActivo.Size = new System.Drawing.Size(122, 21);
            this.cmbTipoActivo.TabIndex = 10;
            // 
            // cmbMetodoDepreciacion
            // 
            this.cmbMetodoDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoDepreciacion.FormattingEnabled = true;
            this.cmbMetodoDepreciacion.Items.AddRange(new object[] {
            "Lineal",
            "Suma de los digitos de los años"});
            this.cmbMetodoDepreciacion.Location = new System.Drawing.Point(269, 338);
            this.cmbMetodoDepreciacion.Name = "cmbMetodoDepreciacion";
            this.cmbMetodoDepreciacion.Size = new System.Drawing.Size(122, 21);
            this.cmbMetodoDepreciacion.TabIndex = 11;
            // 
            // lblValorResidual
            // 
            this.lblValorResidual.AutoSize = true;
            this.lblValorResidual.Location = new System.Drawing.Point(66, 229);
            this.lblValorResidual.Name = "lblValorResidual";
            this.lblValorResidual.Size = new System.Drawing.Size(70, 13);
            this.lblValorResidual.TabIndex = 12;
            this.lblValorResidual.Text = "Valor residual";
            // 
            // LblFechaAdquisicion
            // 
            this.LblFechaAdquisicion.AutoSize = true;
            this.LblFechaAdquisicion.Location = new System.Drawing.Point(66, 272);
            this.LblFechaAdquisicion.Name = "LblFechaAdquisicion";
            this.LblFechaAdquisicion.Size = new System.Drawing.Size(108, 13);
            this.LblFechaAdquisicion.TabIndex = 13;
            this.LblFechaAdquisicion.Text = "Fecha de adquisicion";
            // 
            // lblTipoActivo
            // 
            this.lblTipoActivo.AutoSize = true;
            this.lblTipoActivo.Location = new System.Drawing.Point(66, 305);
            this.lblTipoActivo.Name = "lblTipoActivo";
            this.lblTipoActivo.Size = new System.Drawing.Size(75, 13);
            this.lblTipoActivo.TabIndex = 14;
            this.lblTipoActivo.Text = "Tipo de activo";
            // 
            // lblMetodoDepreciacion
            // 
            this.lblMetodoDepreciacion.AutoSize = true;
            this.lblMetodoDepreciacion.Location = new System.Drawing.Point(66, 341);
            this.lblMetodoDepreciacion.Name = "lblMetodoDepreciacion";
            this.lblMetodoDepreciacion.Size = new System.Drawing.Size(107, 13);
            this.lblMetodoDepreciacion.TabIndex = 15;
            this.lblMetodoDepreciacion.Text = "Metodo depreciacion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(123, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(279, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ProductoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMetodoDepreciacion);
            this.Controls.Add(this.lblTipoActivo);
            this.Controls.Add(this.LblFechaAdquisicion);
            this.Controls.Add(this.lblValorResidual);
            this.Controls.Add(this.cmbMetodoDepreciacion);
            this.Controls.Add(this.cmbTipoActivo);
            this.Controls.Add(this.dtpFechaAdquisicon);
            this.Controls.Add(this.txtValorResidual);
            this.Controls.Add(this.txtValorActivo);
            this.Controls.Add(this.lblValorActivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "ProductoNuevo";
            this.Text = "ProductoNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblValorActivo;
        private System.Windows.Forms.TextBox txtValorActivo;
        private System.Windows.Forms.TextBox txtValorResidual;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicon;
        private System.Windows.Forms.ComboBox cmbTipoActivo;
        private System.Windows.Forms.ComboBox cmbMetodoDepreciacion;
        private System.Windows.Forms.Label lblValorResidual;
        private System.Windows.Forms.Label LblFechaAdquisicion;
        private System.Windows.Forms.Label lblTipoActivo;
        private System.Windows.Forms.Label lblMetodoDepreciacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}