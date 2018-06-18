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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person.Focus();
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name_person = Person.Text;
                
                if (String.IsNullOrEmpty(name_person))
                    throw new Exception("Вы не ввели имя");

                string age_person = Age.Text;
                if (String.IsNullOrEmpty(name_person))
                    throw new Exception("Вы не ввели возраст");

                result.Text = $"{name_person}, Вам до пенсии - {65 - Int32.Parse(Age.Text)}";
            }
            catch(Exception error)
            {
               MessageBox.Show(error.Message, "Runtime Error",
                   MessageBoxButton.OK, MessageBoxImage.Warning);
            }  
        }
    }
}
