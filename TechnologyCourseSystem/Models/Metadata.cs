using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnologyCourseSystem.Models
{
    public class Metadata
    {
    }

    public class BookingMetadata
    {
        [Required]
        //[DataType(DataType.Date)]
        public System.DateTime BookingDate;
    }

    public class CourseMetadata
    {
        [Required]
        [StringLength(50)]
        public string CourseName;

        [Required]
        public string CourseDescription;

        [Required]
        [StringLength(50)]
        public string CourseCategory;
    }

    public class LocationMetadata
    {
        [Required]
        [StringLength(50)]
        public string LocationName;

        [Required]
        public string LocationAddress;

        [Required]
        [Range(-90, 90)]
        public decimal LocationLatitude;

        [Required]
        [Range(-180, 180)]
        public decimal LocationLongitude;
    }

    public class RatingMetadata
    {
        [Required]
        [Range(1, 5)]
        public int RatingScore;
    }

    public class TrainerMetadata
    {
        [Required]
        [StringLength(50)]
        public string TrainerName;
    }

    public class RoleMetadata
    {
        [Required]
        [StringLength(128)]
        public string Id;

        [Required]
        [StringLength(256)]
        public string Name;
    }
}