namespace Cursor_AI_Trial.Models
{
    public class Mood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
