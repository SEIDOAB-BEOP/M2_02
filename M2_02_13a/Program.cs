// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter numbers separated by semicolon ex. (1;2;4)");

string strInput = Console.ReadLine();
string[] arrInput = strInput.Split(";");

#region Validate the input
bool bAllOk = true;
for (int i = 0; i < arrInput.Length; i++)
{
    bAllOk = int.TryParse(arrInput[i], out _);
    if (!bAllOk)
    {
        break;
    }
}

if (!bAllOk)
{
    System.Console.WriteLine("Format error");
    return;
}
#endregion 

int sum = 0;
int sumOdd = 0;
int sumEven = 0;
for (int i = 0; i < arrInput.Length-1; i++)
{
    int intVal = int.Parse(arrInput[i]);
    sum = sum + intVal;

    if ((intVal % 2) == 0)
    {
        //Console.WriteLine($"{intVal} is even");
        sumEven += intVal;
    }
    else
    {
        //Console.WriteLine($"{intVal} is odd");
        sumOdd = sumOdd + intVal;
    }
}

Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"The odd sum is {sumOdd}");
Console.WriteLine($"The even sum is {sumEven}");
