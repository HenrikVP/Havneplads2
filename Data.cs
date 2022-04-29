using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havneplads2
{
    internal class Data
    {
        public Queue<string?> WaitingList = new();

        public Data()
        {
            WaitingList.Enqueue("Børge");
            WaitingList.Enqueue("Bente");
            WaitingList.Enqueue("Birger");
            WaitingList.Enqueue("Butin");
        }
    }
}
