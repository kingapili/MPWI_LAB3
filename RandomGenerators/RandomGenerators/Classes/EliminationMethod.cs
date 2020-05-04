using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerators.Classes
{
    class EliminationMethod
    {
        private int numberOfTuplesToGenerate;
        private (double, double) [] randomTuples;

        private double Fun(double x)
        {
            return 2 * x + 1;
        }

        private double RandDoubleInRange(double min, double max)
        {
            Random rnd = new Random();
            return rnd.NextDouble() * (max - min) + min;
        }

        private (double, double) RandTuple()
        {
            double U2 = RandDoubleInRange(0, 30);
            double U1 = RandDoubleInRange(20, 60);
            double fun_U2 = Fun(U2);
            if (U1 <= fun_U2)
                return (U2, fun_U2);
            else
                return RandTuple(); // rand as many times as it will return a tuple (u and f(u))
        }

        public EliminationMethod(int numberOfTuplesToGenerate)
        {
            this.numberOfTuplesToGenerate = numberOfTuplesToGenerate;
            randomTuples = new (double, double)[numberOfTuplesToGenerate];
        }

        public EliminationMethod RandTuples()
        {
            for(int i=0; i < numberOfTuplesToGenerate; ++i)
            {
                randomTuples[i] = RandTuple();
            }
            return this;
        }

        public void PrintRandNumbers()
        {
            for (int i = 0; i < numberOfTuplesToGenerate; ++i)
            {
                Console.WriteLine(randomTuples[i].ToString());
            }
        }
    }
}
