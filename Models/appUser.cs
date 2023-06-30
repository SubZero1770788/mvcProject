using System.Net.Sockets;

namespace mvcProject.Models
{
    public class appUser
    {
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public address?  Address { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Races> Races { get; set; }
    }
}