// Import correct packages
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace CatWorx.BadgeMaker
{
  class Util
  {
    // Method declared as "static"
    // Add List parameter to method
    public static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        // each item in employees is now an Employee instance
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
      }
    }

    public static void MakeCSV(List<Employee> employees)
    {
      // Check to see if folder exists
      if (!Directory.Exists("data"))
      {
        // If not, create it
        Directory.CreateDirectory("data");
      }

      using (StreamWriter file = new StreamWriter("data/employees.csv"))
      {
        // Any code that needs the StreamWriter would go in here
        file.WriteLine("ID,Name,PhotoUrl");
        // Loop over employees
        for (int i = 0; i < employees.Count; i++)
        {
          // Write each employee to the file
          string template = "{0},{1},{2}";
          file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
        }
      }
    }

    public static void MakeBadges(List<Employee> employees)
    {
      // Create image
      Image newImage = Image.FromFile("badge.png");
      newImage.Save("data/employeeBadge.png");
    }
  }
}