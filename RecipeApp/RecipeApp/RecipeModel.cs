using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class RecipeModel
    {
        public string Name { get; set; } //Название рецепта
        public List<string> Ingredients { get; set; } //Ингридиенты рецепт
        public string Instructions { get; set; } //Текст, интрукции по созданию рецепта

        public RecipeModel(string name, List<string> ingredients, string instructions)
        {
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
        }
    }
}
