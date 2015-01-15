using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yieldDemo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameMoves();
            IEnumerator enumerator = game.Cross();
            while (enumerator.MoveNext())
            {
                enumerator = enumerator.Current as IEnumerator;
            }
            Console.ReadKey();
        }
 
    }

    public class GameMoves
    {
        private IEnumerator cross;
        private IEnumerator circle;

        public GameMoves()
        {
            cross = Cross();
            circle = Circle();
        }

        private int move = 0;
        private const int MaxMove = 9;
        public IEnumerator Circle()
        {
            while (true)
            {
                Console.WriteLine("Circle,move {0}", move);
                if(++move>=MaxMove)
                    yield break;
                yield return cross;
            }
        }

        public IEnumerator Cross()
        {
            while (true)
            {
                Console.WriteLine("Cross,move {0}", move);
                if(++move>=MaxMove)
                    yield break;
                yield return circle;
            }
        }
    }
}
