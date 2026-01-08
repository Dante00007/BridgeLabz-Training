using System;
using System.Collections.Generic;

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;
    public List<int> FriendIds;
    public UserNode? Next;

    public UserNode(int id, string name, int age)
    {
        this.UserId = id;
        this.Name = name;
        this.Age = age;
        this.FriendIds = new List<int>();
        this.Next = null;
    }
}

class SocialMediaGraph
{
    private UserNode? Head;

    public SocialMediaGraph()
    {
        Head = null;
    }

    public void AddUser(UserNode node)
    {
        if (Head == null)
            Head = node;
        else
        {
            UserNode temp = Head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = node;
        }
    }

    private UserNode? FindUserById(int id)
    {
        UserNode? temp = Head;
        while (temp != null)
        {
            if (temp.UserId == id) return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void AddFriendConnection()
    {
        Console.Write("\nEnter User ID 1: ");
        int id1 = int.Parse(Console.ReadLine());
        Console.Write("Enter User ID 2: ");
        int id2 = int.Parse(Console.ReadLine());

        UserNode? u1 = FindUserById(id1);
        UserNode? u2 = FindUserById(id2);

        if (u1 != null && u2 != null)
        {
            if (!u1.FriendIds.Contains(id2)) u1.FriendIds.Add(id2);
            if (!u2.FriendIds.Contains(id1)) u2.FriendIds.Add(id1);
            Console.WriteLine("Friendship connected successfully.");
        }
        else Console.WriteLine("One or both users not found.");
    }

    public void RemoveFriendConnection()
    {
        Console.Write("\nEnter User ID 1: ");
        int id1 = int.Parse(Console.ReadLine());
        Console.Write("Enter User ID 2: ");
        int id2 = int.Parse(Console.ReadLine());

        UserNode? u1 = FindUserById(id1);
        UserNode? u2 = FindUserById(id2);

        if (u1 != null && u2 != null)
        {
            u1.FriendIds.Remove(id2);
            u2.FriendIds.Remove(id1);
            Console.WriteLine("Friendship removed.");
        }
        else Console.WriteLine("Users not found.");
    }

    public void DisplayFriendsOfUser()
    {
        Console.Write("\nEnter User ID to view friends: ");
        int id = int.Parse(Console.ReadLine());
        UserNode? user = FindUserById(id);

        if (user != null)
        {
            Console.WriteLine("Friends of {0}:", user.Name);
            foreach (int fId in user.FriendIds)
            {
                UserNode? friend = FindUserById(fId);
                if (friend != null) Console.WriteLine("- {0} (ID: {1})", friend.Name, friend.UserId);
            }
        }
        else Console.WriteLine("User not found.");
    }

    public void FindMutualFriends()
    {
        Console.Write("\nEnter User ID 1: ");
        int id1 = int.Parse(Console.ReadLine());
        Console.Write("Enter User ID 2: ");
        int id2 = int.Parse(Console.ReadLine());

        UserNode? u1 = FindUserById(id1);
        UserNode? u2 = FindUserById(id2);

        if (u1 != null && u2 != null)
        {
            Console.WriteLine("Mutual Friends between {0} and {1}:", u1.Name, u2.Name);
            bool found = false;
            foreach (int fId in u1.FriendIds)
            {
                if (u2.FriendIds.Contains(fId))
                {
                    UserNode? mutual = FindUserById(fId);
                    if (mutual != null)
                    {
                        Console.WriteLine("- {0}", mutual.Name);
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine("No mutual friends.");
        }
    }

    public void SearchUser()
    {
        Console.Write("\nEnter Name or ID to search: ");
        string input = Console.ReadLine();
        UserNode? temp = Head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Name.Equals(input, StringComparison.OrdinalIgnoreCase) || temp.UserId.ToString() == input)
            {
                Console.WriteLine("Found: {0}, ID: {1}, Age: {2}, Friends: {3}", temp.Name, temp.UserId, temp.Age, temp.FriendIds.Count);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found) Console.WriteLine("User not found.");
    }

    public void CountFriends()
    {
        Console.WriteLine("\nFriend Counts:");
        UserNode? temp = Head;
        while (temp != null)
        {
            Console.WriteLine("{0} (ID: {1}): {2} friends", temp.Name, temp.UserId, temp.FriendIds.Count);
            temp = temp.Next;
        }
    }
}

class SocialMediaManagement
{
    static void Main()
    {
        SocialMediaGraph socialGraph = new SocialMediaGraph();
        socialGraph.AddUser(new UserNode(1, "Alice", 25));
        socialGraph.AddUser(new UserNode(2, "Bob", 28));
        socialGraph.AddUser(new UserNode(3, "Charlie", 22));

        socialGraph.AddFriendConnection(); 
        socialGraph.CountFriends();
        socialGraph.DisplayFriendsOfUser();
        socialGraph.FindMutualFriends();
        socialGraph.SearchUser();
        socialGraph.RemoveFriendConnection();
        socialGraph.CountFriends();
    }
}