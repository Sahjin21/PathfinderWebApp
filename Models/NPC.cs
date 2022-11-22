using System.ComponentModel.DataAnnotations;

namespace PathfinderWebApp.Models
{
    public class NPC
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }

        public string Perception { get; set; }

        public string ArmorClass { get; set; }
    }
}
