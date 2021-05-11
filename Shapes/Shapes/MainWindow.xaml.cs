using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Shape> Shapes { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            Shapes.Clear();
            DataContext = this;
        }

        private void Rectangle_Button_Click(object sender, RoutedEventArgs e)
        {
            if (float.TryParse(textBoxA.Text, out float a) && float.TryParse(textBoxB.Text, out float b)
                && string.IsNullOrEmpty(textBoxBase.Text) && string.IsNullOrEmpty(textBoxHeight.Text) && string.IsNullOrEmpty(textBoxRadius.Text))
            {
                Shapes.Add(new Shape() { Name = "Rectangle", A = a, B = b, Area = a * b });
            }
        }

        private void Circle_Button_Click(object sender, RoutedEventArgs e)
        {
            if (float.TryParse(textBoxRadius.Text, out float r) && string.IsNullOrEmpty(textBoxA.Text)
                && string.IsNullOrEmpty(textBoxBase.Text) && string.IsNullOrEmpty(textBoxHeight.Text) && string.IsNullOrEmpty(textBoxB.Text))
            {
                Shapes.Add(new Shape() { Name = "Circle", Radius= r, Area = Math.PI * Math.Pow(r, 2) });
            }
            
        }

        private void Triangle_Button_Click(object sender, RoutedEventArgs e)
        {
            if (float.TryParse(textBoxBase.Text, out float ba) && float.TryParse(textBoxHeight.Text, out float h)
                && string.IsNullOrEmpty(textBoxA.Text) && string.IsNullOrEmpty(textBoxB.Text) && string.IsNullOrEmpty(textBoxRadius.Text))
            {
                Shapes.Add(new Shape() { Name = "Triangle", Base = 5, Height = 5, Area = ba * h });
            }
            
        }
    }
}
