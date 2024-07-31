using LibraryManagementSystem;

namespace LibraryManagementSystem;

public class Book
{
    private string _title;
    private string _author;
    private int _isbn;
    private Genre _genre;
    private int _publicationYear;
    private bool _isAvailable;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Isbn
    {
        get { return _isbn; }
        set { _isbn = value; }
    }

    public Genre Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }

    public int PublicationYear
    {
        get { return _publicationYear; }
        set { _publicationYear = value; }
    }

    public bool IsAvailable
    {
        get { return _isAvailable; }
        set { _isAvailable = value; }
    }

    public Book(string title, string author, int isbn, Genre genre, int publicationYear, bool isAvailable)
    {
        _title = title;
        _author = author;
        _isbn = isbn;
        _genre = genre;
        _publicationYear = publicationYear;
        _isAvailable = isAvailable;
    }
}
