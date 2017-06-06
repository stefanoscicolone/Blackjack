using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackScicolone
{
    public class Dealer
    {

        public List<Carta> ManoDealer { get; set; }
        public List<PictureBox> ImmaginiCarteDealer { get; set; }

        public Dealer()
        {
            ManoDealer = new List<Carta>();
            ImmaginiCarteDealer = new List<PictureBox>();
        }
    }
}
