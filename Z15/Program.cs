Console.WriteLine("Введите цифру,обозначающую номер дня недели: 1-пн, 2-вт, 3-ср, 4-чт,5-пт, 6-сб, 7-вс");
int daynumber = int.Parse(Console.ReadLine()!);
void Checkday(int daynumber){
    if (daynumber==6||daynumber==7)
    {
        Console.WriteLine("(Это выходной)-> да");
        }
        else if(daynumber<1 && daynumber>7){
            Console.WriteLine("Это не день недели");
        }
else
{
    Console.WriteLine("(Это не выходной)-> нет");
}
}
Checkday(daynumber);