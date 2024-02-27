namespace Cafetería_Mi_U
{
    partial class Contadordejamones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cheBoxAdQuin = new System.Windows.Forms.CheckBox();
            this.cheBoxAdFest = new System.Windows.Forms.CheckBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblVrAPagar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cheBoxAdQuin
            // 
            this.cheBoxAdQuin.Location = new System.Drawing.Point(15, 126);
            this.cheBoxAdQuin.Name = "cheBoxAdQuin";
            this.cheBoxAdQuin.Size = new System.Drawing.Size(97, 31);
            this.cheBoxAdQuin.TabIndex = 5;
            this.cheBoxAdQuin.Text = "Adición Quincena";
            this.cheBoxAdQuin.UseVisualStyleBackColor = true; // 
            // cheBoxAdFest
            // 
            this.cheBoxAdFest.Location = new System.Drawing.Point(15, 90);
            this.cheBoxAdFest.Name = "cheBoxAdFest";
            this.cheBoxAdFest.Size = new System.Drawing.Size(97, 30);
            this.cheBoxAdFest.TabIndex = 6;
            this.cheBoxAdFest.Text = "Adición Festivos";
            this.cheBoxAdFest.UseVisualStyleBackColor = true;
            // 
            // lblCant
            // 
            this.lblCant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCant.Location = new System.Drawing.Point(115, 50);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(121, 23);
            this.lblCant.TabIndex = 7;
            this.lblCant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(115, 9);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(121, 21);
            this.cmbDia.TabIndex = 8;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbdia_SelectedIndexChanged);
            // 
            // lblVrAPagar
            // 
            this.lblVrAPagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVrAPagar.Location = new System.Drawing.Point(112, 123);
            this.lblVrAPagar.Name = "lblVrAPagar";
            this.lblVrAPagar.Size = new System.Drawing.Size(121, 23);
            this.lblVrAPagar.TabIndex = 9;
            this.lblVrAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(118, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor A Pagar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(77, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(37, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(143, 176);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 13;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // Contadordejamones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 246);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVrAPagar);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.cheBoxAdFest);
            this.Controls.Add(this.cheBoxAdQuin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Contadordejamones";
            this.Text = "Compras de jamón";
            this.Load += new System.EventHandler(this.Contadordejamones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cheBoxAdQuin;
        private System.Windows.Forms.CheckBox cheBoxAdFest;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblVrAPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFacturar;
    }
}

