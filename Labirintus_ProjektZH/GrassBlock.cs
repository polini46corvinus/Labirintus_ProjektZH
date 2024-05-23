using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirintus_ProjektZH
{
    internal class GrassBlock : PictureBox
    {
        public GrassBlock()
        {
            Height = 32;
            Width = 32;
            Image = Properties.Resources.grass;
        }
    }
}