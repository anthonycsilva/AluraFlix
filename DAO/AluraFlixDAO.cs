using Contexts;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class AluraFlixDAO : IAluraFlix, IDisposable
    {
        private AluraFlixContext context = new AluraFlixContext();
        public void AdicionarNovoVideo(Videos video)
        {
            context.Videos.Add(video);
            context.SaveChanges();
        }

        public void AlterarVideo(Videos video)
        {
            context.Videos.Update(video);
            context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ExcluirVideo(Videos video)
        {
           context.Videos.Remove(video);
            context.SaveChanges();
        }

        public List<Videos> GetVideos()
        {
            return context.Videos.ToList();
        }
    }
}
