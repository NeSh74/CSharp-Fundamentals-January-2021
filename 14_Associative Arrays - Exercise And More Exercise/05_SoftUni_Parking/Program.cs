using System;
using System.Collections.Generic;

namespace _05_SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string command = parts[0];

                if (command == "register")
                {
                    string username = parts[1];
                    string licencePlate = parts[2];

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licencePlate}");
                    }
                    else
                    {
                        users.Add(username, licencePlate);
                        Console.WriteLine($"{username} registered {licencePlate} successfully");
                    }
                }
                else
                {
                    string username = parts[1];
                    bool remove = users.Remove(username);
                    if (remove)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user { username} not found");
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
