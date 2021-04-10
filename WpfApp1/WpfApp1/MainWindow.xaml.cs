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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string pas = "qwerty";
        public MainWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Esc_and_Enter);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (password.Password==pas)
            {
                Window1 n = new Window1(pas);
                n.Show();
                
            }
            password.Password = "";
        }

        public static void ChangePass(string s)
        {
            pas = s;
        }
        private void Esc_and_Enter(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Escape)
                Close();
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
        }
    }
}
