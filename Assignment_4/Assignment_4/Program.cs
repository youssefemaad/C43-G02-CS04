using System;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i+" ");
            }

            #endregion

            #region Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Console.WriteLine("Enter the number: ");
            int number2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(number2 + " * " + i + " = " + number2 * i);
            }


            #endregion

            #region Write a program that allows the user to insert a number then print all even numbers between 1 to this number.
            Console.WriteLine("Enter the number: ");
            int number3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number3; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            #endregion

            #region Write a program that takes two integers then prints the power.
            Console.WriteLine("Enter the number: ");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power: ");
            int power = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number4;
            }


            #endregion

            #region Write a program to enter marks of five subjects and calculate total, average and percentage.
            int[] marks = new int[5];
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the mark of subject " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }
            double average = total / 5;
            double percentage = (total / 500) * 100;




            #endregion

            #region Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }


            #endregion

            #region Write a program to allow the user to enter int and print the REVERSED of it.
            Console.WriteLine("Enter the number: ");
            int number5 = int.Parse(Console.ReadLine());
            int rev_num = 0;
            while (number5 > 0)
            {
                rev_num *= 10;
                rev_num += number5 % 10;
                number5 /= 10;
            }


            #endregion

            #region Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.WriteLine("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }


            #endregion

            #region Write a program in C# Sharp to convert a decimal number into binary without using an array.
            Console.WriteLine("Enter the decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            string binary = "";
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }
            System.Console.WriteLine(binary);

            #endregion

            #region Write a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.WriteLine("Enter the first point (x1, y1): ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second point (x2, y2): ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third point (x3, y3): ");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);
            if (slope1 == slope2)
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }
            
            #endregion

            #region Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            Console.WriteLine("Enter the size of the identity matrix: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }



            #endregion

            #region Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of all elements of the array is: " + sum);


            #endregion

            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            int[] arr1 = { 5, 4, 3, 2, 1 };
            int[] arr2 = {10, 9, 8, 7, 6 };
            int[] merged = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                merged[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                merged[i + arr1.Length] = arr2[i];
            }
            Array.Sort(merged);


            #endregion

            #region Write a program in C# Sharp to count the frequency of each element of an array.
            int[] arr3 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int[] frequency = new int[arr3.Length];
            foreach (int num in arr3)
            {
                frequency[num]++;
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine("The frequency of " + i + " is: " + frequency[i]);
                }
            }


            #endregion

            #region Write a program in C# Sharp to find maximum and minimum element in an array.
            int[] arr4 = { 1, 2, 3, 4, 5 };
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < arr4.Length; i++)
            {
                if (arr4[i] > max)
                {
                    max = arr4[i];
                }
                if (arr4[i] < min)
                {
                    min = arr4[i];
                }
            }
            Console.WriteLine("The maximum element in the array is: " + max);
            Console.WriteLine("The minimum element in the array is: " + min);

            #endregion

            #region Write a program in C# Sharp to find the second largest element in an array.
            int[] arr5 = { 1, 2, 3, 4, 5 };
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            for (int i = 0; i < arr5.Length; i++)
            {
                if (arr5[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr5[i];
                }
            }
            Console.WriteLine("The second largest element in the array is: " + secondLargest);

            #endregion

            #region Write a program to find the longest distance between two equal cells in an array of integers.
            int[] arr6 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int maxDistance = 0;
            for (int i = 0; i < arr6.Length; i++)
            {
                for (int j = i + 1; j < arr6.Length; j++)
                {
                    if (arr6[i] == arr6[j])
                    {
                        maxDistance = Math.Max(maxDistance, j - i);
                    }
                }
            }
            Console.WriteLine("The longest distance between two equal cells in the array is: " + maxDistance);


            #endregion

            #region Given a list of space separated words, reverse the order of the words.
            string sentence = "Hello World";
            string[] words = sentence.Split(' ');
            string reversedSentence = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedSentence += words[i] + " ";
            }
            Console.WriteLine(reversedSentence);


            #endregion

            #region Write a program to create two multidimensional arrays of same size, accept values, copy elements, and print the second array.
            int[,] arr7 = new int[2, 2];
            int[,] arr8 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter the value of arr7[" + i + "][" + j + "]: ");
                    arr7[i, j] = int.Parse(Console.ReadLine());
                    arr8[i, j] = arr7[i, j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr8[i, j] + " ");
                }
                Console.WriteLine();
            }


            #endregion

            #region Write a program to print one dimensional array in reverse order.
            int[] arr9 = { 1, 2, 3, 4, 5 };
            for (int i = arr9.Length - 1; i >= 0; i--)
            {
                Console.Write(arr9[i] + " ");
            }


            #endregion
        }
    }
}
