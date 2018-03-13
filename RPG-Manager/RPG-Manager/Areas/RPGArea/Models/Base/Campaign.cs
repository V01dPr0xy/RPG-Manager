using RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes;
using RPG_Manager.Areas.RPGArea.Models.Relationships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Models
{
    public class Campaign
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Campaign_ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public Register DungeonMaster { get; set; }
        public ICollection<Relationships_CampaignAndCharacter> CharacterRelationships { get; set; }
        public ICollection<Relationship_CampaignAndAccount> AccountRelationships { get; set; }
        //public Dictionary<Account, string> Log { get; set; }
        public int Turns { get; set; }
    }
}
