using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsProject
{
    public sealed class Bagel
    {
        public int Value { get; private set; } = 3;
    }

    public class BagelSolver
    {
        public static Bagel Bagel
        {
            get
            {
                Bagel bagel = new Bagel();
                var prop = bagel.GetType().GetProperty("Value");
                prop.SetValue(bagel, 4);
                return bagel;
            }
        }
    }
}
