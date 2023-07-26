using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class DortIslem
    {
        public void topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            MessageBox.Show(sonuc.ToString());
        }
    }
}
