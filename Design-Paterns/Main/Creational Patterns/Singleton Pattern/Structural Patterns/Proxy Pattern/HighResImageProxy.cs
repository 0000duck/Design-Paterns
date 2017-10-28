using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Proxy_Pattern
{
    public class HighResImageProxy : IImage
    {
        private string _path;
        private HighResImage _highResImage;

        public int Counter = 0;
        public HighResImageProxy(string path)
        {
            _path = path;
        }

        public bool ShowImage()
        {
            if (_highResImage == null)
            {
                _highResImage = new HighResImage(_path);
            }

            Counter = _highResImage.Counter;
            return _highResImage.ShowImage();
        }
    }
}
