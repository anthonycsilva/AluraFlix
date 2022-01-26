using Microsoft.AspNetCore.Mvc;
using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace Controllers{

    [ApiController]
    [Route("[controller]")]

    public class VideosController : ControllerBase{

        List<Videos> listaVideos = new List<Videos>();
        Videos videosObject =  new Videos("","","");


        public VideosController(){
        }

        [HttpGet]
        public List<Videos> get(){
            return videosObject.GetVideos("SELECT * FROM Videos");
            
        }


        [HttpPost]
        public string PostNovoVideo([FromBody] Videos novoVideo){

            VideosBanco videosBanco = new VideosBanco();
            videosBanco.InsereNovoVideo(novoVideo); 

            return "Video Foi inserido!";
        }
        
    }
}