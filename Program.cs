namespace cSharp_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            Console.WriteLine("\n set elements:");
            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
            HashSet<int> set2 = new HashSet<int>{ 5, 7, 4, 9, 10 };
            HashSet<int> set3 = set.Intersect(set2).ToHashSet();
            Console.WriteLine("\n set2 elements:");
            foreach (int i in set2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n Union set with set2 :");
            set.UnionWith(set2);
            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}