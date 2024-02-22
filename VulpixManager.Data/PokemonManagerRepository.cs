﻿using PokemonManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonManager.Data;


namespace PokemonManager.Data
{
    public class PokemonManagerRepository
    {

        public List<Pokemon> data;


        public PokemonManagerRepository()
        {

            data = new List<Pokemon>();

        }
        public Pokemon Create(Pokemon input)
        {
            data.Add(input); // adds the new Pokemon to the list.

            return input;


        }

        public List<Pokemon> ReadAll()
        {
            
            
            return data;
        }

        public Pokemon ReadByID(int id) // STEP 3
        {

            // create a new pokemon object and assign that to a return

            Pokemon pokemon = new Pokemon();
           



            for (int i = 0; i < data.Count; i++) // loop through list of objects (data<Pokemon>)
            {
                if (data[i].Id == id)
                {
                    pokemon = data[i];
                    


                }


            }
            return pokemon;

        }

        public void Update(int id, string newName, string newType, string newDescription, int newId)
        {
            for (int i = 0; i < data.Count; i++) // loop through list of objects (data<Pokemon>)
            {
                if (data[i].Id == id)
                {
                    
                    data[i].Name = newName;
                    data[i].PokeType = newType;
                    data[i].Description = newDescription;
                    data[i].Id = newId;

                }


            }
            
        }

        public Pokemon Delete(int id)
        {
            Pokemon pokemon = new Pokemon();

            for (int i = 0; i < data.Count; i++) // loop through list of objects (data<Pokemon>)
            {
                if (data[i].Id == id)
                {
                    pokemon = data[i];
                    data.Remove(pokemon);

                }
            }
            return pokemon;




        }

    }
}
