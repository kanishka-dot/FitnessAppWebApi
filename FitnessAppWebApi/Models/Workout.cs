using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace FitnessAppWebApi.Models
{
    [PrimaryKey(nameof(UserID), nameof(Date))]
    public class Workout
    {

        public string UserID { get; set; }
        public string Date { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Exercise { get; set; }
        [Required]
        public string Time { get; set; }
        public string Calburn { get; set; }

    }
}
