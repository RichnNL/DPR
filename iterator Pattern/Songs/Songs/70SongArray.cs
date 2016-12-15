using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class SongArray70s
    {
        private List<Songs> songList = new List<Songs>();
        public int Add(string name, string description,int year)
        {
            songList.Add(new Songs(name, description,year));
            return songList.Count;
        }
        public int Add(Songs itemContents)
        {
            songList.Add(itemContents);
            return songList.Count;
        }
        public Songs GetItem(int index)
        {
            if (index < songList.Count)
            {
                return songList[index];
            }
            else
            {
                return null;
            }
        }
        public List<Songs> GetItems()
        {
            return songList;
        }
        public bool RemoveItem(int index)
        {
            if (index < songList.Count)
            {
                songList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public ICustomIterator CreateIterator()
        {
            return new SongfromIterator(songList);
        }

    }
    



}
