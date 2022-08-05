using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Loop
{
    class Loop<T> : IEnumerable
    {
        List<T> universal = new List<T>();
        
        public void Add(T element)
        {
            universal.Add(element);

            Console.Write(String.Join(", ", universal));
            Console.WriteLine();

        }
        public void Right()
        {
            var variable = universal.Last();

            universal.Insert(0, variable);

            universal.RemoveAt(universal.Count - 1);

            Console.Write(String.Join(", ", universal));

            Console.WriteLine();
        }
        public void Left()
        {
            var variable = universal[0];

            universal.Insert(universal.Count, variable);

            universal.RemoveAt(0);

            Console.Write(String.Join(", ", universal));
            Console.WriteLine();
        }
        public T ShowFirst()
        {
            return universal[0];
        }
        public T PopOut()
        {
            var variable = universal[0];
            universal.RemoveAt(0);
            return variable;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Loop<string> loop = new Loop<string>() { "a", "b", "c", "d", "e", "f" };

            loop.Right();
            loop.Right();
            Console.WriteLine(loop.ShowFirst());
            loop.Left();
            Console.WriteLine(loop.ShowFirst());
            loop.Left();
            Console.WriteLine(loop.PopOut());
            Console.WriteLine(loop.PopOut());
            Console.WriteLine(loop.PopOut());
            
        }
    }
}
