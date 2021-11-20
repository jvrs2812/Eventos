using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                  EventoId = 1,
                  Tema = "angular 11 e .NET 5",
                  Local = "Belo Horizonte",
                  Lote = "1 lote",
                  QtdPessoas = 250,
                  DataEvento = DateTime.Now.AddDays(2).ToString(),
                  ImageURL = "foto.png",
                },
                new Evento(){
                  EventoId = 2,
                  Tema = "teste",
                  Local = "Belo Horizonte",
                  Lote = "1 lote",
                  QtdPessoas = 250,
                  DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                  ImageURL = "foto.png",
                },
                new Evento(){
                  EventoId = 3,
                  Tema = "lote",
                  Local = "Belo Horizonte",
                  Lote = "1 lote",
                  QtdPessoas = 250,
                  DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                  ImageURL = "foto.png",
                },
                new Evento(){
                  EventoId = 4,
                  Tema = "aqeqweq 5",
                  Local = "Belo Horizonte",
                  Lote = "1 lote",
                  QtdPessoas = 250,
                  DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                  ImageURL = "foto.png",
                }
        };

        public EventoController()
        {
    
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
    }
}
