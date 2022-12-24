// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    // Update the method return type
    static List<Employee> GetEmployees()
    {
      // I will return a List of strings
      List<Employee> employees = new List<Employee>();
      // Collect user values until the value is an empty string
      while (true)
      {
        // Move the initial prompt inside the loop, so it repeats for each employee
        Console.WriteLine("Enter first name (leave empty to exit): ");
        // Get a name from the console and assign it to a variable
        // change input to firstName
        string firstName = Console.ReadLine();
        // Break if the user hits ENTER without typing a name
        if (firstName == "")
        {
          break;
        }
        // add a Console.Readline() for each value
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter ID: ");
        int id = Int32.Parse(Console.ReadLine());
        Console.Write("Enter photo URL: ");
        string photoUrl = Console.ReadLine();
        // Create a new Employee instance
        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        // Add currentEmployee, not a string
        employees.Add(currentEmployee);
      }
      // This is important!
      return employees;
    }

    static void Main(string[] args) //Entry Point
    {
      // Console.WriteLine("Hello, World!");

      // // C#
      // // string carModel = "Intrepid";
      // // int carPrice = 500;

      // string greeting = "Hello";
      // greeting = greeting + "World";
      // Console.WriteLine("greeting" + greeting);
      // Console.WriteLine($"greeting {greeting}"); 
      // Console.WriteLine("greeting: {0}", greeting);

      // // How do you find the area of a square?
      // double side = 3.14;
      // double area = side * side;
      // Console.WriteLine("area: {0}", area);
      // Console.WriteLine("area is a {0}", area.GetType());

      // Console.WriteLine(2 * 3);       // Basic Arithmetic: +, -, /, *
      // Console.WriteLine(10 % 3);      // Modulus Op => remainder of 10/3
      // Console.WriteLine(1 + 2 * 3);   // order of operations
      // Console.WriteLine(10 / 3.0);    // int's and doubles
      // Console.WriteLine(10 / 3);      // int's
      // Console.WriteLine("12" + "3");  // What happens here?

      // int num = 10;
      // num += 100;
      // Console.WriteLine(num);
      // num ++;
      // Console.WriteLine(num);

      // bool isCold = true;
      // Console.WriteLine(isCold ? "drink" : "add ice");    // output: drink
      // Console.WriteLine(!isCold ? "drink" : "add ice");    // output: add ice

      // string stringNum = "2";
      // int intNum = Convert.ToInt16(stringNum);
      // Console.WriteLine(intNum);
      // Console.WriteLine(intNum.GetType());

      // // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
      // // myScoreBoard.Add("firstInning", 10);
      // // myScoreBoard.Add("secondInning", 20);
      // // myScoreBoard.Add("thirdInning", 30);
      // // myScoreBoard.Add("fourthInning", 40);
      // // myScoreBoard.Add("fifthInning", 50);
      // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
      //     { "firstInning", 10 },
      //     { "secondInning", 20},
      //     { "thirdInning", 30},
      //     { "fourthInning", 40},
      //     { "fifthInning", 50}
      // };
      // Console.WriteLine("----------------");
      // Console.WriteLine("  Scoreboard");
      // Console.WriteLine("----------------");
      // Console.WriteLine("Inning |  Score");
      // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
      // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
      // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
      // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
      // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

      // string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
      // string firstFood = favFoods[0];
      // string secondFood = favFoods[1];
      // string thirdFood = favFoods[2];
      // Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

      // List<string> employees = new List<string>() { "adam", "amy" };
      // employees.Add("barbara");
      // employees.Add("billy");
      // Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

      // This is our employee-getting code now
      List<Employee> employees = GetEmployees();
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      Util.MakeBadges(employees);
    }
  }
}