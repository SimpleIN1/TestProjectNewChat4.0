using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewChat4._0
{
    class ChatsClass
    {
        public ChatsClass()
        {

        }
        public int id { get; set; }
        public string ChatName { get; set; }
        public string date { get; set; }
        public int IdAdmin { get; set; }
        public byte[] image { get; set; }
    }
}
