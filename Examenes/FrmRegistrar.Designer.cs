namespace Examenes
{
    partial class FrmRegistrar
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAdquision = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdepreciacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.upValorActivo = new System.Windows.Forms.NumericUpDown();
            this.upValorResidual = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoActivo = new System.Windows.Forms.ComboBox();
            this.TipoActivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upValorActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upValorResidual)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 111);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(152, 171);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ValorActivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ValorResidual";
            // 
            // dtpAdquision
            // 
            this.dtpAdquision.Location = new System.Drawing.Point(152, 319);
            this.dtpAdquision.Name = "dtpAdquision";
            this.dtpAdquision.Size = new System.Drawing.Size(200, 20);
            this.dtpAdquision.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "FechaAdquision";
            // 
            // cmbdepreciacion
            // 
            this.cmbdepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepreciacion.FormattingEnabled = true;
            this.cmbdepreciacion.Items.AddRange(new object[] {
            "Suma De los digitos",
            "Linea Recta"});
            this.cmbdepreciacion.Location = new System.Drawing.Point(179, 381);
            this.cmbdepreciacion.Name = "cmbdepreciacion";
            this.cmbdepreciacion.Size = new System.Drawing.Size(121, 21);
            this.cmbdepreciacion.TabIndex = 12;
            this.cmbdepreciacion.SelectedIndexChanged += new System.EventHandler(this.Cmbdepreciacion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Metodo depreciacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // upValorActivo
            // 
            this.upValorActivo.Location = new System.Drawing.Point(152, 220);
            this.upValorActivo.Name = "upValorActivo";
            this.upValorActivo.Size = new System.Drawing.Size(120, 20);
            this.upValorActivo.TabIndex = 15;
            // 
            // upValorResidual
            // 
            this.upValorResidual.Location = new System.Drawing.Point(152, 266);
            this.upValorResidual.Name = "upValorResidual";
            this.upValorResidual.Size = new System.Drawing.Size(120, 20);
            this.upValorResidual.TabIndex = 16;
            // 
            // cmbTipoActivo
            // 
            this.cmbTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoActivo.FormattingEnabled = true;
            this.cmbTipoActivo.Location = new System.Drawing.Point(499, 59);
            this.cmbTipoActivo.Name = "cmbTipoActivo";
            this.cmbTipoActivo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoActivo.TabIndex = 17;
            this.cmbTipoActivo.SelectedIndexChanged += new System.EventHandler(this.CmbTipoActivo_SelectedIndexChanged);
            // 
            // TipoActivo
            // 
            this.TipoActivo.AutoSize = true;
            this.TipoActivo.Location = new System.Drawing.Point(439, 62);
            this.TipoActivo.Name = "TipoActivo";
            this.TipoActivo.Size = new System.Drawing.Size(54, 13);
            this.TipoActivo.TabIndex = 18;
            this.TipoActivo.Text = "tipoActivo";
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipoActivo);
            this.Controls.Add(this.cmbTipoActivo);
            this.Controls.Add(this.upValorResidual);
            this.Controls.Add(this.upValorActivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbdepreciacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpAdquision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmRegistrar";
            this.Text = "FrmRegistrar";
            this.Load += new System.EventHandler(this.FrmRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upValorActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upValorResidual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAdquision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdepreciacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown upValorActivo;
        private System.Windows.Forms.NumericUpDown upValorResidual;
        private System.Windows.Forms.ComboBox cmbTipoActivo;
        private System.Windows.Forms.Label TipoActivo;
    }
}