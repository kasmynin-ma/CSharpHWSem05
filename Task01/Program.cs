int num1 = InputNum("Введите число n: ");
int num2 = InputNum("Введите число m: ");

int funAkk = FunctionAkkerman(num1, num2);
Console.Write($"Функция Аккермана = {funAkk} ");
Console.ReadLine();
int FunctionAkkerman(int num1, int num2)
{
    if (num1 == 0) 
    {
        return num2 + 1;
    }

    if (num2 == 0) 
    {
        return FunctionAkkerman(num1 - 1, 1);
    }
    else 
    {
        return FunctionAkkerman(num1 - 1, FunctionAkkerman(num1, num2 - 1));
    }
}

int InputNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}