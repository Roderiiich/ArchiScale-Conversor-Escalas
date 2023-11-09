using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorEscalas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbCentimetros.Checked == true)
            {
                double escala, valor;

                valor = double.Parse(txtValor.Text);
                escala = valor / (100 / 50);
                txt150.Text = escala.ToString();

                lblMetro1.Visible= true;
                lblMetro2.Visible= true;
            }

            if(cbCentimetros.Checked==true)
            {
                double escala, valor;

                valor = double.Parse(txtValor.Text);
                escala = valor *1;
                txt1100.Text = escala.ToString();
                lblMetro1.Visible = true;
                lblMetro2.Visible = true;
            }

            if(cbMetros.Checked==true)
            {
                double escala, valor;
                valor = double.Parse(txtValor.Text);
                escala = valor *2;
                txt150.Text = escala.ToString();
                lblCent1.Visible = true;
                lblCent2.Visible = true;
            }

            if(cbMetros.Checked==true)
            {
                double escala, valor;

                valor = double.Parse(txtValor.Text);
                escala = valor * 1;
                txt1100.Text = escala.ToString();
                lblCent1.Visible = true;
                lblCent2.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txt1100.Clear();
            txt150.Clear();
            cbCentimetros.Checked = false;
            cbMetros.Checked = false;
            lblCent1.Visible=false;
            lblCent2.Visible=false;
            lblMetro1.Visible=false;
            lblMetro2.Visible=false;
        }

        private void cbCentimetros_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCentimetros.Checked==true)
            {
                cbMetros.Enabled = false;
            }

            else
            {
                cbMetros.Enabled=true;
            }
        }

        private void cbMetros_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMetros.Checked==true)
            {
                cbCentimetros.Enabled = false;
            }
            else
            {
                cbCentimetros.Enabled=true;
            }
        }
    }
}
