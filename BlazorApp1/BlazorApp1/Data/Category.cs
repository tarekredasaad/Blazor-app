namespace BlazorApp1.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} -Id :{Id}";
        }
    }
}
