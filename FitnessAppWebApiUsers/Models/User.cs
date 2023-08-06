using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessAppWebApiUsers.Models
{
    [PrimaryKey(nameof(Email))]
    public class User
    {

        public string Email { get; set; }
        [Required]
        public string Name { get ; set ; }
        [Required]
        public string Age { get; set ; }
        public string Height { get ; set; }
        public string Gender { get; set; }
        public string Weight { get ; set ; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Column(TypeName= "bit")]
        public Boolean IsLoged { get; set; }


    }
}
