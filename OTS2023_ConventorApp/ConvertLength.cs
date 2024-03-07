using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    public class ConvertLength : IConvert
    {
        public double Convert(double value1)
        {
            return value1 * 0.304;
        }
    }
}
