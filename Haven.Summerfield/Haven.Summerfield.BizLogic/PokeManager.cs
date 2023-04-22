
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haven.Summerfield.BizLogic
{
    public class PokeManager
    {
     
        public Models.Pokemon AddPokemonManage(Models.Pokemon mPokemon)
        {
            //This is the first step into the Bizlogic Project.
            //Send to PokeValidation to get validated.
            //If validation successful we will convert our models.pokemon to datamodels.pokemon.
            //If validation not Successful we will send the modelsPokemon back to the addForm to display an error message for whats missing.
           
            Validation.PokeValidation pokeValidation = new Validation.PokeValidation();
            mPokemon = pokeValidation.validatePokemon(mPokemon);

            if (String.IsNullOrWhiteSpace(mPokemon.Message)) {

                mPokemon.Message = "pokemon successfully added";
            }


            return mPokemon;

        }



    }
}
