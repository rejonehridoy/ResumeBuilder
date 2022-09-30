namespace Core
{
    public class BaseModel
    {
        public int Id { get; set; }
        public List<string> ModelError { get; set; } = new List<string>();
        public List<string> SuccessMessage { get; set; } = new List<string>();
    }
}
