namespace Exercicio5PilhaFila10Numeros
{
    internal class PilhaNumero
    {
        Numero? topo;

        public PilhaNumero()
        {
            this.topo = null;
        }

        public void Push(Numero aux)
        {
            if (IsEmpty())
            {
                this.topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }

        public Numero getTopo()
        {
            return this.topo;
        }
        public Numero Pop()
        {
            if (!IsEmpty())
            {
                return topo;
            }
            return null;
        }

        public void RunOver()
        {
            Numero aux = topo;
            if (!IsEmpty())
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
            }
        }


        public bool IsEmpty()
        {
            return this.topo == null;
        }
    }
}
