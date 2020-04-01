using System;

namespace lab10_4mediap
{
    interface IAutoPlayer
    {
        void play();
    }
    class Program
    {
        static void Main(string[] args)
        {
            artist prince = new artist("prince");
            prince.AddToPlaylist("purp rain");
            prince.AddToPlaylist("LRC");
            prince.AddToPlaylist("KISS");
            prince.AddToPlaylist("doves cry");

            media player = new media();
            player.playermedia(prince);

            audiob book = new audiob ("how to win friends","dale");
            player.playermedia(book);

            moviest starw = new moviest("starwars");
            starw.SelectTrack("theme");
            player.playermedia(starw);


        }
    }
}
