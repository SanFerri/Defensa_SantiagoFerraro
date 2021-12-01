namespace Ucu.Poo.Defense
{
    public class Material
    {
        public bool IsDangerous { get; set; }
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
            this.IsDangerous = type.IsDangerous;
        }
    }
}