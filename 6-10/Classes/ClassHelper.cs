using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10.Classes
{
    class ClassHelper
    {
        public static List<Product> products = new List<Product>
        { new Product(){ title="Пиво",cost=100},
        new Product(){ title="вобла",cost=100} }
        ;
    }
}
