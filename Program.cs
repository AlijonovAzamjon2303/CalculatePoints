using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<int> khabibsScore = new List<int>{6, 5, 7, 9};
        List<int> conorsScore = new List<int>{5, 6, 5, 4};
        var result = CalculatePoints(khabibsScore, conorsScore);
        Console.WriteLine($"Khabib's point : {result[0]}");
        Console.WriteLine($"Conors's point : {result[1]}");
    }
    public static List<int> CalculatePoints(List<int> first, List<int> second)
    {
        List<int> result = new List<int>();
        int pointsFirst = 0, pointsSecond = 0;
        for(int i = 0; i < first.Count; i++)
        {
            if(first[i] > second[i])
            {
                pointsFirst++;
            }
            if(first[i] < second[i])
            {
                pointsSecond++;
            }
        }
        result.Add(pointsFirst);
        result.Add(pointsSecond);
        
        return result;
    }
}