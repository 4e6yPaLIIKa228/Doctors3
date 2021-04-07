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

namespace Doctor
{
    /// <summary>
    /// Логика взаимодействия для Log.xaml
    /// </summary>
    public partial class Log : Window
    {
        public Log()
        {
            InitializeComponent();
            TexBxFamil.MaxLength = 30;
            TexBxSNULS.MaxLength = 11;
            
        }

        private void BtClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            Regist Regist = new Regist();
            this.Close();
            Regist.Show();
        }

        private void BtLog_Click(object sender, RoutedEventArgs e)
        {
            Menu Menu = new Menu();
            this.Close();
            Menu.Show();
        }

        private void TexBxFamil_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
           e.Handled = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХФЫВАПРОЛДЖЭЯЧСМИТБЮ".IndexOf(e.Text) < 0; //Только буквы(очень спорно)

        }

        private void TexBxSNULS_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0; //Только цифры
        }
    }
}
