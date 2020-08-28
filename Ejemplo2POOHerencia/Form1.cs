using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo2POOHerencia
{
    public partial class Form1 : Form
    {
        //Instancias de las clases necesarias
        Descuentos descuentos = new Descuentos();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcularsalariobase_Click(object sender, EventArgs e)
        {
            descuentos.setCantidadHoras(double.Parse(txthorastrabajadas.Text));
            lblsalariobase.Visible = true;
            lblsalariobase.Text = Convert.ToString(descuentos.calcularSalarioBase());
            btncalculardescuentos.Enabled = true;
        }

        private void btncalculardescuentos_Click(object sender, EventArgs e)
        {
            lblvalorsalud.Visible = true;
            lblvalorsalud.Text = Convert.ToString(descuentos.calcularSalud());
            lblvalorpension.Visible = true;
            lblvalorpension.Text = Convert.ToString(descuentos.calcularPension());
            lblvalorccf.Visible = true;
            lblvalorccf.Text = Convert.ToString(descuentos.calcularCcf());
            lblvalorsalariofinal.Visible = true;
            lblvalorsalariofinal.Text = Convert.ToString(descuentos.calcularSalarioConDescuento());
        }
    }
}
