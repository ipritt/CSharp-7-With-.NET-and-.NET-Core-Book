using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    //  The MediaPlayer has-an AllTracks object.
    class MediaPlayer
    {
        //  Assume these methods do something useful.
        public void Play() { /* Play a song */ }
        public void Pause() { /* Pause the song */ }
        public void Stop() { /* Stop playback */ }
        //  Use a lambda expression to add additional code
        //  when the AllTracks object is made.
        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() =>
        {
            Console.WriteLine("Creating AllTracks object!");
            return new AllTracks();
        });

        public AllTracks GetAllTracks()
        {
            //  Return all of the songs.
            return allSongs.Value;
        }
    }
}
