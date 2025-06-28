using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskFlow_API.Models;

namespace TaskFlow_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private static List<Tarefa> tarefas = new List<Tarefa>
        {
            new Tarefa
            {
                Id = Guid.NewGuid(),
                Titulo = "Tarefa 1",
                Descricao = "Criar a API de Tarefas",
                Status = "Concluída",
                DataCriacao = DateTime.Now.AddHours(-2),
                DataConclusao = DateTime.Now.AddHours(-1)
            },
            new Tarefa
            {
                Id = Guid.NewGuid(),
                Titulo = "Tarefa 2",
                Descricao = "Implementar o endpoint de criação",
                Status = "Em Progresso",
                DataCriacao = DateTime.Now.AddHours(-1),
                DataConclusao = DateTime.Now.AddMinutes(-30)
            },
            new Tarefa
            {
                Id = Guid.NewGuid(),
                Titulo = "Tarefa 3",
                Descricao = "Testar a API",
                Status = "Pendente",
                DataCriacao = DateTime.Now.AddHours(-1),
                DataConclusao = DateTime.Now.AddMinutes(-10)
            }
        };   
        [HttpGet("Exibir Todas as Tarefas")]
        public IActionResult GetTodasTarefas()
        {
            return Ok(tarefas);
        }
    }
}