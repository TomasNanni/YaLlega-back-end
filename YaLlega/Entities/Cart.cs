using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaLlega.Entities
{
    internal class Cart
    {
        //ultimo momento donde se agrego un producto al carrito
        public DateTime CreationTime { get; set; }

        public ICollection<Product> Products{ get; set; } = new List<Product>();

    }
}
