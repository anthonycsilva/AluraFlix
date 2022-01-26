using Microsoft.EntityFrameworkCore;
using Model;
using System.Collections.Generic;

namespace Contexts
{
    public interface IAluraFlix
    {
        void AdicionarNovoVideo(Videos video);
        void ExcluirVideo(Videos video);
        void AlterarVideo(Videos video);
        List<Videos> GetVideos();
    }
}
