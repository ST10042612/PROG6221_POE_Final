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
    /// Interaction logic for DisplayRecipesMenu.xaml
    /// </summary>
    public partial class DisplayRecipesMenu : Window
    {
        
        Recipes rec;
        public DisplayRecipesMenu()
        {
            InitializeComponent();
        }

        //loads all the recipes into a list box
        private void Recipe_Load(object sender, EventArgs e) //https://www.geeksforgeeks.org/how-to-add-items-in-listbox-in-c-sharp/
        {

            RecBox.Items.Add("Recipie Name" + "   " + "Steps" + "   " + "Ingredients");// header
            
            List<string> tempRecipeName = rec.recipeName;
            tempRecipeName.Sort();

            for (int i = 0; i < rec.recipeName.Count(); i++) // goes through lists and add them into a string that will then be displayed
            {

                string str = $"{rec.ingredientName[i],-11}{"",-4}{rec.ingredientName[i].Count(),-5}{"",-4}{rec.steps[i].Count(),-11}";

                RecBox.Items.Add(str);

            }
           

        }

 
    }
}
