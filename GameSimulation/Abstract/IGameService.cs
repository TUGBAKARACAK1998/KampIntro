﻿using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    public interface IGameService
    {
        public void Add(Game game);
        public void Update(Game game);
        public void Delete(Game game);

    }
}
