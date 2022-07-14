using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {         

        }
        #region #1 sPalidrome 
        public static bool sPalidrome(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                    return false;
            }
            return true;
        }
        #endregion

        #region #2 MinSplit
        public static int MinSplit(int amount)
        {
            int count = 0;
            Count(50);
            Count(20);
            Count(10);
            Count(5);
            Count(1);

            void Count(int currency)
            {
                int tempCount = 0;
                if (amount != 0)
                {
                    tempCount += amount / currency;
                    amount = amount - currency * tempCount;
                    count += tempCount;
                }

            }
            return count;
        }
        #endregion

        #region #3 NotConstains
        public static int NotConstains(int[] array)
        {
            int i = 1;
            while (true)
            {
                bool contain = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == i)
                    {
                        contain = true;
                    }
                }
                if (!contain)
                {
                    return i;
                }
                i++;
            }
        }
        #endregion

        #region #4 IsProperly
        public static bool IsProperly(string sequence)
        {
            bool temp = false;
            int temp1 = 0, temp2 = 0;
            char[] array = new char[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(')
                {
                    temp1++;
                }
                else
                {
                    temp2++;
                }
                array[i] = sequence[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (temp1 == temp2 && array[array.Length - 1] != '(')
                {
                    if (array[i] == '(')
                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[j] == ')')
                            {
                                array[i] = array[j] = '-';
                                temp1--;
                                temp2--;
                                temp = true;
                                break;
                            }
                            else
                            {
                                temp = false;
                            }
                        }
                        if (!temp)
                        {
                            return temp;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region #5 CountVariants
        public static int CountVariants(int stairCount)
        {
            return Variants(stairCount + 1);
            int Variants(int stairs)
            {
                if (stairs <= 1)
                    return stairs;
                return Variants(stairs - 1) + Variants(stairs - 2);
            }
        }
        #endregion
    }
}
