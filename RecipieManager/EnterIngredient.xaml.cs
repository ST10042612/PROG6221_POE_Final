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
using System.Xml.Linq;

namespace RecipieManager
{
    /// <summary>
    /// Interaction logic for EnterIngredient.xaml
    /// </summary>
    public partial class EnterIngredient : Window
    {

        //variable decleration
        public string ingName, UOM, foodGrp;
        public double quantity, calories;

        private Recipes rec = new Recipes();

        public EnterIngredient()
        {
            InitializeComponent();
        }

        //Lists Decleration
        List<string> ingList = new List<string>();
        List<string> foodGrpList = new List<string>();
        List<string> UOMList = new List<string>();
        List<double> qList = new List<double>();
        List<double> calList = new List<double>();

        private void btnClick(object sender, RoutedEventArgs e) // when the button is clicked it will add the individaul items into their respective lists
        {

            
            ingName = nameField.Text.Trim();
            UOM = UOMField.Text.Trim();
            foodGrp = foodgrpField.Text.Trim();
            quantity = Int16.Parse(quantityField.Text.Trim()); //string to int https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
            calories = Int16.Parse(CalField.Text.Trim());

            this.ingList.Add(ingName);
            this.foodGrpList.Add(foodGrp);
            this.UOMList.Add(UOM);
            this.qList.Add(quantity);
            this.calList.Add(calories);

            Close();

        }

        public void addIntoRecLists()// adds the lists into the lists in the Recipe class
        {

            rec.ingredientName.Add(ingList);
            rec.UOM.Add(UOMList);
            rec.quantity.Add(qList);
            rec.calories.Add(calList);
            rec.foodGrp.Add(foodGrpList);

        }


    }
}
