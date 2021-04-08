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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        static Entities db = new Entities();
        public Menu()
        {
            InitializeComponent();
            Hospital doc = db.Hospital.Where(c => c.Doctor == CB1.Text && c.Time == CB2.Text && c.Room == CB2.Text).SingleOrDefault();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            Log Menu = new Log();
            this.Close();
            Menu.Show();


        }

        private void BtPoisk_Click(object sender, RoutedEventArgs e)
        {
            Output Output = new Output();
            this.Close();
            Output.Show();
        }
    }
}
