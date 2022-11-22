using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathfinderWebApp.Models
{
    public class Encounters
    {
        [Key]
        public int Id { get; set; }

        public int EncounterTotal { get; set; }
        public string? Description { get; set; }
        [ForeignKey(NPC)]
        public string? NPCID { get; set; }

    }
}
