using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackScicolone
{
    public class Giocatore
    {
        
        public List<Carta> ManoGiocatore { get; set; }
        public List<PictureBox> ImmaginiCarteGiocatore { get; set; }

        public Giocatore()
        {
            ManoGiocatore = new List<Carta>();
            ImmaginiCarteGiocatore = new List<PictureBox>();
        }
    }
}
