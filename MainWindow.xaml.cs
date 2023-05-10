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

namespace all_the_way
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      //  private Car car;
        

        public MainWindow()
        {


            InitializeComponent();

          

           Car car = new Car();
            car.Engine = new Engine(250, 4000, "gasoline");
            car.Wheels = new List<Wheel> {
            new Wheel(18, "Goodyear"),
            new Wheel(18, "Goodyear"),
            new Wheel(18, "Goodyear"),
            new Wheel(18, "Goodyear")
};

      
            string message = $"Engine: {car.Engine.Horsepower} HP {car.Engine.Displacement} cc {car.Engine.FuelType}\n";
            foreach (Wheel wheel in car.Wheels)
            {
                message += $"Wheel: {wheel.Size}\" {wheel.Brand}\n";
            }

           
            MessageBox.Show(message, "Car Information");



        }


    }
}
