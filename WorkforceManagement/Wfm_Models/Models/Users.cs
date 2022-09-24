using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wfm_Models.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        
        public string username { get; set; }

        [JsonIgnore]
        public string password { get; set; }
  
        public string name { get; set; }

        public string role { get; set; }
        public string email { get; set; }
    }
}
