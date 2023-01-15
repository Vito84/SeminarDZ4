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

int decision(int numbers, int degree)
{
    int sum = 1;
    for (int i = 1; i <= degree; i++)
    {
        sum = sum * numbers;
    }
    Console.WriteLine($"Число {numbers} в степини {degree} равно {sum}");
    return sum;
}

int numbers = outputFromConsole("Введите число");
int degree = outputFromConsole("Введите степень");
decision(numbers, degree);


