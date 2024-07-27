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
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99M, Description = "A classic novel set in the Jazz Age.", Type = "Fiction", Stock = 5 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 8.99M, Description = "A novel about racial injustice in the Deep South.", Type = "Fiction", Stock = 8 },
            new Book { Title = "1984", Author = "George Orwell", Price = 6.99M, Description = "A dystopian novel about totalitarianism.", Type = "Science Fiction", Stock = 12 },
            new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Price = 7.99M, Description = "A classic romance novel set in early 19th century England.", Type = "Romance", Stock = 7 },
            new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 9.99M, Description = "A novel about teenage angst and alienation.", Type = "Fiction", Stock = 10 },
            new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 8.99M, Description = "A fantasy novel about the adventures of Bilbo Baggins.", Type = "Fantasy", Stock = 15 },
            new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", Price = 7.49M, Description = "A novel about a dystopian future where books are banned.", Type = "Science Fiction", Stock = 9 },
            new Book { Title = "Jane Eyre", Author = "Charlotte Brontë", Price = 6.49M, Description = "A novel about an orphaned girl’s struggle for independence.", Type = "Romance", Stock = 11 },
            new Book { Title = "Moby-Dick", Author = "Herman Melville", Price = 10.49M, Description = "A novel about Captain Ahab's quest to find the white whale.", Type = "Adventure", Stock = 6 },
            new Book { Title = "Brave New World", Author = "Aldous Huxley", Price = 8.49M, Description = "A novel about a dystopian future shaped by technology and control.", Type = "Science Fiction", Stock = 14 },
            new Book { Title = "The Da Vinci Code", Author = "Dan Brown", Price = 9.49M, Description = "A thriller about a mystery involving a secret society.", Type = "Thriller", Stock = 13 },
            new Book { Title = "The Alchemist", Author = "Paulo Coelho", Price = 11.99M, Description = "A novel about a young shepherd’s quest to find his personal legend.", Type = "Fiction", Stock = 17 },
            new Book { Title = "The Little Prince", Author = "Antoine de Saint-Exupéry", Price = 5.99M, Description = "A novella about a young prince who travels from planet to planet.", Type = "Children", Stock = 20 },
            new Book { Title = "The Hunger Games", Author = "Suzanne Collins", Price = 7.99M, Description = "A dystopian novel about a future society where children fight to the death.", Type = "Dystopian", Stock = 18 },
            new Book { Title = "Gone with the Wind", Author = "Margaret Mitchell", Price = 12.99M, Description = "A historical novel set during the American Civil War.", Type = "Historical Fiction", Stock = 9 },
            new Book { Title = "The Road", Author = "Cormac McCarthy", Price = 8.99M, Description = "A post-apocalyptic novel about a father and son’s journey.", Type = "Post-Apocalyptic", Stock = 8 },
            new Book { Title = "The Outsiders", Author = "S.E. Hinton", Price = 6.49M, Description = "A novel about teenage gangs and social conflict.", Type = "Young Adult", Stock = 14 },
            new Book { Title = "The Shining", Author = "Stephen King", Price = 10.49M, Description = "A horror novel about a family staying in a haunted hotel.", Type = "Horror", Stock = 7 },
            new Book { Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Price = 15.99M, Description = "A fantasy epic about the quest to destroy a powerful ring.", Type = "Fantasy", Stock = 10 },
            new Book { Title = "Wuthering Heights", Author = "Emily Brontë", Price = 7.49M, Description = "A novel about the tumultuous love story of Heathcliff and Catherine.", Type = "Romance", Stock = 6 },
            new Book { Title = "Dracula", Author = "Bram Stoker", Price = 6.99M, Description = "A classic horror novel about Count Dracula and his vampire bride.", Type = "Horror", Stock = 5 },
            new Book { Title = "The Picture of Dorian Gray", Author = "Oscar Wilde", Price = 8.49M, Description = "A novel about a man who remains young while his portrait ages.", Type = "Gothic Fiction", Stock = 11 },
            new Book { Title = "Murder on the Orient Express", Author = "Agatha Christie", Price = 9.99M, Description = "A mystery novel featuring detective Hercule Poirot.", Type = "Mystery", Stock = 12 },
            new Book { Title = "The Girl with the Dragon Tattoo", Author = "Stieg Larsson", Price = 8.99M, Description = "A thriller about a journalist and a hacker investigating a disappearance.", Type = "Thriller", Stock = 14 },
            new Book { Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", Price = 10.99M, Description = "A novel about the Buendía family in the fictional town of Macondo.", Type = "Magical Realism", Stock = 13 },
            new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 7.49M, Description = "A novel about teenage angst and alienation.", Type = "Fiction", Stock = 10 },
            new Book { Title = "Life of Pi", Author = "Yann Martel", Price = 11.49M, Description = "A novel about a boy stranded on a lifeboat with a Bengal tiger.", Type = "Adventure", Stock = 9 },
            new Book { Title = "The Silence of the Lambs", Author = "Thomas Harris", Price = 8.99M, Description = "A thriller about a young FBI agent seeking help from a cannibalistic serial killer.", Type = "Thriller", Stock = 7 },
            new Book { Title = "The Chronicles of Narnia", Author = "C.S. Lewis", Price = 12.49M, Description = "A fantasy series about children discovering a magical land.", Type = "Fantasy", Stock = 11 },
            new Book { Title = "The Handmaid's Tale", Author = "Margaret Atwood", Price = 9.49M, Description = "A dystopian novel about a theocratic society.", Type = "Dystopian", Stock = 15 },
            new Book { Title = "The Bell Jar", Author = "Sylvia Plath", Price = 7.99M, Description = "A semi-autobiographical novel about mental illness.", Type = "Fiction", Stock = 8 },
            new Book { Title = "The Sun Also Rises", Author = "Ernest Hemingway", Price = 8.49M, Description = "A novel about the Lost Generation and post-World War I.", Type = "Fiction", Stock = 12 },
            new Book { Title = "The Secret Garden", Author = "Frances Hodgson Burnett", Price = 6.99M, Description = "A novel about a young girl who discovers a hidden garden.", Type = "Children", Stock = 18 },
            new Book { Title = "Anne of Green Gables", Author = "L.M. Montgomery", Price = 5.99M, Description = "A novel about an imaginative orphan girl.", Type = "Children", Stock = 20 },
            new Book { Title = "Little Women", Author = "Louisa May Alcott", Price = 7.49M, Description = "A novel about the lives of the four March sisters.", Type = "Historical Fiction", Stock = 14 },
            new Book { Title = "A Tale of Two Cities", Author = "Charles Dickens", Price = 9.49M, Description = "A novel set during the French Revolution.", Type = "Historical Fiction", Stock = 11 },
            new Book { Title = "The Old Man and the Sea", Author = "Ernest Hemingway", Price = 8.99M, Description = "A novella about an old fisherman’s struggle with a giant marlin.", Type = "Adventure", Stock = 9 },
            new Book { Title = "The Giver", Author = "Lois Lowry", Price = 7.99M, Description = "A dystopian novel about a society without emotions.", Type = "Dystopian", Stock = 13 },
            new Book { Title = "The Wonderful Wizard of Oz", Author = "L. Frank Baum", Price = 5.99M, Description = "A fantasy novel about a young girl's adventures in a magical land.", Type = "Fantasy", Stock = 16 },
            new Book { Title = "Watership Down", Author = "Richard Adams", Price = 8.99M, Description = "A novel about a group of rabbits seeking a new home.", Type = "Adventure", Stock = 10 },
            new Book { Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", Price = 7.49M, Description = "A science fiction novel about an intergalactic hitchhiker's adventures.", Type = "Science Fiction", Stock = 15 },
            new Book { Title = "The Color Purple", Author = "Alice Walker", Price = 8.49M, Description = "A novel about African American women’s experiences in the early 20th century.", Type = "Historical Fiction", Stock = 12 },
            new Book { Title = "The Kite Runner", Author = "Khaled Hosseini", Price = 9.99M, Description = "A novel about friendship and redemption in Afghanistan.", Type = "Fiction", Stock = 14 },
            new Book { Title = "The Lovely Bones", Author = "Alice Sebold", Price = 7.49M, Description = "A novel about a young girl's afterlife and her family's coping.", Type = "Fiction", Stock = 10 },
            new Book { Title = "The Girl on the Train", Author = "Paula Hawkins", Price = 8.99M, Description = "A thriller about a woman who becomes involved in a missing person’s case.", Type = "Thriller", Stock = 12 },
            new Book { Title = "Big Little Lies", Author = "Liane Moriarty", Price = 9.49M, Description = "A novel about the secrets and lies of a group of women.", Type = "Fiction", Stock = 11 },
            new Book { Title = "The Martian", Author = "Andy Weir", Price = 8.49M, Description = "A science fiction novel about an astronaut stranded on Mars.", Type = "Science Fiction", Stock = 13 },
            new Book { Title = "Dune", Author = "Frank Herbert", Price = 10.49M, Description = "A science fiction epic set on the desert planet of Arrakis.", Type = "Science Fiction", Stock = 7 },
            new Book { Title = "Ender's Game", Author = "Orson Scott Card", Price = 7.99M, Description = "A science fiction novel about a young boy training for an interstellar war.", Type = "Science Fiction", Stock = 15 },
            new Book { Title = "The Time Machine", Author = "H.G. Wells", Price = 6.49M, Description = "A science fiction novel about time travel.", Type = "Science Fiction", Stock = 12 },
            new Book { Title = "The Name of the Wind", Author = "Patrick Rothfuss", Price = 9.99M, Description = "A fantasy novel about a young man’s journey to become a hero.", Type = "Fantasy", Stock = 8 },
            new Book { Title = "Good Omens", Author = "Neil Gaiman and Terry Pratchett", Price = 10.49M, Description = "A humorous fantasy novel about the apocalypse.", Type = "Fantasy", Stock = 6 },
            new Book { Title = "The Shadow of the Wind", Author = "Carlos Ruiz Zafón", Price = 8.99M, Description = "A novel about a young boy’s quest to uncover the mystery of a forgotten book.", Type = "Mystery", Stock = 10 }
        };

        foreach (var book in books)
        {
            context.Books.Add(book);
        }

        context.SaveChanges();
    }
}
