using System;

namespace ImageGalleryProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery _imagegmail = new ImageGallery(_mailAccount);
            _imagegmail.Share();

            Bluetooth _blueToothDevice = new Bluetooth();
            ImageGallery _imagebluetooth  = new ImageGallery(_blueToothDevice);
            _imagebluetooth.Share();

            Whatsapp _messanger = new Whatsapp();
            ImageGallery _imagewhatsapp = new ImageGallery(_messanger);
            _imagewhatsapp.Share();
        }
    }
}
