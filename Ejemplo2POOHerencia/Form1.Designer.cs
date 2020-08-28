namespace Ejemplo2POOHerencia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.btncalcularsalariobase = new System.Windows.Forms.Button();
            this.lblsalariobase = new System.Windows.Forms.Label();
            this.btncalculardescuentos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblvalorsalud = new System.Windows.Forms.Label();
            this.lblvalorpension = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblvalorccf = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblvalorsalariofinal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de salarios y descuentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese horas trabajadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(14, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 2;
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txthorastrabajadas.Location = new System.Drawing.Point(422, 126);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(212, 45);
            this.txthorastrabajadas.TabIndex = 3;
            // 
            // btncalcularsalariobase
            // 
            this.btncalcularsalariobase.Location = new System.Drawing.Point(21, 209);
            this.btncalcularsalariobase.Name = "btncalcularsalariobase";
            this.btncalcularsalariobase.Size = new System.Drawing.Size(192, 44);
            this.btncalcularsalariobase.TabIndex = 5;
            this.btncalcularsalariobase.Text = "Salario Base";
            this.btncalcularsalariobase.UseVisualStyleBackColor = true;
            this.btncalcularsalariobase.Click += new System.EventHandler(this.btncalcularsalariobase_Click);
            // 
            // lblsalariobase
            // 
            this.lblsalariobase.AutoSize = true;
            this.lblsalariobase.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblsalariobase.Location = new System.Drawing.Point(219, 214);
            this.lblsalariobase.Name = "lblsalariobase";
            this.lblsalariobase.Size = new System.Drawing.Size(198, 39);
            this.lblsalariobase.TabIndex = 6;
            this.lblsalariobase.Text = "Salariobase";
            this.lblsalariobase.Visible = false;
            // 
            // btncalculardescuentos
            // 
            this.btncalculardescuentos.Enabled = false;
            this.btncalculardescuentos.Location = new System.Drawing.Point(21, 280);
            this.btncalculardescuentos.Name = "btncalculardescuentos";
            this.btncalculardescuentos.Size = new System.Drawing.Size(192, 44);
            this.btncalculardescuentos.TabIndex = 7;
            this.btncalculardescuentos.Text = "Descuentos";
            this.btncalculardescuentos.UseVisualStyleBackColor = true;
            this.btncalculardescuentos.Click += new System.EventHandler(this.btncalculardescuentos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(219, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salud:";
            // 
            // lblvalorsalud
            // 
            this.lblvalorsalud.AutoSize = true;
            this.lblvalorsalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblvalorsalud.Location = new System.Drawing.Point(375, 283);
            this.lblvalorsalud.Name = "lblvalorsalud";
            this.lblvalorsalud.Size = new System.Drawing.Size(179, 39);
            this.lblvalorsalud.TabIndex = 9;
            this.lblvalorsalud.Text = "Valorsalud";
            this.lblvalorsalud.Visible = false;
            // 
            // lblvalorpension
            // 
            this.lblvalorpension.AutoSize = true;
            this.lblvalorpension.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblvalorpension.Location = new System.Drawing.Point(375, 335);
            this.lblvalorpension.Name = "lblvalorpension";
            this.lblvalorpension.Size = new System.Drawing.Size(217, 39);
            this.lblvalorpension.TabIndex = 11;
            this.lblvalorpension.Text = "Valorpension";
            this.lblvalorpension.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label8.Location = new System.Drawing.Point(219, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pensión:";
            // 
            // lblvalorccf
            // 
            this.lblvalorccf.AutoSize = true;
            this.lblvalorccf.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblvalorccf.Location = new System.Drawing.Point(375, 386);
            this.lblvalorccf.Name = "lblvalorccf";
            this.lblvalorccf.Size = new System.Drawing.Size(140, 39);
            this.lblvalorccf.TabIndex = 13;
            this.lblvalorccf.Text = "Valorccf";
            this.lblvalorccf.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label10.Location = new System.Drawing.Point(219, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 39);
            this.label10.TabIndex = 12;
            this.label10.Text = "CCF:";
            // 
            // lblvalorsalariofinal
            // 
            this.lblvalorsalariofinal.AutoSize = true;
            this.lblvalorsalariofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblvalorsalariofinal.Location = new System.Drawing.Point(484, 436);
            this.lblvalorsalariofinal.Name = "lblvalorsalariofinal";
            this.lblvalorsalariofinal.Size = new System.Drawing.Size(261, 39);
            this.lblvalorsalariofinal.TabIndex = 15;
            this.lblvalorsalariofinal.Text = "Valorsalariofinal";
            this.lblvalorsalariofinal.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label12.Location = new System.Drawing.Point(219, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 39);
            this.label12.TabIndex = 14;
            this.label12.Text = "Salario a pagar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lblvalorsalariofinal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblvalorccf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblvalorpension);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblvalorsalud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalculardescuentos);
            this.Controls.Add(this.lblsalariobase);
            this.Controls.Add(this.btncalcularsalariobase);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.Button btncalcularsalariobase;
        private System.Windows.Forms.Label lblsalariobase;
        private System.Windows.Forms.Button btncalculardescuentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblvalorsalud;
        private System.Windows.Forms.Label lblvalorpension;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblvalorccf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblvalorsalariofinal;
        private System.Windows.Forms.Label label12;
    }
}

