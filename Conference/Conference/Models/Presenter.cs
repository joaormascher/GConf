using System.ComponentModel.DataAnnotations;

namespace Conference.Models {
    public class Presenter {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Biography { get; set; }
        public string User_Owner { get; set; }       
    }
}