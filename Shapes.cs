using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeometricShapes
{
    public partial class frmShapes : Form
    {
        public frmShapes()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtBxValue.Enabled = true;
            txtBxValue.Text = "";
            rchTxtBxOutput.Text = "";
            radBtnSphere.Checked = true;
            txtBxValue.Focus();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            //*****************************
            string strFigure;
            double dblValue,dblSA, dblVolume;
            //*****************************          
            txtBxValue.Enabled = false;
            dblValue = double.Parse(txtBxValue.Text);
            if (radBtnSphere.Checked)
            {
                strFigure = "Sphere";
                FindSphere(dblValue, out dblSA, out dblVolume);             
                PrintSummary(strFigure, dblValue, dblSA, dblVolume);
            }
            else
            {
                strFigure = "Cube";
                FindCube(dblValue, out dblSA, out dblVolume); 
                PrintSummary(strFigure, dblValue, dblSA, dblVolume);
            }
            
        }

        private void radBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnSphere.Checked)
            {
                lblValue.Text = "Enter the Radius";
                txtBxValue.Focus();
            }
            else
            {
                lblValue.Text = "Enter the Side";
                txtBxValue.Focus();
            }
        }
        
        private void FindSphere(double value, out double SA, out double Vol)
        {
            SA = 4 * Math.PI * value * value; //4*pi*r squared
            Vol = (double)4 / 3 * Math.PI * Math.Pow(value,3);// 4/3pi*r cubed
        }
        
        private void FindCube(double value, out double SA, out double Vol)
        {
            SA = 6 * value * value; // 6*side squared
            Vol = Math.Pow(value, 3);
        }

        private void PrintSummary(string figure, double value, double SA, double Vol)
        {
            string strTitle, strOutput;

            if (figure == "Sphere")
            {
                strTitle = "\t\tSphere\n\n";
                strOutput = "Radius = \t \t" + value.ToString("n2") + "\n";
            }
            else
            {
                strTitle = "\t\tCube\n\n";
                strOutput = "Side = \t\t" + value.ToString("n2") + " units\n";
            }
            strOutput += "Surface Area =\t" + SA.ToString("n2") + " units squared\n";
            strOutput += "Volume =\t\t" + Vol.ToString("n2") + " units cubed\n";
            rchTxtBxOutput.Text = strTitle + strOutput;
        }          

         
    }
}
