
namespace repasando6
{
    partial class Form1
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
            this.tBempresa = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.lBlista = new System.Windows.Forms.ListBox();
            this.btnVerV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa: ";
            // 
            // tBempresa
            // 
            this.tBempresa.Location = new System.Drawing.Point(93, 28);
            this.tBempresa.Name = "tBempresa";
            this.tBempresa.Size = new System.Drawing.Size(100, 20);
            this.tBempresa.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(259, 16);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 42);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Empresa";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(350, 16);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(75, 42);
            this.btnVendedor.TabIndex = 3;
            this.btnVendedor.Text = "Agregar Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // lBlista
            // 
            this.lBlista.FormattingEnabled = true;
            this.lBlista.Location = new System.Drawing.Point(11, 98);
            this.lBlista.Name = "lBlista";
            this.lBlista.Size = new System.Drawing.Size(409, 225);
            this.lBlista.TabIndex = 4;
            // 
            // btnVerV
            // 
            this.btnVerV.Location = new System.Drawing.Point(432, 16);
            this.btnVerV.Name = "btnVerV";
            this.btnVerV.Size = new System.Drawing.Size(75, 42);
            this.btnVerV.TabIndex = 5;
            this.btnVerV.Text = "Ver Vendedor";
            this.btnVerV.UseVisualStyleBackColor = true;
            this.btnVerV.Click += new System.EventHandler(this.btnVerV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 366);
            this.Controls.Add(this.btnVerV);
            this.Controls.Add(this.lBlista);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.tBempresa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBempresa;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.ListBox lBlista;
        public System.Windows.Forms.Button btnVerV;
    }
}

