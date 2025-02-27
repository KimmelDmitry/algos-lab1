using System;

class lab1
{
    static void Main()
    {
        Console.Write("Введите количество дисков: ");
        int n = int.Parse(Console.ReadLine());
        Hanoy(n, 'a', 'b', 'c');

        int N = 3;
        int M = 2;
        Console.WriteLine("Перестановки из " + N + " по " + M + ":");
        GeneratePermutations(N, M);
    }

    static void GenerateNumbers(int N, int M, List<int> current)
    {
        if (current.Count == M)
        {
            Console.WriteLine("[" + string.Join(", ", current) + "]");
            return;
        }
        for (int i = 0; i < N; i++)
            if (!Find(i, current))
            {
                current.Add(i);
                GenerateNumbers(N, M, current);
                current.RemoveAt(current.Count - 1);
            }
    }

    static bool Find(int number, List<int> A)
    {
        foreach (int item in A)
        {
            if (item == number)
            {
                return true;
            }
        }
        return false;
    }

    static void GeneratePermutations(int N, int M)
    {
        GenerateNumbers(N, M, new List<int>());
    }


static void Hanoy(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Диск 1 : {from} -> {to}");
            return;
        }

        Hanoy(n - 1, from, aux, to);
        Console.WriteLine($"Диск {n} : {from} -> {to}");
        Hanoy(n - 1, aux, to, from);
    }


}
