using Firebase.Database;
using PersonasFIREBASE_isadora.Dades.Model;
using PersonasFIREBASE_isadora.Domini;
using PersonasFIREBASE_isadora.Vistes;
using System.Diagnostics;

namespace PersonasFIREBASE_isadora
{
    public partial class Form1 : Form
    {
        public IDominiPersonas dominiPersonas { get; set; }

        List<KeyValuePair<string, Persona>> llistaPersones = new List<KeyValuePair<string, Persona>>();

        public Form1()
        {
            InitializeComponent();
            dominiPersonas = new DominiPersonas();
            cmbDisponibilidadViaje.DataSource = Enum.GetValues(typeof(Disponibilidad));
            cmbDisponibilidadViaje.SelectedIndex = 1;
            RefreshLsb();
        }

        private async void add_ClickAsync(object sender, EventArgs e)
        {
            formAdd afegir = new formAdd(dominiPersonas);
            afegir.ShowDialog();
            RefreshLsb();
        }
        public async void RefreshLsb()
        {
            lsbPersones.Items.Clear();
            llistaPersones.Clear();

            var persones = await dominiPersonas.ObtenirPersonas();
            foreach (var persona in persones)
            {
                lsbPersones.Items.Add(persona.Key);
                llistaPersones.Add(new KeyValuePair<string, Persona>(persona.Key, persona.Object));
            }
        }

        private async void lsbPersones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //formulari a part per update

            if(lsbPersones.SelectedIndex >= 0 && lsbPersones.SelectedIndex < llistaPersones.Count)
            {
                KeyValuePair<string, Persona> parella = llistaPersones[lsbPersones.SelectedIndex];
                txtNom.Text = parella.Key.ToString();
                string llenguatges = "";

                for (int i = 0; i <= parella.Value.lenguajes.Count - 1; i++)
                {
                    if (i == parella.Value.lenguajes.Count - 1)
                        llenguatges += parella.Value.lenguajes[i];
                    else
                        llenguatges += parella.Value.lenguajes[i] + ", ";
                }

                txtLlenguatges.Text = llenguatges;
                txtProfessio.Text = parella.Value.profesion;
                nudEdat.Value = parella.Value.edad;
                nudAnysTreball.Value = parella.Value.rangoProfesional.aniosDeExperiencia;
                txtRang.Text = parella.Value.rangoProfesional.nivel;
                cmbDisponibilidadViaje.SelectedIndex = Convert.ToInt32(parella.Value.disponibilidadParaViajar);

                //txtNom.Text = persona.profesion;
            }
        }

        private void lsbPersones_DoubleClick(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            Persona pTriada = llistaPersones[list.SelectedIndex].Value;
            string nom = llistaPersones[list.SelectedIndex].Key;
            formUpdate updt = new formUpdate(dominiPersonas, pTriada, nom);
            updt.ShowDialog();
            RefreshLsb();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lsbPersones.SelectedItem != null)
            {
                if(MessageBox.Show("Estas a punt d'eliminar un registre permanentment, estàs" +
                    " segur que vols continuar?", "ATENCIÓ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dominiPersonas.DeletePersona(lsbPersones.SelectedItem.ToString());
                    MessageBox.Show("Registre eliminat correctament.", "CONFIRMACIÓ");
                    RefreshLsb();
                    Neteja();
                }
                else
                    MessageBox.Show("Operació cancel·lada.", "ATENCIÓ");

            }
            
            //netejar al final
        }

        private void Neteja()
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