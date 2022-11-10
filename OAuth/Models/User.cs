namespace OAuth.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public TodoList TodoList { get; set; }
    }
}
