using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    public static class AddDrinks
    {
        
        public static CocaCola AddCola()
        {
            return new CocaCola(10);
        }

        public static Fanta AddFanta()
        {
            return new Fanta(10);
        }

        public static Sprite AddSprite()
        {
            return new Sprite(10);
        }

        public static Juice AddJuice()
        {
            return new Juice(15);
        }

        public static Vatten AddWater()
        {
            return new Vatten(5);
        }

        public static Kaffe AddCoffe()
        {
            return new Kaffe(8);
        }
    }
}
