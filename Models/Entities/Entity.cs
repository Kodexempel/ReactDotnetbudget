using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasReactProject.Models.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
