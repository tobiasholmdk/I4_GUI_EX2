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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hull_speed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double _Length, _result;
        string _str;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _Length = Convert.ToDouble(Length.Text);
            _result = Sailboat.Hullspeed(_Length);
            _result = Math.Round(_result, 1);
            _str = ("Hull Speed " + _result + "   Knots");
            Calc.Text = _str;
        }
   

    }
public class Sailboat
    {
        /// <summary>
        /// Calculate the hull speed for the boat.
        /// </summary>
        /// <returns>Hull speed in knots</returns>
        public static double Hullspeed(double Length)
        {
            return 1.34 * System.Math.Sqrt(Length);
        }

    }
}
