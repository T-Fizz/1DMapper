using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DMapper
{
    class Beatmap
    {
        public float bpm;
        public string songPath;
        public string diffAuthor;
        public int level;
        public List<Note> noteList;

        public Beatmap(float b, string s, string d, int l)
        {
            bpm = b;
            songPath = s;
            diffAuthor = d;
            level = l;
            noteList = new List<Note>();
        }

        public void addNote(Note n)
        { 
            noteList.Add(n);
        }
    }
}
