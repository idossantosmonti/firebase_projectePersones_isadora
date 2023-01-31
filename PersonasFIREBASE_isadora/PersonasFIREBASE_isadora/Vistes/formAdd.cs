using PersonasFIREBASE_isadora.Dades.Model;
using PersonasFIREBASE_isadora.Domini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonasFIREBASE_isadora.Vistes
{
    public partial class formAdd : Form
    {
        public IDominiPersonas dominiPersonas { get; set; }
        public formAdd(IDominiPersonas dominiPersonas)
        {
            this.dominiPersonas = dominiPersonas;
            InitializeComponent(); 
            cmbDisponibilidadViaje.DataSource = Enum.GetValues(typeof(Disponibilidad));
            cmbDisponibilidadViaje.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] llenguatgesTxt;
            IList<string> lang = null;


            if (String.IsNullOrEmpty(txtNom.Text))
                MessageBox.Show("No es pot afegir un usuari sense nom!");
            else
            {
                if (!String.IsNullOrEmpty(txtLlenguatges.Text))
                {
                    llenguatgesTxt = (txtLlenguatges.Text).Split(',');
                    lang = new List<string>(llenguatgesTxt);
                }
                else
                    llenguatgesTxt = new string[] {""};
                    lang = new List<string>(llenguatgesTxt);

                Persona personaNova = new Persona()
                {
                    disponibilidadParaViajar = Convert.ToBoolean(cmbDisponibilidadViaje.SelectedIndex),
                    edad = (int)nudEdat.Value,
                    lenguajes = lang,
                    profesion = txtProfessio.Text,
                    rangoProfesional = new RangoProfesional()
                    {
                        aniosDeExperiencia = Convert.ToInt32(nudAnysTreball.Value),
                        nivel = txtRang.Text
                    }
                };

                if (MessageBox.Show("Estas segur de que vols afegir un nou registre?", "ATENCIÓ!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dominiPersonas.AfegirPersona(personaNova, txtNom.Text);
                    MessageBox.Show("Persona afegida correctament.");
                    
                    
                }
                else
                    MessageBox.Show("Operació cancel·lada.");

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtLlenguatges.Text = "";
            txtProfessio.Text = "";
            txtRang.Text = "";
            nudAnysTreball.Value = 0;
            nudEdat.Value = 0;
            cmbDisponibilidadViaje.SelectedIndex = 1;
        }
    }
}
