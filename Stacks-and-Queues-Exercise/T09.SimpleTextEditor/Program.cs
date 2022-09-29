using System;
using System.Linq;
using System.Collections.Generic;

class SimpleTextEditor
{
    static void Main()
    {
        int operationsCount = int.Parse(Console.ReadLine());

        Stack<string> editingPhases = new Stack<string>();
        string text = String.Empty;
        for (int i = 0; i < operationsCount; i++)
        {
            string command = Console.ReadLine();

            char commandNum = command[0];
            if (commandNum != '4' && commandNum != '3')
            {
                editingPhases.Push(text);
            }

            if (commandNum == '1')
            {
                string textToAdd = command.Substring(2);
                text += (textToAdd);
            }
            else if (commandNum == '2')
            {
                int num = int.Parse(command.Substring(2));
                for (int j = 0; j < num; j++)
                {
                    text = text.Remove(text.Length - 1, 1);
                }
            }
            else if (commandNum == '3')
            {
                int index = int.Parse(command.Substring(2));
                Console.WriteLine(text[index - 1]);
            }
            else
            {
                text = editingPhases.Pop();
            }
        }
    }
}