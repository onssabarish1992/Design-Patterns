

using IteratorPattern;

var playlist = new PlayList();

playlist.AddSong(new Song("Title 1", "Artist 1"));
playlist.AddSong(new Song("Title 2", "Artist 2"));
playlist.AddSong(new Song("Title 3", "Artist 3"));

IIterator<Song> iterator = playlist.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
Console.ReadLine();
