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
    /// Interaction logic for EnterStep.xaml
    /// </summary>
    public partial class EnterStep : Window
    {

        public string step;

        List<string> steps = new List<string>();

        private Recipes rec;

        public EnterStep()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {

            try
            {
                step = stepField.Text.Trim();

                steps.Add(step);

                Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

            Close();

        }

        public void addintoToRecLists()
        {

            rec.steps.Add(steps);

        }

    }
}
