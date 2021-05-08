using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Delete(Game game);
        void Add(Game game);
        void Update(Game game);
    }
}
