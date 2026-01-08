

class MovieNode
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }
    public MovieNode? Next { get; set; }
    public MovieNode? Prev { get; set; }
}

class DoublyLinkedList
{
    private MovieNode? Head { get; set; }
    private MovieNode? Tail { get; set; }

    public void AddMovieAtBeginning()
    {
        Console.WriteLine("Enter Movie Details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Rating: ");
        double rating = Convert.ToDouble(Console.ReadLine());
        MovieNode newNode = new MovieNode { Title = title, Director = director, Year = year, Rating = rating };
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Prev = newNode;
        }
    }
    public void AddMovie()
    {
        Console.WriteLine("Enter Movie Details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Rating: ");
        double rating = Convert.ToDouble(Console.ReadLine());
        MovieNode newNode = new MovieNode { Title = title, Director = director, Year = year, Rating = rating };
        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Prev = Tail;
            Tail.Next = newNode;
        }
    }
    public void AddMovieAtPosition()
    {
        Console.WriteLine("Enter Movie Details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Rating: ");
        double rating = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Position");
        int position = int.Parse(Console.ReadLine());
        if (position == 1)
        {
            MovieNode newNode = new MovieNode { Title = title, Director = director, Year = year, Rating = rating };
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
        }
        else
        {
            MovieNode newNode = new MovieNode { Title = title, Director = director, Year = year, Rating = rating };
            MovieNode? temp = Head;
            while (temp != null && --position > 0)
            {
                temp = temp.Next;
            }
            if (temp == null) return;
            newNode.Prev = temp.Prev;
            newNode.Next = temp;
            temp.Prev.Next = newNode;
            temp.Prev = newNode;
        }
    }

    public void RemoveMovieByTitle()
    {
        Console.Write("Enter Movie Title to remove: ");
        string title = Console.ReadLine();
        MovieNode? current = Head;
        MovieNode? prev = null;
        while (current != null)
        {
            if (current.Title == title)
            {
                prev.Next = current.Next;
                if (current.Next != null)
                {
                    current.Next.Prev = prev;
                    current.Next = null;
                    current.Prev = null;
                }
                else
                {
                    Tail = prev;
                }
                current=null;
                Console.WriteLine($"Movie '{title}' removed successfully.");
                break;
            }
            prev = current;
            current = current.Next;
        }

    }
    public void SearchMovieByDirectorOrRating()
    {
        Console.Write("Enter Director Name or Rating to search: ");
        string searchTerm = Console.ReadLine();
        MovieNode? current = Head;
        while (current != null)
        {
            if (current.Director == searchTerm || current.Rating.ToString() == searchTerm.Trim())
            {
                Console.WriteLine($"Movie Title: {current.Title}");
                Console.WriteLine($"Director: {current.Director}");
                Console.WriteLine($"Year: {current.Year}");
                Console.WriteLine($"Rating: {current.Rating}");
                Console.WriteLine();
            }
            current = current.Next;
        }
    }
    public void DisplayMoviesForward()
    {
        MovieNode? current = Head;
        while (current != null)
        {
            Console.WriteLine($"Movie Title: {current.Title}");
            Console.WriteLine($"Director: {current.Director}");
            Console.WriteLine($"Year: {current.Year}");
            Console.WriteLine($"Rating: {current.Rating}");
            Console.WriteLine();
            current = current.Next;
        }
    }
    public void DisplayMoviesReverse()
    {
        MovieNode? current = Tail;
        while (current != null)
        {
            Console.WriteLine($"Movie Title: {current.Title}");
            Console.WriteLine($"Director: {current.Director}");
            Console.WriteLine($"Year: {current.Year}");
            Console.WriteLine($"Rating: {current.Rating}");
            Console.WriteLine();
            current = current.Prev;
        }
    }
    public void UpdateMovieRating()
    {
        Console.Write("Enter Movie Title to update rating: ");
        string title = Console.ReadLine();
        Console.Write("Enter New Rating: ");
        double newRating = Convert.ToDouble(Console.ReadLine());
        MovieNode? current = Head;
        while (current != null)
        {
            if (current.Title == title)
            {
                current.Rating = newRating;
                Console.WriteLine($"Movie '{title}' rating updated successfully.");
                break;
            }
            current = current.Next;
        }
    }
}

class MovieManagementSystem
{
    static void Main()
    {
        DoublyLinkedList moviesList = new DoublyLinkedList();
        while (true)
        {
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Add Movie at Position");
            Console.WriteLine("3. Remove Movie by Title");
            Console.WriteLine("4. Search Movie by Director or Rating");
            Console.WriteLine("5. Display Movies Forward");
            Console.WriteLine("6. Display Movies Reverse");
            Console.WriteLine("7. Update Movie Rating");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    moviesList.AddMovie();
                    break;
                case 2:
                    moviesList.AddMovieAtPosition();
                    break;
                case 3:
                    moviesList.RemoveMovieByTitle();
                    break;
                case 4:
                    moviesList.SearchMovieByDirectorOrRating();
                    break;
                case 5:
                    moviesList.DisplayMoviesForward();
                    break;
                case 6:
                    moviesList.DisplayMoviesReverse();
                    break;
                case 7:
                    moviesList.UpdateMovieRating();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}