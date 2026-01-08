using System;

class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, string seat, DateTime time)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = time;
        Next = this;
    }

    public override string ToString()
    {
        return $"[ID: {TicketId}] Customer: {CustomerName} | Movie: {MovieName} | Seat: {SeatNumber} | Time: {BookingTime}";
    }
}

class TicketReservationSystem
{
    private TicketNode? Head { get; set; }

    public void AddTicket()
    {
        Console.Write("Enter Ticket Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Customer Name: ");
        string customer = Console.ReadLine() ?? "";
        Console.Write("Enter Movie Name: ");
        string movie = Console.ReadLine() ?? "";
        Console.Write("Enter Seat Number: ");
        string seat = Console.ReadLine() ?? "";
        DateTime time = DateTime.Now;

        TicketNode newTicket = new TicketNode(id, customer, movie, seat, time);

        if (Head == null)
        {
            Head = newTicket;
        }
        else
        {
            TicketNode temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newTicket;
            newTicket.Next = Head;
        }
        Console.WriteLine("Ticket reserved successfully.");
    }

    public void RemoveTicketById()
    {
        if (Head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Console.Write("Enter Ticket Id to cancel: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (Head.TicketId == id)
        {
            if (Head.Next == Head)
            {
                Head = null;
            }
            else
            {
                TicketNode temp = Head;
                while (temp.Next != Head)
                    temp = temp.Next;

                temp.Next = Head.Next;
                Head = Head.Next;
            }
            Console.WriteLine("Ticket cancelled successfully.");
        }
        else
        {
            TicketNode prev = Head;
            TicketNode curr = Head.Next;
            bool found = false;

            while (curr != Head)
            {
                if (curr.TicketId == id)
                {
                    prev.Next = curr.Next;
                    found = true;
                    break;
                }
                prev = curr;
                curr = curr.Next;
            }

            if (found) Console.WriteLine("Ticket cancelled successfully.");
            else Console.WriteLine("Ticket ID not found.");
        }
    }

    public void DisplayTickets()
    {
        if (Head == null)
        {
            Console.WriteLine("No current reservations.");
            return;
        }

        TicketNode temp = Head;
        Console.WriteLine("\n--- Current Ticket Reservations ---");
        do
        {
            Console.WriteLine(temp);
            temp = temp.Next;
        } while (temp != Head);
    }

    public void SearchTicket()
    {
        if (Head == null)
        {
            Console.WriteLine("No tickets to search.");
            return;
        }

        Console.Write("Enter Customer Name or Movie Name to search: ");
        string query = Console.ReadLine() ?? "";
        TicketNode temp = Head;
        bool found = false;

        do
        {
            if (temp.CustomerName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != Head);

        if (!found) Console.WriteLine("No matching tickets found.");
    }

    public void CalculateTotalTickets()
    {
        if (Head == null)
        {
            Console.WriteLine("Total booked tickets: 0");
            return;
        }

        int count = 0;
        TicketNode temp = Head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != Head);

        Console.WriteLine($"Total booked tickets: {count}");
    }
}

class OnlineTicketSystem
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();
        while (true)
        {
            Console.WriteLine("\n--- Movie Ticket System ---");
            Console.WriteLine("1. Reserve Ticket");
            Console.WriteLine("2. Cancel Ticket (ID)");
            Console.WriteLine("3. Display All Tickets");
            Console.WriteLine("4. Search Tickets");
            Console.WriteLine("5. Get Total Bookings");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    system.AddTicket();
                    break;
                case 2:
                    system.RemoveTicketById();
                    break;
                case 3:
                    system.DisplayTickets();
                    break;
                case 4:
                    system.SearchTicket();
                    break;
                case 5:
                    system.CalculateTotalTickets();
                    break;
                case 6:
                    return;
                default: Console.WriteLine("Invalid choice."); 
                break;
            }
        }
    }
}