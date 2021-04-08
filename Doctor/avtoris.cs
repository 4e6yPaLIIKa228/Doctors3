using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    class avtoris
    {
        static Entities db = new Entities();
            static public void Autorisation(TextBox TexBxFamil, TextBox TexBxSNULS, Window Log)
        {
            if(String.IsNullOrEmpty(TexBxFamil.Text) || String.IsNullOrEmpty(TexBxSNULS.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Autoris doc = db.Autoris.Where(c => c.Second_Name == TexBxFamil.Text && c.SNILS == TexBxSNULS.Text).SingleOrDefault();
                if(doc == null)
                {
                    MessageBox.Show("Такого пользователя не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Menu Menu = new Menu();
                    Log.Close();
                    Menu.Show();
                }
            }
        }
    }
}
