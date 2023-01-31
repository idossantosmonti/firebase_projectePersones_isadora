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
    public partial class formUpdate : Form
    {
        public IDominiPersonas domini { get; set; }
        Persona personaActualitzar;
        public string NomInicial { get; set; }
        public string NomNou { get; set; }
        public formUpdate(IDominiPersonas dominiPersonas, Persona pTriada, string nom)
        {
            InitializeComponent();
            domini = dominiPersonas;
            cmbDisponibilidadViaje.DataSource = Enum.GetValues(typeof(Disponibilidad));
            cmbDisponibilidadViaje.SelectedIndex = 1;
            personaActualitzar = pTriada;
            this.NomInicial = nom;
            CarregarDades(personaActualitzar, this.NomInicial);
        }

        private void btnNeteja_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtLlenguatges.Text = "";
            txtProfessio.Text = "";
            txtRang.Text = "";
            nudAnysTreball.Value = 0;
            nudEdat.Value = 0;
            cmbDisponibilidadViaje.SelectedIndex = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] llenguatgesTxt;
            IList<string> lang = null;


            if (String.IsNullOrEmpty(txtNom.Text))
                MessageBox.Show("No es pot afegir un usuari sense nom!");
            else
            {
                this.NomNou = txtNom.Text;
                if (!String.IsNullOrEmpty(txtLlenguatges.Text))
                {
                    llenguatgesTxt = (txtLlenguatges.Text).Split(',');
                    lang = new List<string>(llenguatgesTxt);
                }
                else
                    llenguatgesTxt = new string[] { "" };
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

                if (MessageBox.Show("Estas segur de que vols modificar aquest registre?", "ATENCIÓ!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    domini.UpdatePersona(NomInicial, NomNou, personaNova);
                    MessageBox.Show("Persona modificada correctament.");


                }
                else
                    MessageBox.Show("Operació cancel·lada.");

                this.Close();
            }
        }

        private void CarregarDades(Persona p, string nom)
        {
            txtNom.Text = nom;
            string llenguatges = "";

            for (int i = 0; i <= p.lenguajes.Count - 1; i++)
            {
                if (i == p.lenguajes.Count - 1)
                    llenguatges += p.lenguajes[i];
                else
                    llenguatges += p.lenguajes[i] + ", ";
            }
            txtLlenguatges.Text = llenguatges;
            txtProfessio.Text = p.profesion;
            txtRang.Text =p.rangoProfesional.nivel;
            nudAnysTreball.Value = p.rangoProfesional.aniosDeExperiencia;
            nudEdat.Value = p.edad;
            cmbDisponibilidadViaje.SelectedIndex = Convert.ToInt32(p.disponibilidadParaViajar);
        }
    }
}
