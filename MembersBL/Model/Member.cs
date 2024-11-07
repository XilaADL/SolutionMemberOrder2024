using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersBL.Model
{
    public class Member
    {
        public Member(int id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            MedalType = null;
        }

        public Member(int id, string name, string email, string address, MedalType? medalType) : this(id, name, email, address)
        {
            MedalType = medalType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public MedalType? MedalType { get; set; }
        public override string ToString()
        {
            return $"{Id},{Name},{Email},{Address}";
        }
    }
}
