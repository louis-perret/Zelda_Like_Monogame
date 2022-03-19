﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaMonogame.Core.Game.Metier.Entites;

namespace ZeldaMonogame.Core.Game.Metier.Deplaceur
{
    /// <summary>
    /// Interface fonctionnelle pour le déplacement
    /// </summary>
    public interface IDeplaceurEntite
    {
        bool MoveEntite(Vector2 newPos);
    }
}
