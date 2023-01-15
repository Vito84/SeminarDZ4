int outputFromConsole(string message)
{
    Console.WriteLine(message);
    int numbers = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out numbers))
        {
            return numbers;
        }
        else
        {
            Console.WriteLine("Необходимо ввести число!");
            Console.WriteLine("_________________________");
        }
    }
}
void decision(int numberEntered)
{
    string strNumberEntered = numberEntered.ToString();
    int[] arr = new int[strNumberEntered.Length];
    int sum = 0;
    for (int i = 0; i < strNumberEntered.Length; i++)
    {
        arr[i] = int.Parse(strNumberEntered[i].ToString());
        sum += arr[i];
    }
    Console.WriteLine($"Сумма цифр в числе {sum}");
}
int numberEntered = outputFromConsole("Введите число");
decision(numberEntered);
