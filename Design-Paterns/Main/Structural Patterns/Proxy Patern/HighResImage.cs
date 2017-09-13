﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Proxy_Patern
{
    public class HighResImage : IImage
    {
        private bool _imageIsLoaded = false;
        public int Counter = 0;
        public HighResImage(string imagepath)
        {
            loadExpensiveResource(imagepath);
        }

        private void loadExpensiveResource(string path)
        {
            Counter += 1;
            _imageIsLoaded = true;
        }

        public bool ShowImage()
        {
            return _imageIsLoaded;
        }
    }
}
