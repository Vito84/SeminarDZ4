while(true)
{
Console.WriteLine("Введите 8 символов через запятую ");
string meaning = Console.ReadLine() ?? "Неверное значение";
string[] arrMeaning = meaning.Split(',');
if (arrMeaning.Length == 8)
{
    Console.WriteLine("[{0}]", string.Join(", ", arrMeaning));
    break;
}
else
    Console.WriteLine("Необходимо ввести 8 символов");

}