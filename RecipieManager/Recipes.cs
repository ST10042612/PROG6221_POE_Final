using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipieManager
{
    class Recipes
    {

        //List decleration
        public List<string> recipeName = new List<string>();

        public List<List<string>> ingredientName = new List<List<string>>();
        public List<List<string>> UOM = new List<List<string>>();
        public List<List<double>> quantity = new List<List<double>>();
        public List<List<double>> calories = new List<List<double>>();
        public List<List<string>> foodGrp = new List<List<string>>();

        public List<List<string>> steps = new List<List<string>>();

        //for adding variables into specific indexes of the List Lists, will be overWritten when a new recipe is created.
        public int uniIndex = 0;

        public void updateIndex()
        {

            this.uniIndex++;

        }

        public int getindex()
        {

            return uniIndex;

        }


    }
}
