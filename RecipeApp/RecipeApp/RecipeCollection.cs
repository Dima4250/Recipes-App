using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class RecipeCollection : IEnumerable<RecipeModel>
    {
        private readonly List<RecipeModel> _recipes = new();

        public void Add(RecipeModel recipe) => _recipes.Add(recipe);
        public void Remove(RecipeModel recipe) => _recipes.Remove(recipe);

        public IEnumerator<RecipeModel> GetEnumerator() => _recipes.GetEnumerator();
        System.Collections.IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
