using Microsoft.AspNetCore.Mvc;
using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using Contexts;
using Microsoft.Extensions.DependencyInjection;
using DAO;
namespace Controllers{

    [ApiController]
    [Route("[controller]")]

    public class VideosController : ControllerBase{

        private List<Videos> listaVideos { get; set; }
        private AluraFlixDAO context { get; set; }  

        public VideosController()
        {
            context = new AluraFlixDAO();
            listaVideos = context.GetVideos();
            
        }

        [HttpGet]

        public List<Videos> recuperarListaDeLivros()
        {
            return listaVideos;
        }

        [HttpPost]
        public string PostAdicionarVideo([FromBody] Videos novoVideo)
        {
            try
            {
                context.AdicionarNovoVideo(novoVideo);
                return $"O Video {novoVideo.Titulo} foi adicionado!";
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public Videos retornaVideoPorID(int id)
        {
             return context.GetVideos().First((video) => video.Id == id);
        }
        
    }
}