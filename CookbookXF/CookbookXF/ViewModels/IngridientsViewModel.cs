using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.ViewModels
{
    internal class IngridientsViewModel : BaseViewModel
    {
        private string _name;
        private string _amount;
        private string _unit;

        public IngridientsViewModel(Ingredient ingredient)
        {
            LoadIngredient(ingredient);
        }

        public void LoadIngredient(Ingredient ingredient)
        {
            Name = ingredient.Name;
            Amount = ingredient.Amount;
            Unit = ingredient.Unit;
        }

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Amount
        {
            get { return _amount; }
            set 
            { 
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public string Unit
        {
            get { return _unit; }
            set 
            {
                _unit = value; 
                OnPropertyChanged(nameof(Unit));
            }
        }


        

        


    }
}
