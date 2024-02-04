using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract15
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        private int current;

        public void SetStart(int x)
        {
            current = x;
        }

        public int GetNext()
        {
            return current++;
        }

        public void Reset()
        {
            // Сбрасываем значение на начальное
            current = 0;
        }
    }

    class GeomProgression : ISeries
    {
        private int current;

        public void SetStart(int x)
        {
            current = x;
        }

        public int GetNext()
        {
            return current *= 2;
        }

        public void Reset()
        {
            // Сбрасываем значение на начальное
            current = 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISeries series;

            Console.WriteLine("Арифметическая прогрессия:");
            series = new ArithProgression();
            series.SetStart(1);
            Console.WriteLine(series.GetNext()); // 1
            Console.WriteLine(series.GetNext()); // 2
            Console.WriteLine(series.GetNext()); // 3
            series.Reset();
            Console.WriteLine(series.GetNext()); // 1

            Console.WriteLine("Геометрическая прогрессия:");
            series = new GeomProgression();
            series.SetStart(1);
            Console.WriteLine(series.GetNext()); // 1
            Console.WriteLine(series.GetNext()); // 2
            Console.WriteLine(series.GetNext()); // 4
            series.Reset();
            Console.WriteLine(series.GetNext()); // 1
        }
    }
}