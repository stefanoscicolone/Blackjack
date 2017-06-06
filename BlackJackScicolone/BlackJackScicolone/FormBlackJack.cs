using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackScicolone
{
    public partial class FormBlackJack : Form
    {
        public Giocatore G { get; set; }
        public Dealer D { get; set; }
        public Mazzo Mazzo { get; set; }
        public int PosD=1;
        public int PosG = 3;

        public FormBlackJack()
        {
            InitializeComponent();
        }

        private void FormBlackJack_Load(object sender, EventArgs e)
        {
            G = new Giocatore();
            D = new Dealer();
            Mazzo = new Mazzo();

            Mazzo.CreaMazzo();
            Mazzo.MescolaMazzo();

            Carta cartaG1 = Mazzo.PescaCarta();
            G.ManoGiocatore.Add(cartaG1);
            ptbCartaG1.Image = Image.FromFile("../Carte/"+ cartaG1 +".bmp");
            
            Carta cartaG2 = Mazzo.PescaCarta();
            G.ManoGiocatore.Add(cartaG2);
            ptbCartaG2.Image = Image.FromFile("../Carte/" + cartaG2 + ".bmp");

           

            Carta cartaD1 = Mazzo.PescaCarta();
            D.ManoDealer.Add(cartaD1);
            ptbCartaD1.Image = Image.FromFile("../Carte/" + cartaD1 + ".bmp");

            ptbCartaD2.Image = Image.FromFile("../Carte/carta_coperta.bmp");

            lblPuntiGiocatore.Text = Mazzo.CalcolaValoreMano(G.ManoGiocatore).ToString();
            lblPuntiDealer.Text = Mazzo.CalcolaValoreMano(D.ManoDealer).ToString();

            G.ImmaginiCarteGiocatore.Add(ptbCartaG1);
            G.ImmaginiCarteGiocatore.Add(ptbCartaG2);

            D.ImmaginiCarteDealer.Add(ptbCartaD1);
            D.ImmaginiCarteDealer.Add(ptbCartaD2);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (Mazzo.CalcolaValoreMano(G.ManoGiocatore) < 21)
            {

                if (PosG < 5)
                {
                    switch (PosG)
                    {
                        case 3:
                            Carta cartaG3 = Mazzo.PescaCarta();
                            ptbCartaG3.Image = Image.FromFile("../Carte/" + cartaG3 + ".bmp");
                            G.ManoGiocatore.Add(cartaG3);
                            break;
                        case 4:
                            Carta cartaG4 = Mazzo.PescaCarta();
                            ptbCartaG4.Image = Image.FromFile("../Carte/" + cartaG4 + ".bmp");
                            G.ManoGiocatore.Add(cartaG4);
                            break;

                    }
                    PosG++;
                }


                lblPuntiGiocatore.Text = Mazzo.CalcolaValoreMano(G.ManoGiocatore).ToString();
            }
            if (Mazzo.CalcolaValoreMano(G.ManoGiocatore) > 21)
            {
                MessageBox.Show("hai sforato"); 
            }
            }
        

    

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (Mazzo.CalcolaValoreMano(G.ManoGiocatore) <= 21)
            {
                while (Mazzo.CalcolaValoreMano(D.ManoDealer) < 22 && Mazzo.CalcolaValoreMano(D.ManoDealer) < Mazzo.CalcolaValoreMano(G.ManoGiocatore))
                {

                    if (PosD < 5)
                    {
                        switch (PosD)
                        {
                            case 2:
                                Carta cartaD2 = Mazzo.PescaCarta();
                                ptbCartaD2.Image = Image.FromFile("../Carte/" + cartaD2 + ".bmp");
                                D.ManoDealer.Add(cartaD2);
                                break;
                            case 3:
                                Carta cartaD3 = Mazzo.PescaCarta();
                                ptbCartaD3.Image = Image.FromFile("../Carte/" + cartaD3 + ".bmp");
                                D.ManoDealer.Add(cartaD3);
                                break;
                            case 4:
                                Carta cartaD4 = Mazzo.PescaCarta();
                                ptbCartaD4.Image = Image.FromFile("../Carte/" + cartaD4 + ".bmp");
                                D.ManoDealer.Add(cartaD4);
                                break;

                        }

                    }
                    PosD++;

                    lblPuntiDealer.Text = Mazzo.CalcolaValoreMano(D.ManoDealer).ToString();
                }
                if(Mazzo.CalcolaValoreMano(D.ManoDealer)<21 && Mazzo.CalcolaValoreMano(D.ManoDealer) > Mazzo.CalcolaValoreMano(G.ManoGiocatore))
                {
                    MessageBox.Show("Hai perso");
                }
               else if (Mazzo.CalcolaValoreMano(D.ManoDealer) > 21)
                {
                    MessageBox.Show("il banco ha sforato");
                }
                else
                {
                    MessageBox.Show("hai vinto");
                }
            }






        }


    }
}
