namespace Bflix;

public class Film
{
    public string Title { get; set; }
    public string SmallImageURI { get; set; }
    public string BigImageURI { get; set; }
    public string Description { get; set; }
    public int AudienceScore { get; set; }
    public List<Review> Reviews { get; set; }
    public List<Tuple<string, string>> People { get; set; }
}

public class Review
{
    public string ImageURI { get; set; }
    public string Text { get; set; }
    public string Author { get; set; }
}