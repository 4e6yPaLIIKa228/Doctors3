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


namespace Doctor
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

        private void BtClouse_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void BtOpen_Click(object sender, RoutedEventArgs e)
        {
            Log Log = new Log();
            this.Close();
            Log.Show();
        }

        private void BtRegist_Click(object sender, RoutedEventArgs e)
        {
            Regist Regist = new Regist();
            this.Close();
            Regist.Show();
        }
    }
}
