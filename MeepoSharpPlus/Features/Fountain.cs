﻿using Ensage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeepoSharpPlus.Features
{
    public class Fountain
    {
        private static Unit _ally;
        private static Unit _enemy;
        public static Unit GetAllyFountain()
        {
            if (_ally == null || !_ally.IsValid)
            {
                _ally = ObjectManager.GetEntities<Unit>()
                    .FirstOrDefault(x => x.Team == ObjectManager.LocalHero.Team && x.ClassID == ClassID.CDOTA_Unit_Fountain);
            }
            return _ally;
        }
        public static Unit GetEnemyFountain()
        {
            if (_enemy == null || !_enemy.IsValid)
            {
                _enemy = ObjectManager.GetEntities<Unit>()
                    .FirstOrDefault(x => x.Team != ObjectManager.LocalHero.Team && x.ClassID == ClassID.CDOTA_Unit_Fountain);
            }
            return _enemy;
        }
    }
}
