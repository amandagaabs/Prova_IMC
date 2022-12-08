using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models{
    public class Usuario{
        public int Id { get; set; }

        public string nome { get; set; }
        public DateTime nascimento { get; set; }
    }
}