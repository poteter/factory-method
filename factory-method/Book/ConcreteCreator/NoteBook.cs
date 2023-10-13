using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factory_method.Book.Creator;
using factory_method.Book.ConcreteProduct;

namespace factory_method.Book.ConcreteCreator {
	public class NoteBook : BookTemplate{
		public NoteBook() { CreatePages(); }

		public override void CreatePages() {
			Pages.Add(new IndexPage(1, "", "index page"));
		}
	}
}
