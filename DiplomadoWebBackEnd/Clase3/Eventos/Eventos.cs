using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiplomadoWebBackEnd.Clase3.Eventos
{
    class Eventos
    {


        // Ejemplo de notifcar cuando una codificacion termine

    }

    class Video
    {
        public String Titulo { get; set; }
    }

    class VideoEncoder
    {
        // 1 - Definir un delegado
        // 2 - Definir un evento basado en el delegado
        // 3 - Levantar un evento

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

      //  public event EventHandler<VideoEventArgs> VideoEncoded; una forma mas corta de definir un evento sin delegado


        public void Encode(Video video)
        {
            Console.WriteLine("Codificando video...");
            Thread.Sleep(3000);

            OnVideoEncoded(); // send the video here
        }


        // por convencion: virtual para que pueda ser sobreescrito en clases derivadas

        protected virtual void OnVideoEncoded() // video como parametro
        {
            if(VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty); // new VideoEventArgs(){Video: video}

        }

    }

    class Programa
    {
        public void Prueba()
        {

            var video = new Video() { Titulo = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


            videoEncoder.Encode(video);





        } 
    }

    class MailService
    {

        public void OnVideoEncoded(object source, EventArgs args) //VideoEventArgs
        {
            Console.WriteLine("MailService: Enviando email...");
        }

    }

    class MessageService
    {

        public void OnVideoEncoded(object source, EventArgs args) //VideoEventArgs
        {
            Console.WriteLine("MessageService: Enviando mensaje de texto...");
        }

    }

    class VideoEventArgs : EventArgs
    {
        
        public Video video { get; set; }
    }

}
