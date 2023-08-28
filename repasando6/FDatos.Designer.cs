
namespace repasando6
{
    partial class FDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lBnumero = new System.Windows.Forms.Label();
            this.rBonline = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBdni = new System.Windows.Forms.TextBox();
            this.tBsueldo = new System.Windows.Forms.TextBox();
            this.tBnumSucursal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo basico:";
            // 
            // lBnumero
            // 
            this.lBnumero.AutoSize = true;
            this.lBnumero.Location = new System.Drawing.Point(19, 129);
            this.lBnumero.Name = "lBnumero";
            this.lBnumero.Size = new System.Drawing.Size(91, 13);
            this.lBnumero.TabIndex = 3;
            this.lBnumero.Text = "Numero Sucursal:";
            // 
            // rBonline
            // 
            this.rBonline.AutoSize = true;
            this.rBonline.Location = new System.Drawing.Point(13, 183);
            this.rBonline.Name = "rBonline";
            this.rBonline.Size = new System.Drawing.Size(104, 17);
            this.rBonline.TabIndex = 4;
            this.rBonline.TabStop = true;
            this.rBonline.Text = "Vendedor Online";
            this.rBonline.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(144, 183);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vendedor Mostrador: ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(130, 13);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(100, 20);
            this.tBnombre.TabIndex = 6;
            // 
            // tBdni
            // 
            this.tBdni.Location = new System.Drawing.Point(130, 49);
            this.tBdni.Name = "tBdni";
            this.tBdni.Size = new System.Drawing.Size(100, 20);
            this.tBdni.TabIndex = 7;
            // 
            // tBsueldo
            // 
            this.tBsueldo.Location = new System.Drawing.Point(130, 89);
            this.tBsueldo.Name = "tBsueldo";
            this.tBsueldo.Size = new System.Drawing.Size(100, 20);
            this.tBsueldo.TabIndex = 8;
            // 
            // tBnumSucursal
            // 
            this.tBnumSucursal.Location = new System.Drawing.Point(130, 129);
            this.tBnumSucursal.Name = "tBnumSucursal";
            this.tBnumSucursal.Size = new System.Drawing.Size(100, 20);
            this.tBnumSucursal.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(13, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(144, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBnumSucursal);
            this.Controls.Add(this.tBsueldo);
            this.Controls.Add(this.tBdni);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rBonline);
            this.Controls.Add(this.lBnumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FDatos";
            this.Text = "FDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lBnumero;
        public System.Windows.Forms.RadioButton rBonline;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.TextBox tBnombre;
        public System.Windows.Forms.TextBox tBdni;
        public System.Windows.Forms.TextBox tBsueldo;
        public System.Windows.Forms.TextBox tBnumSucursal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}