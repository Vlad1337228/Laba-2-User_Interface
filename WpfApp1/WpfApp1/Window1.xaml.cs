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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static string pass;
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(string s)
        {
            InitializeComponent();
            pass = s;
            passOld.Text = pass;
            this.PreviewKeyDown += new KeyEventHandler(Esc_and_Enter);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if( passNew.Text != "Новый пароль")
            {
                pass = passNew.Text;
                MainWindow.ChangePass(passNew.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void PassOld_MouseEnter(object sender, MouseEventArgs e)
        {
            if (passOld.Text == "Старый пароль")
                passOld.Text = "";
        }

        private void PassOld_MouseLeave(object sender, MouseEventArgs e)
        {
            if (passOld.Text == "")
                passOld.Text = "Старый пароль";
        }

        private void PassNew_MouseEnter(object sender, MouseEventArgs e)
        {
            if (passNew.Text == "Новый пароль")
                passNew.Text = "";
        }

        private void PassNew_MouseLeave(object sender, MouseEventArgs e)
        {
            if (passNew.Text == "")
                passNew.Text = "Новый пароль";
        }
        private void Esc_and_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
            if(e.Key==Key.Enter)
            {
                Button_Click(sender, e);
            }
        }

    }
}
