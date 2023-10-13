using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method.Book.Product
{
    public abstract class Page
    {
        public int Index { get; set; }
        public string? Title { get; set; }
        public string Content { get; set; } = string.Empty;

        public abstract string Read();
    }
}
