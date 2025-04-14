using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.ViewModels
{
    public class ChatViewModel
    {
        public required string SenderId { get; set; }

        public required string ReceiverId { get; set; }


        public  string ReceiveDate { get; set; }

        public string Avatar { get; set; }
    }
}
