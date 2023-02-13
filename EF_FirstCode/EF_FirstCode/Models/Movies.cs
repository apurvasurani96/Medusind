using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace EF_FirstCode.Models
{
    public class Movies
    {
        [Key]
        public int Mid { get; set; }
        public string Mnae { get; set; }
        public string DateofRelease { get; set; }

    }
    public class EF_FirstCode : DbContext 
    {
        public DbSet<Movies> Movies { get; set; }

    }

}