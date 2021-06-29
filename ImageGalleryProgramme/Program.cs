using System;

namespace ImageGalleryProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery _imageGallery = new ImageGallery(_mailAccount);
            _imageGallery.Share();

            Bluetooth _blueToothDevice = new Bluetooth();
            ImageGallery _imageGallery = new ImageGallery(_blueToothDevice);
            _imageGallery.Share();

            Whatsapp _messanger = new Whatsapp();
            ImageGallery _imageGallery = new ImageGallery(_messanger);
            _imageGallery.Share();
        }
    }
}
