using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersBL.Model
{
    public class Ticket
    {
        public Ticket(string name, string title, string description, bool isNameTag)
        {
            Name = name;
            Title = title;
            Description = description;
            IsNameTag = isNameTag;
        }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsNameTag { get; set; }
        public override string ToString()
        {
            return $"{Name},{Title},{Description},NameTag : {IsNameTag}";
        }
    }
}
