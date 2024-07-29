using BookStore.Models;

public class SearchViewModel
{
    public string SearchTerm { get; set; }
    public IEnumerable<Book> Books { get; set; }
}
