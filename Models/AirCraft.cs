using System;
using System.ComponentModel.DataAnnotations;

namespace AircraftAPI.Models
{
    public class AirCraft
    {
        [Required]
        [StringLength(6, ErrorMessage = "Invalid Rab Code. Maximum of 5 characters")]
        public string RAB { get; set; }

        [Required]
        [Range(1, 825, ErrorMessage = "Invalid capacity. Enter a number between 1 and 825!")]
        public int Capacity { get; set; }

        [Required]
        public DateTime DtRegistry { get; set; }  
        
        public DateTime? DtLastFlight { get; set; }

        [Required]

        public string Company { get; set; } //Relação entre company...


    }
}
