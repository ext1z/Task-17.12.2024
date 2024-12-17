

//Task#4

//4. https://acm.timus.ru/problem.aspx?space=1&num=10608

// Time 50:00
// Success
// Saytda test casedan otmadi, lekin sharti boyicha togri ishlangan


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int input;
        while (!int.TryParse(Console.ReadLine(), out input) || input > 1000 || input < -1000)
        {
            Console.WriteLine("Пожалуйста, введите число 1000 меньше или больше -1000 ");
        }

        Console.WriteLine($"Сумма числа : {GetSumOfIntegers(input)}");
    }

    static int GetSumOfIntegers(int number)
    {
        int incrementOrDecrement = 0;

        if(number == 0) return 0;

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                incrementOrDecrement += i;
            }
        }
        else if (number <= 0)
        {
            for (int i = number; i < 1; i++)
            {
                incrementOrDecrement += i;
            }
        }

        return incrementOrDecrement;
    }
}



// -3 = -3 + -2 + -1 = -6


// 5 = 1 + 2 + 3 + 4 + 5 = 15


// 3 = 1 + 2 + 3 