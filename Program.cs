using System;
using System.Text;
namespace ConsoleApp4

{
    

    internal class program
    {
        // Базовий клас "Ялинка"
        class Tree
        {
            public virtual void Decorate()
            {
                Console.WriteLine("Це звичайна ялинка.");
            }
        }

        // Абстрактний клас Декоратор
        abstract class TreeDecorator : Tree
        {
            protected Tree tree;

            public TreeDecorator(Tree tree)
            {
                this.tree = tree;
            }

            public override void Decorate()
            {
                tree.Decorate();
            }
        }

        // Декоратор "Ялинкові прикраси"
        class OrnamentDecorator : TreeDecorator
        {
            public OrnamentDecorator(Tree tree) : base(tree) { }

            public override void Decorate()
            {
                base.Decorate();
                Console.WriteLine("Ялинка прикрашена ялинковими іграшками.");
            }
        }

        // Декоратор "Гірлянда"
        class GarlandDecorator : TreeDecorator
        {
            public GarlandDecorator(Tree tree) : base(tree) { }

            public override void Decorate()
            {
                base.Decorate();
                Console.WriteLine("Ялинка світиться гірляндою.");
            }
        }

       
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                
                Tree tree = new Tree();
                tree.Decorate();  

                Console.WriteLine("\nДекоруємо ялинку ялинковими прикрасами:");
                
                Tree ornamentTree = new OrnamentDecorator(tree);
                ornamentTree.Decorate();  

                Console.WriteLine("\nДекоруємо ялинку ялинковими прикрасами та гірляндою:");
                // прикрасами і гірляндою
                Tree garlandTree = new GarlandDecorator(ornamentTree);
                garlandTree.Decorate(); 

                Console.ReadKey();
            }
        }
    }

}
