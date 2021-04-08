using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    class input
    {
        static Entities db = new Entities();
        static public void Autorisation(ComboBox CB1, ComboBox CB2, ComboBox CB3, Window Menu)
        {
            Hospital doc = db.Hospital.Where(c => c.Doctor == CB1.Text && c.Time == CB2.Text && c.Room == CB2.Text).SingleOrDefault();
        }
    }
}