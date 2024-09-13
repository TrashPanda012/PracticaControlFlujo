using ejercicio2.Clases;
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
using System.Xml.Linq;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddElements()
        {
            try
            {
                string name = tbName.Text;
                string lastName = tbLastname.Text;
                DateTime birthday = dtpBirthday.Value;
                int year = birthday.Year;
                DateTime actualYear = DateTime.Now;
                int currentYear = actualYear.Year;
                int age = currentYear - year;
                dtpBirthday.ResetText();

                if (string.IsNullOrEmpty(name)|string.IsNullOrEmpty(lastName))
                {
                    MessageBox.Show("No se puede quedar vacio el nombre o el apellido");
                    return;
                }
                persona.addName(name, index);
                persona.addLastName(lastName, index);
                persona.addBirthday(age, index);
                index++;

                ShowElements();
                tbName.Clear();
                tbLastname.Clear();
                tbName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowElements()
        {
            try
            {
                lbNombres.Items.Clear();
                lbApellidos.Items.Clear();
                lbEdad.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    lbNombres.Items.Add(persona.GetNames()[(int)i]);
                    lbApellidos.Items.Add(persona.GetLastnames()[(int)i]);
                    lbEdad.Items.Add(persona.GetAge()[(int)i]);
                }
            }
            catch { }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddElements();
        }
    }
}
