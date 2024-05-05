namespace Exercicio5PilhaFila10Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaNumero p1 = new();
            FilaNumero f1 = new();

            p1.Push(new(50));
            p1.Push(new(31));
            p1.Push(new(32));
            p1.Push(new(33));
            p1.Push(new(34));
            p1.Push(new(35));
            p1.Push(new(36));
            p1.Push(new(37));
            p1.Push(new(38));
            p1.Push(new(39));


            f1.Push(new(50));
            f1.Push(new(44));
            f1.Push(new(45));
            f1.Push(new(46));
            f1.Push(new(47));
            f1.Push(new(35));
            f1.Push(new(49));
            f1.Push(new(50));
            f1.Push(new(51));
            f1.Push(new(50));

            //int opc = 0, quantidadeLivros = 0, opcTransferir;
            //do
            //{
            //    Console.Clear();

            //    Console.WriteLine("****MENU PRINCIPAL****");
            //    Console.WriteLine("Digite 1 para ver os numeros repetidos entre fila e pilha");
            //    Console.WriteLine("Digite 2 para imprimir a fila e a pilha");
            //    Console.WriteLine("Digite 0 para sair");
            //    Console.Write("Opção desejada:< > \b\b\b");
            //    opc = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    switch (opc)
            //    {
            //        case 1:
            //          NumerosRepetidos(p1, f1);
            //            break;
            //        case 2:
            //          Console.WriteLine("Pilha")
            //          p1.RunOver();
            //          Console.WriteLine("Fila")
            //          f1.RunOver();
            //            break;

            //} while (opc != 0);

            void NumerosRepetidos(PilhaNumero p, FilaNumero f)
            {
                Numero auxP = p.getTopo();
                Numero auxF = f.getHead();
                int numeroRepetido = 0;
                Console.Write("Números que se repetem: ");
                while (auxP != null)
                {
                    auxF = f.getHead();
                    while (auxF != null)
                    {
                        if (auxP.getValorNumero() == auxF.getValorNumero())
                        {
                            numeroRepetido = auxP.getValorNumero();
                            Console.Write(numeroRepetido + " ");
                        }
                        auxF = auxF.getNext();
                    }
                    auxP = auxP.getAnterior();
                }
            }
        }
    }
}
