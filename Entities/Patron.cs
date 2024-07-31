namespace LibraryManagementSystem;

public class Patron
{
    private string _name;
    private int _memebreshipNUmber;
    private string _contactDeatiles;

    public string Name
    {
        get{ return _name;}
        set{ _name = value;}
    }

    public int MemebreshipNUmber
    {
        get{ return _memebreshipNUmber;}
        set{ _memebreshipNUmber = value;}
    }

    public string ContactDeatiles
    {
        get{ return _contactDeatiles;}
        set{ _contactDeatiles = value;}
    }

    public Patron (string name, int memebreshipNUmber, string contactDeatiles)
    {
        _name = name;
        _memebreshipNUmber = memebreshipNUmber;
        _contactDeatiles = contactDeatiles;
    }
}
