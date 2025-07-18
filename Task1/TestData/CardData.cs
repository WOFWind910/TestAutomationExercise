using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1.TestData
{
    internal class CardData
    {
        public static Card getData()
        {
            Card card = new Card();
            card.NameCard = "Pham Trung Kien";
            card.CardNum = "12951";
            card.CVC = "311";
            card.ExpirationMonth = "11";
            card.ExpirationYear = "2027";
            return card;
        }
    }
}
