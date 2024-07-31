namespace LibraryManagementSystem;

public class Transaction
{
    private TransactionType _transactionType;
    private Book _book;
    private Patron _patron;
    private DateOnly _transactionDate;
    private DateOnly? _dueDate;

    public TransactionType TransactionType
    {
        get{return _transactionType;}
        set{ _transactionType = value;}
    }

    public Book Book
    {
        get{return _book;}
        set{ _book = value;}
    }

    public Patron Patron
    {
        get{return _patron;}
        set{ _patron = value;}
    }

    public DateOnly TransactionDate
    {
        get{return _transactionDate;}
        set{ _transactionDate = value;}
    }

    public DateOnly? DueDate
    {
        get{return _dueDate;}
        set{ _dueDate = value;}
    }

    public Transaction(TransactionType transactionType, Book book, Patron patron, DateOnly transactionDate, DateOnly? dueDate = null)
    {
        _transactionType = transactionType;
        _book = book;
        _patron = patron;
        _transactionDate = transactionDate;
        _dueDate = dueDate;
    }
}
