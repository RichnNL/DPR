using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class SongfromIterator: ICustomIterator
    {
        private List<Songs> _itemsList = new List<Songs>();
        int position = 0;
        public SongfromIterator(List<Songs> itemsList)
        {
            _itemsList = itemsList;
        }
  
        public bool HasNext()
        {
            if (position < _itemsList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object Next()
        {
            Songs itemContents = _itemsList[position];
            position++;
            return itemContents;
        }
        public object Previous()
        {
            Songs itemContents = _itemsList[position];
            position--;
            return itemContents;
        }
    }
}
