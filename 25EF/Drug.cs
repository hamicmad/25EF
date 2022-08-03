using System;


namespace _25EF
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string? ActiveIngredient { get; set; }
    }
}
