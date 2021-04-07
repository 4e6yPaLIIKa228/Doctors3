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
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
        public Regist()
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
            MainWindow MainWindow = new MainWindow();
            this.Close();
            MainWindow.Show();
        }

        private void BtLog_Click(object sender, RoutedEventArgs e)
        {
            Log Log = new Log();
            this.Close();
            Log.Show();
        }

        private void TexBxSNULS_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void TexBxFamil_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХФЫВАПРОЛДЖЭЯЧСМИТБЮ".IndexOf(e.Text) < 0; //Только буквы(очень спорно)
        }

        private void BtReg_Click(object sender, RoutedEventArgs e)
        {
            Log Log = new Log();
            this.Close();
            Log.Show();
        }
    }
}
