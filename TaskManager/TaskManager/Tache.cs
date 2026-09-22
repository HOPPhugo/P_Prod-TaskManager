using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacheEnvironnement
{
    internal class Tache
    {
        public string Content { get;}
        public int X { get;}        
        public int Y { get;}
        public string Name { get;}
        public string Font { get;}
        public bool check  { get; set; }
        public Tache(string content, string name, int x, int y)
        {
            this.Content = content;
            this.Name = name;
            this.X = x;
            this.Y = y;
            check = false;
            Font = "Arial Rounded MT Bold";

        }
    }
}
