using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelOS.Classes
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Path { get; set; }    

        public Song(string title, string artist, string path)
        {
            Title = title;
            Artist = artist;
            Path = path;
        }
    }
}
