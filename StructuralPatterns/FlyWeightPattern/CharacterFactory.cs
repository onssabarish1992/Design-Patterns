using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, ICharacter> _characterMap = new();

        public ICharacter GetCharacter(char argSymbol, int size, string font)
        {
            var key = argSymbol.ToString() + size.ToString() + font;

            if (!_characterMap.ContainsKey(key))
            {
                _characterMap.Add(key, new Character(argSymbol, size, font));
            }

            return _characterMap[key];
        }
    }
}
