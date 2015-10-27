using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_5_TagHelpers.Models
{
    public class ToDoListItem
    {
        public long ItemId { get; set; }

        public string Text { get; set; }

        public bool IsCompleted { set; get; }

        public DateTime CompleteDate { set; get;  }
    }
}
