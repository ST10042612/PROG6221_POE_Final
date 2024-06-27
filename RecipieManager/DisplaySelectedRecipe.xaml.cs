using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipieManager
{
    /// <summary>
    /// Interaction logic for DisplaySelectedRecipe.xaml
    /// </summary>
    public partial class DisplaySelectedRecipe : Window
    {
        //variable decleration
        int recipeIndex;

        Recipes rec = new Recipes();
        public DisplaySelectedRecipe()
        {

            InitializeComponent();

        }

        //loads items into the list box
        private void Ingredients_Load(object sender, EventArgs e) //https://www.geeksforgeeks.org/how-to-add-items-in-listbox-in-c-sharp/
        {

            IngBox.Items.Add("");

        }



    }
}
