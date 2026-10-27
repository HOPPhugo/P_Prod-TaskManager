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
        public int Y { get; set; }
        public string Name { get; set; }
        public string Font { get;}
        public bool check  { get; set; }
        public short Id { get; set; }
        public Tache(string content, int x, int y, short _id)
        {
            this.Content = content;
            ChangeName();
            this.X = x;
            this.Y = y;
            check = false;
            Font = "Arial Rounded MT Bold";
            this.Id = _id;
        }
        public void ChangeName()
        {
            Name =  $"Tache N°{Id}";
        }
    }
}
