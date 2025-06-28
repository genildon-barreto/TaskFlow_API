using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskFlow_API.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataConclusao { get; set; }
    }
}