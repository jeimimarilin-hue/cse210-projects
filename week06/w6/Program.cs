using System;
using System.Collections.Generic;
using System.IO;

// Creativity: I added scores, several levels (novice, intermediate and expert)
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\n--- ETERNAL QUEST ---");
            Console.WriteLine($"Current Score: {manager.GetScore()}");
            Console.WriteLine("1. Add Goal\n2. List Goals\n3. Record Event\n4. Save Goals\n5. Load Goals\n6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "6") running = false;
            else if (choice == "1")
            {
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                string pts = Console.ReadLine();

                if (type == "1") manager.AddGoal(new SimpleGoal(name, desc, pts));
                else if (type == "2") manager.AddGoal(new EternalGoal(name, desc, pts));
                else if (type == "3")
                {
                    Console.Write("Target: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                }
            }
            else if (choice == "2")
            {
                foreach (var goal in manager.GetGoals())
                    Console.WriteLine(goal.GetDetailsString());
            }
            else if (choice == "3")
            {
                var goals = manager.GetGoals();
                for (int i = 0; i < goals.Count; i++) Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                Console.Write("Which goal did you accomplish? ");
                manager.RecordEvent(int.Parse(Console.ReadLine()) - 1);
            }
            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    outputFile.WriteLine(manager.GetScore());
                    foreach (var goal in manager.GetGoals())
                        outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            else if (choice == "5")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                string[] lines = File.ReadAllLines(file);
            }
        }
    }
}