using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public class Character : ICharacter
    {
        private readonly char _symbol;
        private readonly int _size;
        private readonly string _font;

        public Character(char argSymbol, int argSize, string argFont)
        {
            this._symbol = argSymbol;
            this._size = argSize;
            this._font = argFont;
        }

        public void Display()
        {
            Console.WriteLine($"Symbol: {_symbol}, Size: {_size}, Font: {_font}");    
        }
    }
}
