namespace _01Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>();

            for (int i = 0; i < n; i++)
            {
                string[] songsInfo = Console.ReadLine().Split("_");

                Songs currentSong = new Songs();
                currentSong.TypeList = songsInfo[0];
                currentSong.SongName = songsInfo[1];
                currentSong.Time = songsInfo[2];

                songs.Add(currentSong);
            }

            string typeListName = Console.ReadLine();

            if (typeListName == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.SongName);
                }
            }
            else
            {
                foreach (var song in songs.Where(song => song.TypeList == typeListName))
                {
                    Console.WriteLine(song.SongName);
                }
            }        
        }
    }
    class Songs
    {
        public string TypeList { get; set; }

        public string SongName { get; set; }

        public string Time { get; set; }

    }
}