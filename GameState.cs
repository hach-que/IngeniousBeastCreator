//
// This source code is licensed in accordance with the licensing outlined
// on the main Tychaia website (www.tychaia.com).  Changes to the
// license on the website apply retroactively.
//
using System;
using System.Collections.Generic;

namespace IngeniousBeastCreator
{
    public class GameState
    {
        public int HeartPoints;
        public List<Beast> Beasts;

        public void New()
        {
            this.HeartPoints = 5;
            this.Beasts = new List<Beast>();
        }

        public void Save()
        {
        }

        public static GameState Load()
        {

        }
    }
}

