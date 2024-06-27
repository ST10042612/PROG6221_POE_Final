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
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {

        public string name;
        public int steps, ingredients;

        Recipes rec = new Recipes();

        public Create()
        {
            InitializeComponent();
        }

        public void btnClick(object sender, RoutedEventArgs e)
        {

                name = nameField.Text.Trim();
                steps = Int16.Parse(stepsField.Text.Trim()); //string to int https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
                ingredients = Int16.Parse(ingField.Text.Trim());

                rec.recipeName.Add(name);

                System.Diagnostics.Trace.WriteLine(name);

                EnterIngredient ei = new EnterIngredient();
                EnterStep step = new EnterStep();

                while (ingredients != 0)
                {

                    ei.ShowDialog();

                    ingredients--;

                }

                ei.addIntoRecLists();

                while (steps != 0)
                {

                    step.ShowDialog();

                    steps--;

                }

                step.addintoToRecLists();

            Close();

        }

        public string getName()
        {

            return name;

        }

        public int getSteps()
        {

            return steps;

        }

        private void stepsField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ingredientsField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public int getIng()
        {

            return ingredients;

        }
    }
}
