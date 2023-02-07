//Домашняя работа
//задача: напишите программу которая на вход принимает два значения 
//и выдает какое из них больше. например ф = 5 а = 7 - максимальное 7


string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();

if(inputNum1 != null && inputNum2 != null)
{
int outNumber1 = int.Parse(inputNum1);
int outNumber2 = int.Parse(inputNum2);

if (outNumber1 == outNumber2)
{
    Console.WriteLine("Числа равны");
}

if (outNumber1 > outNumber2)
{
    Console.WriteLine(outNumber1 +  "max");
}
else
{
    Console.WriteLine(outNumber2 +  "max");
}
}