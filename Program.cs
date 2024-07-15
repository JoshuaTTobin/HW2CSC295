using System;

namespace CSC295HW2
{
    public class SingleElementFinder
    {
        // Finds the single element in a array where every other element appears twice
        public static int FindSingle(int[] arr)
        {
            int low = 0;                    // start searching from the beginning of the array
            int high = arr.Length - 1;      // marks end of search in array

            // Binary search loop to find the single element
            while (low < high)
            {
                int mid = (low + high) / 2; // middle index

                // Ensure mid is an even index
                if (mid % 2 != 0)
                    mid--;                  // adjust mid if it's odd to maintain the pair check

                // Check if the current element and the next element form a pair
                if (arr[mid] == arr[mid + 1])
                {
                    // If the pair is intact, the single element is on the right side
                    low = mid + 2;          // Skip over the pair and search on the right side
                }
                else
                {
                    // If the pair is disrupted, the single element is on the left side
                    high = mid;             // Search on the left side where the single element might be
                }
            }

            // After exiting the loop, low (or high) points to the single element in the array
            return arr[low];                // Return the single element found
        }

        public static void Main(string[] args)
        {
            // Test cases to verify the FindSingle method
            int[] arr1 = { 1 };                                                         // Expected output: 1
            int[] arr2 = { 1, 1, 2 };                                                   // Expected output: 2
            int[] arr3 = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };                     // Expected output: 7
            int[] arr4 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7, 7, 8, 8, 9, 9 };         // Expected output: 6
            int[] arr5 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10,
                           11, 11, 12, 12, 15, 15, 16, 16, 17, 20, 20, 33, 33, 35, 44,
                           44, 53, 53, 77, 77, 85, 85, 100, 100 };                     // Expected output: 17

            // Print results of test cases
            Console.WriteLine("Single element in arr1: " + FindSingle(arr1)); // Output: 1
            Console.WriteLine("Single element in arr2: " + FindSingle(arr2)); // Output: 2
            Console.WriteLine("Single element in arr3: " + FindSingle(arr3)); // Output: 7
            Console.WriteLine("Single element in arr4: " + FindSingle(arr4)); // Output: 6
            Console.WriteLine("Single element in arr5: " + FindSingle(arr5)); // Output: 17
        }
    }
}
    }
}



