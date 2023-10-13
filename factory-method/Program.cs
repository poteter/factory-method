using factory_method.Book.ConcreteCreator;
using factory_method.Book.ConcreteProduct;
using factory_method.Book.Creator;
using factory_method.Book.Product;
using System.Reflection.Metadata;

namespace factory_method {
	internal class Program {
		static void Main(string[] args) {
			BookTemplate[] books = new BookTemplate[3];
			books[0] = new NoteBook();
			books[1] = new Planer();
			books[2] = new Planer();

			foreach (var book in books) {
				for (int i = 0; i < 6; i++) {
					book.Pages.Add(new NormalPage(book.Pages.Count(), "", "yfytg hjuyf rd6"));
				}
			}

			foreach (var book in books) {
				Console.WriteLine("\n" + book.GetType().Name + "--");
				foreach (Page page in book.Pages) {
					Console.WriteLine(" " + page.GetType().Name);
                    Console.WriteLine(page.Read());
                }
			}
		}
	}
}