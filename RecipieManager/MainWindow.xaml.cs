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

        private Recipes rec;
        Boolean exit = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateClick(object sender, RoutedEventArgs e)
        {

            Create create = new Create();
            
            create.Show();


        }

        private void DisplayClick(object sender, RoutedEventArgs e)
        {

            DisplayRecipesMenu display = new DisplayRecipesMenu();

            display.Show();

        }

        private void ScaleClick(object sender, RoutedEventArgs e)
        {



        }

        private void PieClick(object sender, RoutedEventArgs e)
        {



        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {

            this.Close();

        }


    }
}