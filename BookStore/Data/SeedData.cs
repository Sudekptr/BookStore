using BookStore.Data;
using BookStore.Models;

public static class SeedData
{
    public static void Initialize(ApplicationDbContext context)
    {
        if (context.Books.Any())
        {
            return;   // DB'de zaten veriler varsa, hiç bir şey yapma
        }

        var books = new Book[]
        {
            new Book { Title = "The Great Adventure", Author = "John Smith", Price = 15.99M, Description = "An epic journey through uncharted lands.", Type = "Fiction", Stock = 20, SellerId = 1 },
            new Book { Title = "Mystery of the Lost City", Author = "Alice Johnson", Price = 12.49M, Description = "A thrilling mystery that will keep you on edge.", Type = "Mystery", Stock = 30, SellerId = 2 },
            new Book { Title = "Science of the Stars", Author = "Emily Davis", Price = 22.00M, Description = "An in-depth look at the universe and its wonders.", Type = "Science", Stock = 15, SellerId = 3 },
            new Book { Title = "Cooking with Passion", Author = "Michael Brown", Price = 18.75M, Description = "Delicious recipes from around the world.", Type = "Non-Fiction", Stock = 25, SellerId = 4 },
            new Book { Title = "History Revisited", Author = "Sarah Wilson", Price = 17.99M, Description = "A comprehensive guide to world history.", Type = "History", Stock = 12, SellerId = 5 },
            new Book { Title = "The Last Enigma", Author = "David Martinez", Price = 14.99M, Description = "A gripping novel full of twists and turns.", Type = "Fiction", Stock = 18, SellerId = 1 },
            new Book { Title = "Ocean Wonders", Author = "Laura Lewis", Price = 19.50M, Description = "Explore the mysteries of the ocean depths.", Type = "Science", Stock = 22, SellerId = 2 },
            new Book { Title = "Tech Innovations", Author = "Robert Clark", Price = 21.75M, Description = "The latest advancements in technology.", Type = "Non-Fiction", Stock = 20, SellerId = 3 },
            new Book { Title = "Garden Bliss", Author = "Sophia White", Price = 16.30M, Description = "Tips and tricks for a thriving garden.", Type = "Non-Fiction", Stock = 25, SellerId = 4 },
            new Book { Title = "Adventure Awaits", Author = "James Hall", Price = 13.90M, Description = "A journey filled with unexpected adventures.", Type = "Fiction", Stock = 17, SellerId = 5 },
            new Book { Title = "Art of the Renaissance", Author = "Olivia Allen", Price = 23.00M, Description = "A detailed study of Renaissance art and artists.", Type = "Non-Fiction", Stock = 10, SellerId = 1 },
            new Book { Title = "Travel Diaries", Author = "Daniel Young", Price = 14.50M, Description = "Personal stories from around the globe.", Type = "Non-Fiction", Stock = 30, SellerId = 2 },
            new Book { Title = "Cooking with Herbs", Author = "Isabella King", Price = 17.25M, Description = "Herbal recipes for every occasion.", Type = "Non-Fiction", Stock = 28, SellerId = 3 },
            new Book { Title = "The Solar System", Author = "Karen Scott", Price = 20.00M, Description = "A journey through our solar system.", Type = "Science", Stock = 16, SellerId = 4 },
            new Book { Title = "Fictional Realities", Author = "Andrew Collins", Price = 13.99M, Description = "Short stories that blur the lines between fiction and reality.", Type = "Fiction", Stock = 19, SellerId = 5 },
            new Book { Title = "Secrets of the Mind", Author = "Patricia Lee", Price = 18.00M, Description = "Understanding human psychology.", Type = "Science", Stock = 14, SellerId = 1 },
            new Book { Title = "The Great Outdoors", Author = "Thomas Walker", Price = 15.75M, Description = "A guide to outdoor adventures.", Type = "Non-Fiction", Stock = 22, SellerId = 2 },
            new Book { Title = "The Hidden Path", Author = "Linda Baker", Price = 16.50M, Description = "A suspenseful novel of discovery.", Type = "Fiction", Stock = 15, SellerId = 3 },
            new Book { Title = "The World of Plants", Author = "Jennifer Hughes", Price = 19.99M, Description = "An encyclopedia of plant life.", Type = "Science", Stock = 21, SellerId = 4 },
            new Book { Title = "The Ultimate Cookbook", Author = "Jessica Moore", Price = 24.50M, Description = "Recipes from around the world.", Type = "Non-Fiction", Stock = 25, SellerId = 5 },
            new Book { Title = "Journey Through Time", Author = "Mark Cooper", Price = 22.75M, Description = "A historical exploration of ancient civilizations.", Type = "History", Stock = 18, SellerId = 1 },
            new Book { Title = "The Enchanted Forest", Author = "Amy Turner", Price = 14.00M, Description = "A fantasy novel full of magic and adventure.", Type = "Fiction", Stock = 20, SellerId = 2 },
            new Book { Title = "Space Exploration", Author = "Steven Allen", Price = 23.50M, Description = "The history and future of space travel.", Type = "Science", Stock = 17, SellerId = 3 },
            new Book { Title = "The Art of Cooking", Author = "Emily Parker", Price = 20.75M, Description = "Culinary techniques from around the world.", Type = "Non-Fiction", Stock = 24, SellerId = 4 },
            new Book { Title = "Ancient Mysteries", Author = "Rebecca Howard", Price = 18.99M, Description = "Unsolved mysteries from ancient times.", Type = "History", Stock = 15, SellerId = 5 },
            new Book { Title = "The Final Frontier", Author = "Christopher Reed", Price = 21.00M, Description = "Exploring the outer reaches of space.", Type = "Science", Stock = 19, SellerId = 1 },
            new Book { Title = "The Culinary Journey", Author = "Samantha Gray", Price = 22.25M, Description = "Recipes and stories from a world traveler.", Type = "Non-Fiction", Stock = 26, SellerId = 2 },
            new Book { Title = "Mysteries of the Mind", Author = "Angela Price", Price = 19.75M, Description = "Exploring the human brain.", Type = "Science", Stock = 13, SellerId = 3 },
            new Book { Title = "Historical Chronicles", Author = "Henry Mitchell", Price = 23.00M, Description = "Detailed accounts of historical events.", Type = "History", Stock = 12, SellerId = 4 },
            new Book { Title = "The Fantasy Realm", Author = "Deborah Wilson", Price = 16.99M, Description = "A novel set in a magical world.", Type = "Fiction", Stock = 18, SellerId = 5 },
            new Book { Title = "The Innovation Game", Author = "Benjamin Clark", Price = 25.00M, Description = "A look at technological advancements.", Type = "Non-Fiction", Stock = 20, SellerId = 1 },
            new Book { Title = "The Secret Garden", Author = "Frances Hodgson Burnett", Price = 6.99M, Description = "A novel about a young girl who discovers a hidden garden.", Type = "Children", Stock = 18, SellerId = 2 },
            new Book { Title = "Anne of Green Gables", Author = "L.M. Montgomery", Price = 5.99M, Description = "A novel about an imaginative orphan girl.", Type = "Children", Stock = 20, SellerId = 3 },
            new Book { Title = "Little Women", Author = "Louisa May Alcott", Price = 7.49M, Description = "A novel about the lives of the four March sisters.", Type = "Historical Fiction", Stock = 14, SellerId = 4 },
            new Book { Title = "A Tale of Two Cities", Author = "Charles Dickens", Price = 9.49M, Description = "A novel set during the French Revolution.", Type = "Historical Fiction", Stock = 11, SellerId = 5 },
            new Book { Title = "The Old Man and the Sea", Author = "Ernest Hemingway", Price = 8.99M, Description = "A novella about an old fisherman’s struggle with a giant marlin.", Type = "Adventure", Stock = 9, SellerId = 1 },
            new Book { Title = "The Giver", Author = "Lois Lowry", Price = 7.99M, Description = "A dystopian novel about a society without emotions.", Type = "Dystopian", Stock = 13, SellerId = 2 },
            new Book { Title = "The Wonderful Wizard of Oz", Author = "L. Frank Baum", Price = 6.49M, Description = "A classic tale of a young girl’s journey in a magical land.", Type = "Children", Stock = 16, SellerId = 3 },
            new Book { Title = "Charlotte's Web", Author = "E.B. White", Price = 6.99M, Description = "A novel about a pig and his spider friend.", Type = "Children", Stock = 19, SellerId = 4 },
            new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 11.49M, Description = "A fantasy adventure of Bilbo Baggins.", Type = "Fantasy", Stock = 14, SellerId = 5 },
            new Book { Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien", Price = 12.99M, Description = "The first part of the Lord of the Rings trilogy.", Type = "Fantasy", Stock = 12, SellerId = 1 },
            new Book { Title = "The Two Towers", Author = "J.R.R. Tolkien", Price = 12.99M, Description = "The second part of the Lord of the Rings trilogy.", Type = "Fantasy", Stock = 10, SellerId = 2 },
            new Book { Title = "The Return of the King", Author = "J.R.R. Tolkien", Price = 13.49M, Description = "The final part of the Lord of the Rings trilogy.", Type = "Fantasy", Stock = 11, SellerId = 3 },
            new Book { Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Price = 9.99M, Description = "The first book in the Harry Potter series.", Type = "Fantasy", Stock = 20, SellerId = 4 },
            new Book { Title = "Harry Potter and the Chamber of Secrets", Author = "J.K. Rowling", Price = 10.49M, Description = "The second book in the Harry Potter series.", Type = "Fantasy", Stock = 18, SellerId = 5 },
            new Book { Title = "Harry Potter and the Prisoner of Azkaban", Author = "J.K. Rowling", Price = 10.99M, Description = "The third book in the Harry Potter series.", Type = "Fantasy", Stock = 20, SellerId = 1 },
            new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 7.99M, Description = "A novel about a teenage boy's experiences in New York City.", Type = "Drama", Stock = 20, SellerId = 2 },
            new Book { Title = "The Odyssey", Author = "Homer", Price = 10.99M, Description = "An epic poem about Odysseus's journey home.", Type = "Epic", Stock = 8, SellerId = 3 },
            new Book { Title = "Brave New World", Author = "Aldous Huxley", Price = 8.49M, Description = "A dystopian novel about a future society controlled by technology.", Type = "Dystopian", Stock = 11, SellerId = 4 },
            new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", Price = 7.99M, Description = "A dystopian novel about a society where books are banned.", Type = "Dystopian", Stock = 14, SellerId = 5 },
            new Book { Title = "Moby Dick", Author = "Herman Melville", Price = 9.49M, Description = "A novel about a sea captain's obsession with a giant whale.", Type = "Adventure", Stock = 7, SellerId = 1 },
            new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Price = 6.99M, Description = "A novel about the manners and matrimony in early 19th century England.", Type = "Romance", Stock = 13, SellerId = 2 },
            new Book { Title = "The Book Thief", Author = "Markus Zusak", Price = 8.99M, Description = "A novel about a young girl’s love of books in Nazi Germany.", Type = "Historical Fiction", Stock = 12, SellerId = 3 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 7.99M, Description = "A novel about racial injustice in the American South.", Type = "Drama", Stock = 15, SellerId = 4 }
        };

        foreach (var book in books)
        {
            context.Books.Add(book);
        }

        context.SaveChanges();
    }
}
