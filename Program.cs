using System;

namespace StackAndQues
{
    class Program
    {
        /// <summary>
        /// UC2 Stack 70,30,56 values are Peek, Pop and empty the stack.
        /// </summary>
        /// <param name="args">The arguments.</param>

        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(70);
            st.Push(30);
            st.Push(56);

            Console.WriteLine("Before Pop the elements is");

            foreach(int i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("the pick element is=" + st.Peek());

            Console.WriteLine("After 1st time pop elements is");

            st.Pop();
            

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("the pick element is=" + st.Peek());

            Console.WriteLine("After 2st time pop elements");
            st.Pop();


            foreach (int i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("the pick element is=" + st.Peek());

            Console.WriteLine("After 3st time pop elements=0");
            st.Pop();

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Now stack is empty and Peek values also 0");


        }
    }
}