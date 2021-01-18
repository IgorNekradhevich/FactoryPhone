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

namespace WpfApp16
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
        enum models:int {LG,Motorola,Nokia };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<AbstractPhone> abstractPhones = new List<AbstractPhone>()
            {new LG(),
             new Motorola(),
             new Nokia()};

            try
            {
                PhoneFactory phoneFactory = PhoneFactory.BuildFactory(abstractPhones);
                AbstractPhone myPhone = phoneFactory.CreatePhone(15);
                myPhone.Balance = 100;
                myPhone.Call(2);
                MessageBox.Show(myPhone.getInfo());
            } 
            catch (Exception exception )
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
