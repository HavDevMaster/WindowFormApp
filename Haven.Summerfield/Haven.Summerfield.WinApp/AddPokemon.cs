using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haven.Summerfield.WinApp
{
    public partial class AddPokemon : Form
    {
        public AddPokemon()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of the model.pokemon object class.

            Models.Pokemon pokemon = new Models.Pokemon();
            //Assign the textboxes to the form of our pokemon project.


            pokemon.Gender = txtGender.Text;
            pokemon.Nature = txtNature.Text;
            if (int.TryParse(txtLevel.Text, out _))
            {
                pokemon.Level = Int32.Parse(txtLevel.Text);
            }
            pokemon.Name = txtName.Text;
            pokemon.Type = txtType.Text;    

            //after the pokemon object has been filled out we send it to bizlogic.pokemanager.
            BizLogic.PokeManager pokeManager = new BizLogic.PokeManager();
            pokemon = pokeManager.AddPokemonManage(pokemon);

            lblMessage.Text = pokemon.Message;
            lblMessage.Visible = true;
        }
        
            

    }
}
