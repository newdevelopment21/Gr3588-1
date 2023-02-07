// задача № 4: написать программу которая на вход принимает три числа  
// и выдает максимальное из них, например 2,3,7 - 7

string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();

if(inputLine1 != null && inputLine2 != null && inputLine3 != null)
{
    int outNumber1 = int.Parse(inputLine1);
    int outNumber2 = int.Parse(inputLine2);
    int outNumber3 = int.Parse(inputLine3);

    if(outNumber1 > outNumber2) // спавниваем первое и второе число
{
    // если равенство верное и число 1 больше 2, то выполняем сравнение первого и третьего
    if(outNumber1 > outNumber3)
    {
        Console.WriteLine(inputLine1);
    }
    
    else
    {
         Console.WriteLine(inputLine3);
    }
}
    else
    {
        // еслт второе число больше первого, то сравниваем второе и третье
        if(outNumber2 > outNumber3)
        {
            Console.WriteLine(inputLine2);
        }
        else
        {
             Console.WriteLine(inputLine3);
        }
    }
}


