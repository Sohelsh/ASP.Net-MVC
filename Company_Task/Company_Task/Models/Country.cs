﻿using System.ComponentModel.DataAnnotations;

namespace Company_Task.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
