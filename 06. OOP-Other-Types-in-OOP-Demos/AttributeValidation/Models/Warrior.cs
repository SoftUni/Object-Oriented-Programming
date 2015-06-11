namespace AttributeValidation.Models
{
    using AttributeValidation.Attributes;

    public class Warrior
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Weapon Weapon { get; set; }
    }
}
