
public class Article {
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Lead { get; set; }

    public required string Content { get; set; }

    public List<Comment>? Comments { get; set; }

    public required Author Author { get; set; }

    public required Category Category { get; set; }

    public List<Tag>? Tags { get; set; }

    public Match? Match { get; set; }

    public DateTime CreationDate { get; set; }
}