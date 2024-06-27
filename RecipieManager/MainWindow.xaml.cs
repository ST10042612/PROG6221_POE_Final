using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipieManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //variable declaration
        private Recipes rec;
        Boolean exit = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void CreateClick(object sender, RoutedEventArgs e)//Initiates the the process to create a new recipe
        {

            Create create = new Create();
            
            create.Show();


        }

        private void DisplayClick(object sender, RoutedEventArgs e)// will intitiale the process of displaying a selected recipe
        {

            DisplayRecipesMenu display = new DisplayRecipesMenu();

            display.Show();

        }

        private void ScaleClick(object sender, RoutedEventArgs e)//will initiate the process for scaling a recipe
        {

            
    
        }

        private void PieClick(object sender, RoutedEventArgs e)//will initiate the process of creating a food group pie chart
        {



        }

        private void ExitClick(object sender, RoutedEventArgs e)//Exits the application
        {

            this.Close();

        }


    }
}
