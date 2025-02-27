using System;
using System.Collections.Generic;

class Program
{
    static (int count, List<int> positions) BinarySearchAll(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int count = 0;
        List<int> positions = new List<int>();

       
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                
                int temp = mid;

                
                while (temp >= 0 && arr[temp] == target)
                {
                    positions.Add(temp);
                    count++;
                    temp--;
                }

                temp = mid + 1;
                
                while (temp < arr.Length && arr[temp] == target)
                {
                    positions.Add(temp);
                    count++;
                    temp++;
                }

                positions.Sort(); 
                return (count, positions);
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return (0, new List<int>());  
    }

    static void Main()
    {
        int[] sortedArray = { 1, 2, 4, 4, 4, 5, 6, 7, 8, 9 };
        int target = 4;

        var (count, positions) = BinarySearchAll(sortedArray, target);

        Console.WriteLine($"broy namereni elementi: {count}");
        Console.WriteLine("pozicii: " + string.Join(", ", positions));
    }
}
  