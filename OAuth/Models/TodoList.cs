namespace OAuth.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
        public DateTime Created { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
