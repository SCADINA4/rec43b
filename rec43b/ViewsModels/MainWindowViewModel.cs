using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rec43b.ViewsModels.Base;



namespace rec43b.ViewsModels
{
    public class MainWindowViewModel : ViewModel
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { Set(ref number,value); }
        }

        public int Count(int n)
        {
            return Number= n < 10 ? 1 : 1 + Count(n / 10);
        }
            

    
    }

}
