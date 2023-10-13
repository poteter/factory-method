using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factory_method.Book.Product;

namespace factory_method.Book.Creator {
	public abstract class BookTemplate {
		private List<Page> _pages = new List<Page>();

		public BookTemplate() {
			this.CreatePages();
		}

		public List<Page> Pages {
			get { return _pages; }
		}

		public abstract void CreatePages();
	}
}
