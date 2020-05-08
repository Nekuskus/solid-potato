using System;

namespace Potato
{
    public static class ArrayExtension
    {
        public static void CopyD(this Array arr, Array destination)
        {
            if(arr.Rank != destination.Rank)
            {
                throw new ArgumentException("The arrays had different numbers of destinations.");
            }
            for(int i = 0; i < arr.Rank; i++)
            {
                if(arr.GetLength(i) != destination.GetLength(i))
                {
                    throw new ArgumentException($"The lenght of arrays' dimension {i} did not match.");
                }
            }
            for(int i = 0; i < arr.Rank; i++)
            {
                for(int i2 = 0; i2 < arr.GetLength(i)-1; i2++)
                {
                    destination[i,i2] = arr[i,i2];
                }
            }
        }
    }
}
