using Microsoft.AspNetCore.Mvc;
using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace Controllers{

    [ApiController]
    [Route("[controller]")]

    public class VideosController : ControllerBase{

        private List<Videos> listaVideos { get; set; }

        public VideosController()
        {
            var context = new AluraFlixContext();
            listaVideos = context.Videos.ToList();
        }

        [HttpGet]

        public List<Videos> recuperarListaDeLivros()
        {
            return listaVideos;
        }

        [HttpPost]
        public string PostNovoVideo([FromBody] Videos novoVideo)
        {
            using (var context = new AluraFlixContext())
            {
                context.Videos.Add(novoVideo);
                context.SaveChanges();
                return $"Novo Vídeo {novoVideo.Titulo} foi adicionado com sucesso!";
            }
        }

        [HttpGet("{id}")]
        public Videos retornaVideoPorID(int id)
        {
             return listaVideos.First((video) => video.Id == id);
        }
        
    }
}