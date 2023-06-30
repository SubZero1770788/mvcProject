using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using mvcProject.Data.Enum;

namespace mvcProject.Models
{
    public class Races
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public address Address { get; set; }
        public RaceCategory RaceCategory { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public appUser? AppUser { get; set; }
    }
}