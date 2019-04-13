using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());

                Console.WriteLine(stack.Pop());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
    }
}
