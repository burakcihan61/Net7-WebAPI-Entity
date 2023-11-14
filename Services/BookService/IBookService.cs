namespace Net7_WebAPI_Entity.Services.BookService;

public interface IBookService
{
    Task<List<Book>> GetAllBooks();
}
