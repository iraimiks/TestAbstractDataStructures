using System.Collections;
using System.Xml.Linq;

namespace TestAbstractDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack
            Stack myStac = new Stack();

            myStac.Push("Hello1");
            myStac.Push("Hello2");
            myStac.Push("Hello3");
            myStac.Push("Hello4");
            myStac.Push("Hello5");
            myStac.Push("Hello6");
            myStac.Push("Hello7");

            Queue queue = new Queue();

            queue.Enqueue("Hello");
            queue.Enqueue("World");
            queue.Enqueue("!");

            string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            //each node have object type of it LinkedListNode<string>
            LinkedListNode<string> head = sentence.First;

            while (head.Next != null)
            {
                head = head.Next;
                Console.WriteLine(head.Value);
            }



           // PrintValues(sentence);
        }

        static void printOut(Stack stack)
        {
            foreach(string item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}