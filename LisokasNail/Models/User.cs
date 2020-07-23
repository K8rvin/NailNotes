namespace LisokasNail.Models
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class User : Identity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        
    }
}
