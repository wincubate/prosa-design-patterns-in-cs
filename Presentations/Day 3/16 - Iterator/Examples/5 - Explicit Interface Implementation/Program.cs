IGunslinger ac = new ArtisticCowboy();
ac.Draw();

interface IArtist
{
    void Draw();
}

interface IGunslinger
{
    void Draw();
}

class ArtisticCowboy : IArtist, IGunslinger
{
    public void Draw()
    {
        Console.WriteLine( "Swinging brush, painting canvas..." );
    }

    void IGunslinger.Draw()
    {
        Console.WriteLine("Drawing Colt .45 from gun belt...");
    }
}
