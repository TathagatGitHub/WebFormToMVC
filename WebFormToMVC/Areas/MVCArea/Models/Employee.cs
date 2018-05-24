using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebFormToMVC.Areas.MVCArea.Models
{
    public class Employee
    {
        [Key]
        public int Empid { get; set; }
        public string name { get; set; }
        
    }
}