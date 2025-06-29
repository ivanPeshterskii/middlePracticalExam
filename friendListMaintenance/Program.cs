using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Четем списъка с приятелите ни
        List<string> friends = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        // Четем командите
        string command = string.Empty;
        // Броиките за изход 
        int countBlackList = 0;
        int countLost = 0;
        // Цикъл
        while ((command = Console.ReadLine()) != "Report")
        {
            // Разделяме командите за по-лесна проверка
            string[] option = command.Split(" ");
            string key = option[0];

            switch (key)
            {
                case "Blacklist":
                    string name = option[1];
                    Blacklist(name, ref countBlackList, friends);
                    break;

                case "Error":
                    int index = int.Parse(option[1]);
                    Error(index, ref countLost, friends);
                    break;

                case "Change":
                    index = int.Parse(option[1]);
                    string newName = option[2];
                    Change(newName, index, friends);
                    break;
            }
        }

        Console.WriteLine($"Blacklisted names: {countBlackList}");
        Console.WriteLine($"Lost names: {countLost}");
        Console.WriteLine(string.Join(" ", friends));
    }
    /* Създаваме методи за всяка операция
     * !! използваме 'ref' иначе няма да имаме промяна в стойностите  'countBlackList' и 'countLost';
     * Готовии:)
     */
    static void Blacklist(string name, ref int countBlackList, List<string> friends)
    {
        if (friends.Contains(name))
        {
            int index = friends.IndexOf(name);
            friends[index] = "Blacklisted";
            countBlackList++;
            Console.WriteLine($"{name} was blacklisted.");
        }
        else
        {
            Console.WriteLine($"{name} was not found.");
        }
    }

    static void Error(int index, ref int countLost, List<string> friends)
    {
        if (index >= 0 && index < friends.Count)
        {
            string name = friends[index];
            if (name != "Blacklisted" && name != "Lost")
            {
                friends[index] = "Lost";
                countLost++;
                Console.WriteLine($"{name} was lost due to an error.");
            }
        }
    }

    static void Change(string newName, int index, List<string> friends)
    {
        if (index >= 0 && index < friends.Count)
        {
            string oldName = friends[index];
            friends[index] = newName;
            Console.WriteLine($"{oldName} changed his username to {newName}.");
        }
    }
}
