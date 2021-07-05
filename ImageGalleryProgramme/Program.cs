using System;

namespace ImageGalleryProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();

            Bluetooth _blueToothDevice = new Bluetooth();
            
            Whatsapp _messanger = new Whatsapp();

            ImageGallery _imagegallery = new ImageGallery();
            _imagegallery.Gallery(_mailAccount);
            _imagegallery.Share();

            _imagegallery.Gallery(_blueToothDevice);
            _imagegallery.Share();

            _imagegallery.Gallery(_messanger);
            _imagegallery.Share();
        }
    }
}
