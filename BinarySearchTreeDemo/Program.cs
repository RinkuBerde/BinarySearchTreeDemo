namespace BinarySearchTreeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Binary Search Tree Demo!!!");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(31);
            binarySearch.Insert(75);
            binarySearch.Insert(29);
            binarySearch.Insert(42);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            // binarySearch.Insert(65);
            // binarySearch.Insert(3);
            // binarySearch.Insert(16);
            // binarySearch.Insert(63);
            //binarySearch.Insert(67);
            binarySearch.Display();
            bool result = binarySearch.IfExists(67, binarySearch);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}