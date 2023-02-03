namespace FlagsEnum
{
    [Flags]
    public enum Formats { None = 0, Hardback = 1, Paperback = 2, Ebook = 4, AudioBook = 8 }

    public class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public Formats AvailableFormats { get; set; }

        public override string ToString() => $"{Title} by {Author} ({AvailableFormats})";
    }
}
