using System;
using System.Dynamic;

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



// class Program
// {
//     static void Main()
//     {
//         // for loop display
//         Console.WriteLine($"Contune the 1 to 10");
//         for(int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine($"Serials: {i}");
//         }


//         // foreach

//         Console.WriteLine($"list of foreach");
//         string[] topics = ["variable", "condition", "loop", "method"];

//         foreach(string topic in topics)
//         {
//             Console.WriteLine($"List of topis: {topic}");
//         }
//     }
// }


// class Program
// {

//     static int AddNumber(int number1, int number2)
//     {
//         return number1 + number2;
//     }

//     static void Main()
//     {
//         int result = AddNumber(20, 40);
//         Console.WriteLine($"total number: {result}");



//         // check pass or fail
//         int score = 45;
//         if(score >= 50)
//         {
//             Console.WriteLine($"Pass: {score}");
//         } else
//         {
//             Console.WriteLine($"Fail: {score}");
//         }
//     }
// }



public class Student 
{
    // property
    public int Id {get; set;}
    public string Name {get; set;}
    public string Course {get; set;}


    // mothod
    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Course: {Course}");
    }
}


class Program
{
    static void Main()
    {
        // new object creation
        Student student1 = new Student();
        student1.Id = 101;
        student1.Name = "Faysal Hossain";
        student1.Course = "Learn .Net Backend";

        student1.DisplayInfo();
    }
}