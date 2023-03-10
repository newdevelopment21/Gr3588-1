//задача: напишите программу, которая на вход принимает число N 
//  а на выходе показывает все четные числа от 1 до N
// например 15 -> 2,4,6,8,10,12,14
//          16 -> 2,4,6,8,10,12,14,16
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int index = 2; // индекс 2 так как нам нужны только четные числа.
    string outLine = string.Empty;    // подготовила пустое значение для переменной

    //если в условии цикла поставить меньше без равно, то число N в случае если оно четное выводиться не будет, 
    //а это ошибка, поэтому <=
 while (index <= inputNumber-2)
{
    // собираем строку, условие будет циклично повторяться 
    //и собирать промежуточное решение пока индекс меньше либо равно inputNumber-2
    outLine = outLine + index +",";
    index = index+2; 
}
// эта строка позволит вывести последнее значение, если ее не будет, 
// то при вводе числа 15 будет выведено 2,4,6,8,10,12,  14 не будет выведена а это ошибка
outLine = outLine + index;
// выводим данные на консоль

Console.WriteLine(outLine);
}
