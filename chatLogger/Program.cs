using System;
class Program
{
    static void Main()
    {
        //Вход но-прост защото не изреждаме => командите readline,tolist.slpit са излишни
        List<string> chat = new List<string>();

        string command = string.Empty;

        //Цикъл
        /*
         1.Променлива за опция или ключова дума за преверката switch-case
         2.Методи за извикване,според опцията
         3.For loop за спама 
         
         :))))))) готовиииии)>
         
         */
        while ((command = Console.ReadLine()) != "end")
        {
            string[] option = command.Split();
            string key = option[0];

            switch (key)
            {
                case "Chat":
                    string message = option[1];
                    Chat(message, chat);
                    break;

                case "Delete":
                    message = option[1];
                    Delete(message, chat);
                    break;

                case "Edit":
                    string oldMessage = option[1];
                    string editedMessage = option[2];
                    Edit(oldMessage, editedMessage, chat);
                    break;

                case "Pin":
                    message = option[1];
                    Pin(message, chat);
                    break;

                case "Spam":
                    for (int i = 1; i < option.Length; i++)
                    {
                        chat.Add(option[i]);
                    }
                    break;
            }
        }

        foreach (var item in chat)
        {
            Console.WriteLine(item);
        }
    }

    static void Chat(string message, List<string> chat)
    {
        chat.Add(message);
    }

    static void Delete(string message, List<string> chat)
    {
        chat.Remove(message);
    }

    static void Edit(string message, string editedMessage, List<string> chat)
    {
        int index = chat.IndexOf(message);
        if (index != -1)
        {
            chat[index] = editedMessage;
        }
    }

    static void Pin(string message, List<string> chat)
    {
        if (chat.Contains(message))
        {
            chat.Remove(message);
            chat.Add(message);
        }
    }
}
