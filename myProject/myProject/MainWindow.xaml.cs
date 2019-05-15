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
using Microsoft.Win32; 

namespace myProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgPhoto_1.Source = null;
            imgPhoto_2.Source = null;
            imgPhoto_3.Source = null;
            imgPhoto_4.Source = null;
            imgPhoto_5.Source = null;

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png|" + "File TIFF (*.tiff)|*.tiff";
            if (op.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            imgPhoto.Source = null;
            for (int i = 1; i<=5;i++ )
            {
                OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png|" + "File TIFF (*.tiff)|*.tiff";
            if (op.ShowDialog() == true)
            {
                if (i==1)
                    imgPhoto_1.Source = new BitmapImage(new Uri(op.FileName));
                if (i==2)
                    imgPhoto_2.Source = new BitmapImage(new Uri(op.FileName));
                if (i == 3)
                    imgPhoto_3.Source = new BitmapImage(new Uri(op.FileName));
                if (i == 4)
                    imgPhoto_4.Source = new BitmapImage(new Uri(op.FileName));
                if (i == 5)
                    imgPhoto_5.Source = new BitmapImage(new Uri(op.FileName));

            }  

            }
            
   

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Visibility = Visibility.Visible;
            
 
        }
    }
}
