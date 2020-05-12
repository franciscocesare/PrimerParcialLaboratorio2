using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJardin
{
    public partial class Form1 : FrmAltas
    {
        public Form1()
        {
            InitializeComponent();
        }



        protected override void btnAceptar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("segundo intento");


        }
    }
}
