interface IBookStore // interface
{
    List<Book> getBooks();
    void addBook(Book item);
    void removeBook(Book item);

}

class Book // class
{
    private string title = "";
    private string author = "";

    public string Title // property
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }

    public string Author // property
    {
        get
        {
            return author;
        }

        set
        {
            author = value;
        }
    }
}

class BookStore : IBookStore // class using the IBookStore interface
{
    List<Book> books = new List<Book>();

    public List<Book> getBooks() // method
    {
        return books;
    }

    public void addBook(Book item) //method
    {
        books.Add(item);
    }
    public void removeBook(Book item) // method
    {
        books.Remove(item);
    }

    public Book this[int i] // indexer
    {
        get { return books[i]; }
        set { books[i] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookStore myStore = new BookStore(); // instance of Bookstore class

        Book book1 = new Book(); // instance of Book class
        book1.Title = "Harry Potter";
        book1.Author = "Jk Rowling";

        Book book2 = new Book(); // instance of Book class
        book2.Title = "Marvel Comics";
        book2.Author = "Jacob Ress";

        myStore.addBook(book1);
        myStore.addBook(book2);

        List<Book> bookList = myStore.getBooks();

        foreach(var book in bookList)
        {
            Console.WriteLine(book.Title + " by " + book.Author);
        }

        Console.WriteLine(bookList[1].Title); // using index to get the book and then property Title to get the title of the book


    }
}

