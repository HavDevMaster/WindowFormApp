using Haven.Summerfield.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Validation

{
    internal class PokeValidation
    {

        //make function for validating pokemon to make sure all text properties are filled out

        internal Pokemon validatePokemon(Pokemon pokemon) { 
        
        if (String.IsNullOrWhiteSpace(pokemon.Name)) {
                pokemon.Message += "Missing Pokemon Name";
            }
            if (String.IsNullOrWhiteSpace(pokemon.Nature)){
                pokemon.Message += "Missing Pokemon Nature";
            }
            if (String.IsNullOrWhiteSpace(pokemon.Gender)) {
                pokemon.Message += "Missing Pokemon Gender";
            }
            if (String.IsNullOrWhiteSpace(pokemon.Type)) {
                pokemon.Message += "Missing Pokemon Type";
            }
            if (pokemon.Level == 0) {
                pokemon.Message += "Missing Pokemon Level";
            }
            return pokemon;
            }



        }

    }

