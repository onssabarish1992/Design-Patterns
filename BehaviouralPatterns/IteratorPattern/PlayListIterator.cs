using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PlayListIterator : IIterator<Song>
    {
        private readonly PlayList _playlist;
        private int _index = 0;

        public PlayListIterator(PlayList playlist)
        {
            _playlist = playlist;
        }

        public bool HasNext()
        {
            return _index < _playlist.Count;
        }

        public Song Next()
        {
            return _playlist[_index++];
        }
    }
}
