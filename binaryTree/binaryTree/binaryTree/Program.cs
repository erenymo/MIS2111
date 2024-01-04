namespace binaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InOrderTraversal - String version
            Console.WriteLine("#### String Search ####");
            BinarySearchTree<string> bst = new BinarySearchTree<string>();

            bst.Insert("Eren");
            bst.Insert("Nurullah");
            bst.Insert("Mustafa Abdullah");
            bst.Insert("Lukas");
            bst.Insert("Aydın");
            bst.Insert("Arif Emre");
            bst.Insert("Töre");
            bst.Insert("Şulenur");


            Console.WriteLine("Sort left to the right : ");
            bst.SortLeftToRight();
            Console.WriteLine($"\n");
            Console.WriteLine("Sort right to the left : ");
            bst.SortRightToLeft();
            Console.WriteLine($"\n\n");

            // Binary Search Tree - INT Version
            Console.WriteLine("#### INT Search ####");
            BinarySearchTree<int> bst2 = new BinarySearchTree<int>();
            bst2.Insert(-45);
            bst2.Insert(16);
            bst2.Insert(75);
            bst2.Insert(8);
            bst2.Insert(87);
            bst2.Insert(99);
            bst2.Insert(2);

            Console.WriteLine("Sort left to the right : ");
            bst2.SortLeftToRight();
            Console.WriteLine($"\n");
            Console.WriteLine("Sort right to the left : ");
            bst2.SortRightToLeft();
            Console.WriteLine($"\n\n");
        }
    }
}