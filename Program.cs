   Console.WriteLine("Введите трехзначное число");
 int input = int.Parse(Console.ReadLine()!);
  int Getsecond(int input)
        {
            int thirddigit = input % 100;
            int seconddigit = thirddigit / 10;
            return seconddigit;
        }
        int seconddigit = Getsecond(input);
        Console.WriteLine($"Вторая цифра {seconddigit}");