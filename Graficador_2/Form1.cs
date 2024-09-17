using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using info.lundin.math;
namespace Graficador_2{
    public partial class Form1 : Form{
        double xi, xf;
        int n;
        string fx;
        public Form1(){
            InitializeComponent();
            n = chart1.Width;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void Btn_Firma_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("Firma_2.exe");

        private void Btgraficar_Click(object sender, EventArgs e) {
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);
            fx = tBfx.Text;
            Graficas gr1 = new Graficas(n);
            gr1.Graficador(xi, xf, fx);

            for (int k = 0; k < n; k++){
                chart1.Series["Series1"].Points.AddXY(gr1.X[k], gr1.Y[k]);
                lBsalida.Items.Add(gr1.X[k] + "\t\t" + gr1.Y[k]);
                
            }
        }
    }
}
