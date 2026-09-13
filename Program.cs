// using System;
// using System.Dynamic;

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



// public class Student 
// {
//     // property
//     public int Id {get; set;}
//     public string Name {get; set;}
//     public string Course {get; set;}


//     // mothod
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Id: {Id}, Name: {Name}, Course: {Course}");
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         // new object creation
//         Student student1 = new Student();
//         student1.Id = 101;
//         student1.Name = "Faysal Hossain";
//         student1.Course = "Learn .Net Backend";

//         student1.DisplayInfo();
//     }
// }




// using System;

// public class Product
// {
//     public int Id {get; set;}
//     public string Name { get; set;}
//     public double Price { get; set;}


//     public Product (int id, string name, double price)
//     {
//         Id = id;
//         Name = name;
//         Price = price;
//     }

//     public void ShowDetails()
//     {
//         Console.WriteLine($"Product: {Id}, Name: {Name}, Price: {Price}");
//     } 
// }

// class Program
// {
//     static void Main()
//     {
//         Product myProduct = new Product(1, "Laptop", 4545234 );
//         myProduct.ShowDetails();
//     }
// }



// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class TaskItem
// {
//     public int Id { get; set; }
//     public string Title { get; set; }
//     public bool IsCompleted { get; set; }


//     public TaskItem(int id, string title, bool isCompleted)
//     {
//         Id = id;
//         Title = title;
//         IsCompleted = isCompleted;
//     }

//     public void PrintTaskDetails()
//     {
//         Console.WriteLine($"ID: {Id}, Title: {Title}, Status: {IsCompleted}");
//     }
// }


// class Program
// {
//     static void Main()
//     {

//         List<TaskItem> taskList = new List<TaskItem>();

//         taskList.Add(new TaskItem(1, "my first task list 1", true));
//         taskList.Add(new TaskItem(2, "my secound task 2", false));
//         taskList.Add(new TaskItem(3, "my third task 3 ", true));

//         // TaskItem myTask = new TaskItem(1, "Learn .Net Program For my new job", true);

//         var completedTask = taskList.Where((t) => t.IsCompleted == false).ToList();

//         foreach(var task in completedTask)
//         {
//             task.PrintTaskDetails();
//         }


//         var singleTask = taskList.FirstOrDefault((t) => t.Id == 3);
//         if(singleTask != null)
//         {
//             Console.WriteLine($"\nFound task with ID 2: {singleTask.Title}");
//         } 
//     }
// }




// using System;

// public class BaseTask
// {
//     public int Id {get; set;}
//     public string Title {get; set;}


//     public BaseTask (int id, string title) {
//         Id = id;
//         Title = title;
//     }
// }

// public class WorkTask : BaseTask
// {
//     public string ProjectName {get; set;}

//     public WorkTask (int id, string title, string projectName) : base(id, title)
//     {
//         ProjectName = projectName;
//     }

//     public void ShowTaskInfo()
//     {
//         Console.WriteLine($"Id: {Id}, Title: {Title}, Project Name: {ProjectName}");
//     }

// }


// public interface ITaskRepository
// {
//     public void SaveTask(string taskName);

// }
// public class databaseTaskRepository : ITaskRepository
// {
//     public void SaveTask(string taskName)
//     {
//         Console.WriteLine($"Saving {taskName} to PostgreSQL database..");
//     }
// } 



using System;

public interface ITaskService
{
    public void CompleteTask(int id);
}

public class TaskService : ITaskService
{
    public void CompleteTask(int id)
    {
        Console.WriteLine($"task with Id {id} is marked as completed");
    }
}

class Program
{
    static void Main()
    {
        TaskService taskService = new TaskService();
        taskService.CompleteTask(44);
    }
}

