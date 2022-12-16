using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCIS.Training.Class
{
    public class Electric
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public enum Category
        {
          DGD,
          DCN,
          A =  100,
          B,
          C= 10000,
          D,
          E,
          F
        }
    }
}
