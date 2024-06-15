// See https://aka.ms/new-console-template for more information
using Assingnment_1.ConsoleApp1;

Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter your name and age:");

string input;
string[] words;
int age;
string name;
Student student = new Student();


while (true)
{
    input = Console.ReadLine();
    words = input.Split(' ');
    if (words.Length > 2 ||words.Length<2)
    {
        Console.WriteLine("Please enter your 'Only One' name and age:");
        continue;
    }

    else if (int.TryParse(words[1], out age))
    {
        // Assign the second part to a string variable
        name = words[0];

        // Display the split variables
        Console.WriteLine("Name: " + name);
        Console.WriteLine("age: " + age);

        student.AddStudent(age, name);
        while (true) {
            Console.Write("do you want to add one more (y/n) ?");
            input = Console.ReadLine();
            if (input == "y" || input == "n")
                break;

            else Console.WriteLine("wrong input (y/n)");
        }
        if (input == "n")
            break;
        else if (input == "y")
        {
           Console.WriteLine("Please enter your name and age:");
        }
        else
            continue;

    }
    else
    {
        Console.WriteLine("something went wrong try again! with name and age");
        Console.WriteLine("Please enter your name and age:");
    }
}
    
    while (true)
    {
        Console.WriteLine(" press l to list all students");
        Console.WriteLine(" press d and name delete a student ex:'d mina'");
        Console.WriteLine(" press a then name and age to add student  ex:'a mina 13'");

        input = Console.ReadLine();
        words = input.Split(' ');

        switch (words[0]){
            case "l":

                if (words.Length > 1)
                {
                Console.WriteLine("Wrong input");
                break;
                }
                student.PrintStudent();
                
                break;

            case "d":
                if (words.Length !=2)
                {
                Console.WriteLine("Wrong input");
                break;
                }
            student.RemoveStudent(words[1]);
                
                break;
            case "a":
               if(words.Length == 3 && int.TryParse(words[2], out age))
                {

                    student.AddStudent(age, words[1]);
                    
                    break;
                }

                else
                {
                    Console.WriteLine("Wrong input");
                    
                    break;
                }
                
            default:
                Console.WriteLine("Wrong input");
                break;

        }


        
            Console.WriteLine("do you want to do something else? (y/n)");
            input = Console.ReadLine();
            if (input == "y")
                continue;
            else if (input != "n")
            {
                Console.WriteLine("Wronge input will redirect you to main menu");
            }
            else
                break;
        
        



    }





