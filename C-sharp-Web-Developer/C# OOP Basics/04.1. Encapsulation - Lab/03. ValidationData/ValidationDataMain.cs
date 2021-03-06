﻿using System;
using System.Collections.Generic;
using System.Text;

public class ValidationDataMain
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        var sb = new StringBuilder();

        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            catch (ArgumentException arg)
            {
                sb.AppendLine(arg.Message);
            }
        }

        var bonus = double.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(bonus));
        persons.ForEach(p => sb.AppendLine(p.ToString()));
        Console.WriteLine(sb);
    }
}