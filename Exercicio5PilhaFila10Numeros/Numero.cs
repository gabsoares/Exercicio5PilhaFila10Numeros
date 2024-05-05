namespace Exercicio5PilhaFila10Numeros
{
    internal class Numero
    {
        int valorNumero;
        Numero? anterior;
        Numero? proximo;

        public Numero(int n)
        {
            this.valorNumero = n;
            this.anterior = null;
            this.proximo = null;
        }

        public void setNext(Numero aux)
        {
            this.proximo = aux;
        }

        public Numero? getNext()
        {
            return this.proximo;
        }

        public void setNumero(int valorNumero)
        {
            this.valorNumero = valorNumero;
        }

        public int getValorNumero()
        {
            return this.valorNumero;
        }

        public void setAnterior(Numero anterior)
        {
            this.anterior = anterior;
        }

        public Numero getAnterior()
        {
            return this.anterior;
        }

        public override string? ToString()
        {
            return "Número: " + valorNumero;
        }
    }
}
