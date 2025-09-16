using System.ComponentModel.DataAnnotations;

namespace PF_LAB3_BSIT32A1_Terrance_Soriano.Models
{
    public class Card
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Card Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Rarity")]
        public CardRarity Rarity { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Character Name")]
        public string CharacterName { get; set; } = string.Empty;

        [Display(Name = "Character Image URL")]
        public string? CharacterImageUrl { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Card Number")]
        public int CardNumber { get; set; }

        [Display(Name = "Card Type")]
        public CardType CardType { get; set; }

        [Range(1, 10)]
        [Display(Name = "Power Level")]
        public int PowerLevel { get; set; }

        [StringLength(200)]
        [Display(Name = "Special Ability")]
        public string? SpecialAbility { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Display(Name = "Created By User")]
        public string? CreatedByUserId { get; set; }
    }

    public enum CardRarity
    {
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        SuperRare = 4,
        UltraRare = 5,
        Legendary = 6
    }

    public enum CardType
    {
        Attack = 1,
        Defense = 2,
        Magic = 3,
        Item = 4,
        Spell = 5,
        Transform = 6
    }
}
