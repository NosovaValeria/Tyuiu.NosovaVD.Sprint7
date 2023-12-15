using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NosovaVD.Sprint7.Project.V15.Lib
{
    public class DataService
    {
        public int Sum(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int summ = 0;
            for (int i = 0; i < rows; i++)
            {
                summ += array[i, 5];                 
            }
            return summ;
        }
            
    }
}
