using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void BubleSort(int[] soap)
    {
        // variable that contains lenght of the array
        int n = soap.Length;
       // outer loop that iterates through all elements of array
        for (int i = 0; i < n - 1; i++)
        {
            //initialize a flag to check if any swap happened
            bool stopRequired = false;
            //inner loop for comparing elements 
            for (int j = 0; j < n - i -1; j++)
            {
                // conditional operator that swaps elements  
                if (soap[j] > soap[j + 1])
                {
                    
                    int temp = soap[j];//temporary variable for swapping
                    soap[j] = soap[j + 1];//swap element
                    soap[j + 1] = temp;// complete the swap
                    stopRequired = true; //set the flag indicating a swap occurred
                }

            }
            //If no swaps occurred in the inner loop, break out of the outer loop
            if (stopRequired == false) {
                break;
            } 
        } 

    }
    public static void InsertionSort(int[] array)
    {
       // variable that contains lenght of the array
     int n = array.Length;
        // outer loop that iterates through all elements of array
        for (int i =1; i < n; i++)
        {
            // store the current element in a temporary variable
            int temp = array[i];
            int j = i - 1;
            //swaps elements of the array
            while ((j >= 0) && (array[j] > temp))
            {
                array[j + 1] = array[j];
                j--;//  move to the previous element
            }
            //place temp in the correct position
            array[j +1] = temp;
        }
        
    }
    public static void Main(string[] args)
    {
        

        int[] array = new int[30];
        for (int i = 0; i < array.Length; i++)
        {
            Random random = new Random();
            int number = random.Next(101);
            array[i] = number;
        }
        int[] arr = new int[30];
        for (int i = 0; i < arr.Length; i++)
        {
            Random random = new Random();
            int number = random.Next(101);
            arr[i] = number;
        }


        BubleSort(array);
       
        foreach (int h in array)
        {
            Console.Write($"{h} ");
        }
        Console.WriteLine("");
        InsertionSort(arr);
        foreach (int h in arr)
        {
            
            Console.Write($"{h} ");
        }
    }
}
