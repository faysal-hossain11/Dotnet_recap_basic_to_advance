using System;

// class Program
// {
//     static void Main()
//     {
//         string developerName = "Faysal Hossain";
//         int age =  27;
//         double experienceYear = 2.5;
//         bool isLearnDotnet = true;

//         Console.WriteLine($"Name: {developerName}");
//         Console.WriteLine($"Age: {age}");
//         Console.WriteLine($"Experience: {experienceYear}");
//         Console.WriteLine($"Learning: {isLearnDotnet}"); 
//     }
// }



// class Program
// {
//     static void Main()
//     {
//         int totalTaskCompleted = 7;

//         if(totalTaskCompleted >= 8)
//         {
//             Console.WriteLine($"Great job! you finished today's tasks");
//         } else
//         {
//             Console.WriteLine($"Keep gooing, complete more tasks");
//         }
//     }
// }



class Program
{
    static void Main()
    {
        // for loop display
        Console.WriteLine($"Contune the 1 to 10");
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Serials: {i}");
        }
        

        // foreach

        Console.WriteLine($"list of foreach");
        string[] topics = ["variable", "condition", "loop", "method"];

        foreach(string topic in topics)
        {
            Console.WriteLine($"List of topis: {topic}");
        }
    }
}