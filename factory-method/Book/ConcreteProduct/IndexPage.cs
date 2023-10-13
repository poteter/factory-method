using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factory_method.Book.Product;

namespace factory_method.Book.ConcreteProduct
{
    public class IndexPage : Page
    {

        public IndexPage(int index, string? title, string content)
        {
            Index = index;
            Title = title;
            Content = content;
        }

        public override string Read()
        {
            return Content;
        }
    }
}
