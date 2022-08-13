using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseApi.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }

    }
}