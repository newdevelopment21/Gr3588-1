
//домашняя работа , задача 7 sem1Task7 
>>>>>>> 9a5f378024585ce6a8cf358730beb0b0ba21dbe2
// условие: напиши программу которая на вход принимает ТРЕХЗНАЧНОЕ число 
//и выдает ТОЛЬКО ПОСЛЕДНЮЮ ТРЕТЬЮ ЦЫФРУ ИЗ ЭТОГО ЧИСЛА

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
<<<<<<< HEAD
    int lastDigit = inputNumber %10; // % - МНЕ НУЖЕН ОСТАТОК ОТ ДЕЛЕНИЯ НА 10
    
 Console.WriteLine(lastDigit);
}
