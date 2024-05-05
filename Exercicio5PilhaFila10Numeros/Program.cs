namespace Exercicio5PilhaFila10Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaNumero p1 = new();
            FilaNumero f1 = new();

            p1.Push(new(987));
            p1.Push(new(5));
            p1.Push(new(15));
            p1.Push(new(36));
            p1.Push(new(87));
            p1.Push(new(76));
            p1.Push(new(54));
            p1.Push(new(32));
            p1.Push(new(43));
            p1.Push(new(76));

            f1.Push(new(5));
            f1.Push(new(34));
            f1.Push(new(53));
            f1.Push(new(75));
            f1.Push(new(123));
            f1.Push(new(43));
            f1.Push(new(235));
            f1.Push(new(876));
            f1.Push(new(65));
            f1.Push(new(43));

        }
    }
}
