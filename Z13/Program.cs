Console.WriteLine("Введите число");
int input=int.Parse(Console.ReadLine()!);
void Getthirddigit(int input)
{
    while (input>=1000)input/=10;
int d=input%10;
if (input<100)
{
    Console.WriteLine("Нет третьей цифры");
}
else {
    Console.WriteLine($"Третья цифра {d}");
}
}
Getthirddigit(input);