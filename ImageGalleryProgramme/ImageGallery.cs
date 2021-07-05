using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGalleryProgramme
{
    public class ImageGallery
    {
        IApp _image;
        public void Gallery(IApp image)
        {
            this._image = image;  
        }

        public void Share()
        {
              this._image.Send();
        }

    }
}
