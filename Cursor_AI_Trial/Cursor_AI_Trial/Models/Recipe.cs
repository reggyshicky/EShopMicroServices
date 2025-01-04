namespace Cursor_AI_Trial.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MoodId { get; set; }
        public virtual Mood Mood { get; set; }
    }
}
