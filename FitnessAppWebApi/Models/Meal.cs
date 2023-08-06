using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitnessAppWebApi.Models
{
    [PrimaryKey(nameof(UserID), nameof(Date))]
    public class Meal
    {

        public string UserID { get; set; }
        public string Date { get;  set; }
        [Required]
        public string Totcalories { get; set; }
        public string Totcarbs { get; set; }
        public string Totprotien { get; set; }
        public string Totfat { get; set; }
    }
}
