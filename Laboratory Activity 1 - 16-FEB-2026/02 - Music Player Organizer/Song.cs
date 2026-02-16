using System;

public class Song{
    private string title;
    private string artist;
    private double duration;

    public Song() : this("Unknown", "Unknown", 0.0){
    }

    public Song(string title, string artist, double duration){
    if (title == "")
        this.title = "Unknown";
    else
        this.title = title;

    if (artist == "")
        this.artist = "Unknown";
    else
        this.artist = artist;

    this.duration = duration;
}


    public void DisplaySong(){
        Console.WriteLine("{0,-20} {1,-15} {2,8:F2}",
                          title, artist, duration);
    }

    public double GetDuration(){
        return duration;
    }
}

public class Program{
    public static void Main(){
        Console.Write("Songs to add: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Song[] playlist = new Song[n];

        for (int i = 0; i < n; i++){
            Console.WriteLine("\nSong #{0}", i + 1);

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            string input = Console.ReadLine();

            double duration = 0;
            double.TryParse(input, out duration);

            playlist[i] = new Song(title, artist, duration);
        }

        Console.WriteLine("=== PLAYLIST ===");
        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-20} {1,-15} {2,8}", 
                          "Title", "Artist", "Time");
                          
        Console.WriteLine(new string ('-', 48));
        
        double total = 0;

        for (int i = 0; i < n; i++){
            playlist[i].DisplaySong();
            total += playlist[i].GetDuration();
        }

        double average = (n > 0) ? total / n : 0;

        Console.WriteLine("\nTotal Duration: {0:F2} mins", total);
        Console.WriteLine("Average Duration: {0:F2} mins", average);
    }
}
