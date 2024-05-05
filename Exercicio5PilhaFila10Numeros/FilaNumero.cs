namespace Exercicio5PilhaFila10Numeros
{
    internal class FilaNumero
    {
        Numero? head, tail;

        public FilaNumero()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Numero aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                this.tail.setNext(aux);
                this.tail = aux;
            }
        }

        public Numero Pop()
        {
            if (!IsEmpty())
            {
                if (tail == head)
                {
                    head = tail = null;
                }
                else
                {
                    return this.head;
                }
            }
            return null;
        }

        public void RunOver()
        {
            Numero aux = this.head;
            if (!IsEmpty())
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getNext();
                } while (aux != null);
            }
        }
        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
