public class Reference
{
    private string _book;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int startVerse, int? endVerse = null)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_startVerse}";
        }
    }
}

