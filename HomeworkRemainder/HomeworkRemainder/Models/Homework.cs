using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HomeworkRemainder.Models
{
    public class Homework
    {

        public int ID { get; set; }

     
        [Required]
        public int ClassID { get; set; }

        [StringLength(255, MinimumLength = 10)]
        [Required]
        public String  RemainderName { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

    }

    public class HomeworkDBContext : DbContext
    {
        public DbSet<Homework> Homeworks { get; set; }
    }
}