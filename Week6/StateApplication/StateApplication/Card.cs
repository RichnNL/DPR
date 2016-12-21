using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StateApplication
{
    public class Card
    {
        int value;
        Image image;
        public Card(Image image,int value)
        {
            this.image = image;
            this.value = value;
        }
        public int getValue()
        {
            return value;
        }
        public Image getImage()
        {
            return image;
        }

    }
}
