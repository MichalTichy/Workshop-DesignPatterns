package Iterator;
public class Main {
    public static void main(String[] args) {
        Book[] books = new Book[] {
                new Book("Book 1"),
                new Book("Book 2"),
                new Book("Book 3")
        };

        Library library = new Library(books);

        // for (Book book : library) {
        //     System.out.println(book.getTitle());
        // }
    }
}


