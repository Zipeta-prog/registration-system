namespace Bookstore
{
    public class BookStore
    {
        private List<Book> books = new List<Book>();
        private string booksFilePath = "books.txt";
        private string ordersFilePath = "orders.txt";

        public void AddBook(Admin admin, string name, string description)
        {
            if (admin != null)
            {
                Book newBook = new Book(name, description);
                books.Add(newBook);

                // Save the updated book list to a file (books.txt)
                using (StreamWriter writer = File.AppendText(@"C:\Users\USER\Downloads\registration-system-master\books.txt))
                {
                    writer.WriteLine($"{newBook.ID},{newBook.BookName},{newBook.Description}");
                }
            }
            else
            {
                Console.WriteLine("Access Denied. Only admins can add books.");
            }
        }

        public void DisplayBooks()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\USER\Downloads\registration-system-master\books.txt);
            foreach (var line in lines)
            {
                string[] bookData = line.Split(',');
                Console.WriteLine($"ID: {bookData[0]} | Name: {bookData[1]} | Description: {bookData[2]}");
            }
        }

        public void BuyBook(User user, int bookID)
        {
            using (StreamWriter writer = File.AppendText(@"C:\Users\USER\Downloads\registration-system-master\orders.txt)
            {
                writer.WriteLine($"{user.ID},{bookID}");
            }
            Console.WriteLine($"Book ID {bookID} purchased by User ID: {user.ID}");
        }

        public class Program
    {
        public static void Main(string[] args)
        {
            Admin admin = new Admin("admin@admin.com", "admin123");
            User user = new User("user@example.com", "password");

            BookStore bookStore = new BookStore();

            bool isAdminLoggedIn = false;
            while (!isAdminLoggedIn)
            {
                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                if (email == admin.Email && password == admin.Password)
                {
                    isAdminLoggedIn = true;

                    // Admin logged in - add a book
                    bookStore.AddBook(admin, "Sample Book", "Sample Description");

                    // Display the book list
                    bookStore.DisplayBooks();

                    // Simulate book purchase by user
                    Console.WriteLine("Enter the ID of the book you want to buy: ");
                    int bookID = int.Parse(Console.ReadLine());
                    bookStore.BuyBook(user, bookID);
                }
                else
                {
                    Console.WriteLine("Invalid credentials. Try again.");
                }
            }
        }
    }
}