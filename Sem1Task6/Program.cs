// ДОМАШНЯЯ РАБОТА, ЗАДАЧА №6: напиши программу которая на вход принимает число 
//и выдает является ли это число четным 
// т.е делится ли оно рна 2 без остатка
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    
    int inputNum = int.Parse(inputLine);

 if((inputNum%2) == 0) //т.е делится ли оно рна 2 без остатка
{
    Console.WriteLine( inputNum + "Да, четное");
}
else
{
    Console.WriteLine( inputNum + "нет, не четное");
}
}
