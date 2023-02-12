using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity;

namespace Assignment_2.Models
{
    public class Movies
    {
        [Key]
        public int MId { get; set; }
        
        [Required]
        [DisplayName("Movie Name")]
        public string MovieName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Dateofrelease { get; set;}
    }
    public class EFCodeFirst : DbContext
    {
        public DbSet<Movies> movies { get; set; }
    }
}