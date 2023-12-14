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
            int columns = array.Length / rows;
            int summ = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    summ += array[i, j];                 
                }
            }
            return summ;
        }

    }
}
