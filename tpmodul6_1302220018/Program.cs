// See https://aka.ms/new-console-template for more information
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(String judul)
    {
        this.id = new Random().Next(10000, 99999);
        this.title = judul;
        this.playCount = 0;
    }

    public void IncereasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine(this.id);
        Console.WriteLine(this.title);
        Console.WriteLine(this.playCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Adrian");
        video.IncereasePlayCount(1);
        video.PrintVideoDetails();
    }
}
