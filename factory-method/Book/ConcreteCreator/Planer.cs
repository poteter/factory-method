using factory_method.Book.ConcreteProduct;
using factory_method.Book.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method.Book.ConcreteCreator {
	public class Planer : BookTemplate{
		public Planer() { CreatePages(); }

		public override void CreatePages() {
			Pages.Add(new IndexPage(1, "", "index page"));
		}
	}
}
