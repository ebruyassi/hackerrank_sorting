using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int numberOfSwap=0;
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        for(int i=0;i<a.Count;i++){
            for(int j=i+1;j<a.Count;j++){
                if(a[i]>a[j]){
                    int temp=a[i];
                    a[i]=a[j];
                    a[j]=temp;
                    numberOfSwap++;
                }
            }
        }
        Console.WriteLine("Array is sorted in "+numberOfSwap+" swaps.");
        Console.WriteLine("First Element: "+a.First());
        Console.WriteLine("Last Element: "+a.Last());
    }
}
