using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGalleryProgramme
{
    class ImageGallery
    {
        Iapp app;
        public ImageGallery(Iapp image)
        {
            this.app = image;  
        }

        public void Share()

        {
              app.Send();
        }

    }
}
