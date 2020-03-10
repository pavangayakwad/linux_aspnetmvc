using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace AspMVC.Models
{
    public class QL_College 
    {
        [Key]
        public int CLG_ID { get; set; }
        public string CollegeName { get; set; }
    }
}