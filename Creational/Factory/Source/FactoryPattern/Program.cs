using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document[2];
            document[0] = new Resume();
            document[1] = new Report();

            foreach (var doc in document)
            {
                WriteLine("Document : " + doc.GetType().Name);
                foreach (Page page in doc.Pages)
                {
                    WriteLine(page.GetType().Name);
                }

            }

            ReadKey();
        }

        public abstract class Page { }

        public class Introduction : Page { }

        public class Skills : Page{ }

        public class Experience : Page { }

        public class Education : Page { }

        public class Summary : Page { }

        public class Bibliography : Page { }

        public class Conclusion : Page { }

        public abstract class Document
        {
            List<Page> _pages = new List<Page>();

            public List<Page> Pages { get { return _pages; } }

            public Document()
            {
                CreatePage();
            }

            public abstract void CreatePage();
        }

        public class Resume : Document
        {
            public override void CreatePage()
            {
                Pages.Add(new Introduction());
                Pages.Add(new Education());
                Pages.Add(new Experience());
            }
        }

        public class Report : Document
        {
            public override void CreatePage()
            {
                Pages.Add(new Introduction());
                Pages.Add(new Summary());
                Pages.Add(new Bibliography());
                Pages.Add(new Conclusion());
            }
        }
    }
}
