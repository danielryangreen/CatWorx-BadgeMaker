using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker {
  class PeopleFetcher
  {
    // code from GetEmployees() in Program.cs
    // Update the method return type
    public static List<Employee> GetEmployees()
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

    public static List<Employee> GetFromApi() {
      List<Employee> employees = new List<Employee>();

      using (WebClient client = new WebClient())
      {
        string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
        JObject json = JObject.Parse(response);
        foreach (JToken token in json.SelectToken("results")) {
          // Parse JSON data
          Employee emp = new Employee
          (
            token.SelectToken("name.first").ToString(),
            token.SelectToken("name.last").ToString(),
            Int32.Parse(token.SelectToken("id.value").ToString().Replace("-", "")),
            token.SelectToken("picture.large").ToString()
          );
          employees.Add(emp);
        }
      }
      return employees;
    }
  }
}