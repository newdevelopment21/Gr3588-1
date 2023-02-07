// задача 5: напишите программу которая на вход принимает одно число  N 
// а на выходе выдает все ЦЕЛЫЕ числа в промежутке от -N до N]

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int startNumber = inputNumber * (-1); // так мы получим отрицательное значение для  N.
    // Входное значение
    string outLine = string.Empty;
    while (startNumber<inputNumber)
{
    outLine = outLine + startNumber+",";
    startNumber++;
    // startNumber = startNumber+1

}
outLine = outLine+ inputNumber;
// выводим данные на консоль

Console.WriteLine(outLine);
}
