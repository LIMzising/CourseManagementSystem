using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnologyCourseSystem.Models
{
    public class PartialClass
    {
    }

    [MetadataType(typeof(BookingMetadata))]
    public partial class Booking
    {
    }

    [MetadataType(typeof(CourseMetadata))]
    public partial class Cours
    {
    }

    [MetadataType(typeof(LocationMetadata))]
    public partial class Location
    {
    }

    [MetadataType(typeof(RatingMetadata))]
    public partial class Rating
    {
    }

    [MetadataType(typeof(TrainerMetadata))]
    public partial class Trainer
    {
    }

    [MetadataType(typeof(RoleMetadata))]
    public partial class AspNetRole
    {
    }
}