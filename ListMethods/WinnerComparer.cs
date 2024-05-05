using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    internal class WinnerComparer : IComparer<Winner>
    {
        public int Compare(Winner? x, Winner? y)
        {
            if(x == null && y == null)
            {
                return 0;
            }  
            if(x == null)
            {
                return -1; 
            } 
            if(y == null)
            {
                return 1;
            }
            else if(x.Years.Length != y.Years.Length)
            {
                return y.Years.Length - x.Years.Length;
            }
            else
            {
                return string.Compare(x.Country, y.Country);
            }
        }
    }
}
