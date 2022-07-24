using System.ComponentModel.DataAnnotations;

namespace ArgusDemo.Api.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string? Name { get; set; }//null olabilecek olsunlar
        public string? LastName { get; set; }
        public string? Address { get; set; }

    }
}
