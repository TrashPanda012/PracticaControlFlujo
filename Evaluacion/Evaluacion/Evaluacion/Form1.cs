using Evaluacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Name names = new Name();
        int index = 0;
        int index2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (names.getLength(tbName.Text) > 25)
            {
                AddElement25();
            } 

            if (names.getLength(tbName.Text) < 25)
            {
                AddElement();
            }
        }

        private void lblEvaluacion_Click(object sender, EventArgs e)
        {

        }

        private void AddElement()
        {
            try
            {
                string name = tbName.Text;
                if (string.IsNullOrEmpty(name))
                {
                   // MessageBox.Show("No se puede quedar vacio el nombre");
                    return;
                }
                names.addElement(name, index);
                index++;
                ShowNames();
                tbName.Clear();
                tbName.Focus();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddElement25()
        {
            try
            {
                string name = tbName.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("No se puede quedar vacio el nombre");
                    return;
                }
                names.addElement25(name, index2);
                index2++;
                ShowNames25();
                tbName.Clear();
                tbName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowNames25()
        {
            try
            {
                lbEvaluacion.Items.Clear();
                for (int i = 0; i < index2; i++)
                {
                    lbEvaluacion.Items.Add(names.GetElements25()[(int)i]);
                }
            }
            catch { }
        }
        private void ShowNames()
        {
            try
            {
                lbNombresEst.Items.Clear();
                for (int k = 0; k < index; k++)
                {
                    lbNombresEst.Items.Add(names.GetElements()[(int)k]);
                }
            }
            catch { }
        }
        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddElement();
            }
        }
    }
}
