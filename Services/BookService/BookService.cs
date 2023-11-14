namespace Net7_WebAPI_Entity.Services.BookService;

public class BookService : IBookService
{
    private readonly DataContext _context;

    public BookService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetAllBooks()
    {
        var books = await _context.Books.ToListAsync();
        return books;
    }
}
