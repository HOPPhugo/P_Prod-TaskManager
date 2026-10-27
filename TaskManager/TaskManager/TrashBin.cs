using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class TrashBin
    {

        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public short Id { get; set; }
        public bool State { get; set; }

        public TrashBin(int _x, int _y, string _name, short _id)
        {
            this.X = _x;
            this.Y = _y;
            this.Name = _name;
            this.Id = _id;
            State = false;
        }
    }
}
