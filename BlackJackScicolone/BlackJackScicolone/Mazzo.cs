using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackScicolone
{
    public class Mazzo
    {
        public List<Carta> deck = new List<Carta>();

        public void CreaMazzo()
        {
            foreach (Seme seme in Enum.GetValues(typeof(Seme)))
                foreach (Valore valore in Enum.GetValues(typeof(Valore)))
                    deck.Add(new Carta(seme, valore));
        }

        public void MescolaMazzo()
        {
            Random r = new Random();
            int numeroMescolamenti = r.Next(50, 100);
            int posizione1;
            int posizione2;
            for (int i = 0; i < numeroMescolamenti; i++)
            {
                posizione1 = r.Next(deck.Count);
                do
                {
                    posizione2 = r.Next(deck.Count);
                } while (posizione1 == posizione2);

                Carta cartaTemp = deck[posizione1];
                deck[posizione1] = deck[posizione2];
                deck[posizione2] = cartaTemp;

            }
        }

        public void MescolaMazzo(int numeroMescolamenti)
        {
            Random r = new Random();
            int posizione1;
            int posizione2;
            for (int i = 0; i < numeroMescolamenti; i++)
            {
                posizione1 = r.Next(deck.Count);
                do
                {
                    posizione2 = r.Next(deck.Count);
                } while (posizione1 == posizione2);

                Carta cartaTemp = deck[posizione1];
                deck[posizione1] = deck[posizione2];
                deck[posizione2] = cartaTemp;

            }
        }

        public Carta PescaCarta()
        {
            Carta carta = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return carta;
        }

        public int CalcolaValoreMano(List<Carta> mano)
        {
            int totale = 0;
            foreach (Carta c in mano)
                totale += c.CalcolaValoreCarta();
            return totale;
        }

        public int NumeroCarteMazzo()
        {
            return deck.Count;
        }
    }
}
