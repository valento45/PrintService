﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrintService.Services
{
    class PrintServic
    {
        int[] X = new int[10];
        int count = 0;
        public void AddValue(int value)
        {
            if (count == 10)
                throw new Exception("Is full");

            X[count] = value;
            count++;
        }

        public int First()
        {
            if (count == 0)
                throw new InvalidOperationException("PrintService está vazio!");

            return X[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count - 1; i++)
            {
                Console.Write(X[i] + ", ");
            }
            if (count > 0)
                Console.WriteLine(X[count - 1]);
            Console.Write("]");
            Console.Read();
        }
    }
}
