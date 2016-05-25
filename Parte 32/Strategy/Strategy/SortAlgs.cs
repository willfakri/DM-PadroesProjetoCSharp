﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Strategy
    public abstract class BaseSort
    {
        public abstract void Sort(long[] inputArray);

        protected void Swap(ref long valOne, ref long valTwo)
        {
            valOne = valOne + valTwo;
            valTwo = valOne - valTwo;
            valOne = valOne - valTwo;
        }
    }

    // Context (Open Closed Principle - OCP)
    public class Context
    {
        // abstração para uma estratégia
        BaseSort _strategy;

        public Context(BaseSort strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface(long[] inputArray)
        {
            _strategy.Sort(inputArray);
       
        }
    }

    // Concrete Strategy
    public class BubbleSort : BaseSort
    {
        public override void Sort(long[] inputArray)
        {
            for(int iterator = 0; iterator < inputArray.Length; iterator++)
            {
                for (int index = 0; index < inputArray.Length - 1; index++)
                {
                    if (inputArray[index] > inputArray[index + 1])
                    {
                        Swap(ref inputArray[index], ref inputArray[index + 1]);
                    }
                }
            }
        }

        private void SwapWithTemp(ref long valOne, ref long valTwo)
        {
            long temp = valOne;
            valOne = valTwo;
            valTwo = temp;
        }
    }

    // Concrete Strategy
    public class SelectionSort : BaseSort
    {
        public override void Sort(long[] inputArray)
        {
            long index_of_min = 0;
            for (int iterator = 0; iterator < inputArray.Length - 1; iterator++)
            {
                index_of_min = iterator;
                for (int index = iterator + 1; index < inputArray.Length; index++)
                {
                    if (inputArray[index] < inputArray[index_of_min])
                        index_of_min = index;
                }
                Swap(ref inputArray[iterator], ref inputArray[index_of_min]);
            }            
        }
    }

    public class InsertionSort : BaseSort
    {
        public override void Sort(long[] inputArray)
        {
            long j;
            long temp = 0;
            for (int index = 1; index < inputArray.Length; index++)
            {
                j = index;
                temp = inputArray[index];
                while ((j > 0) && (inputArray[j - 1] > temp))
                {
                    inputArray[j] = inputArray[j - 1];
                    j = j - 1;
                }
                inputArray[j] = temp;
            }
        }
    }
}
