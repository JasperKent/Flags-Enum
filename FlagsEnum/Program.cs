using FlagsEnum;

var book = new Book 
{ 
    Title = "Twelve", 
    Author = "Jasper Kent",
    AvailableFormats = Formats.Hardback | Formats.AudioBook | Formats.Paperback
};

Console.WriteLine(book);

if (book.AvailableFormats.HasFlag (Formats.AudioBook))
    Console.WriteLine("It's available as an audio book.");