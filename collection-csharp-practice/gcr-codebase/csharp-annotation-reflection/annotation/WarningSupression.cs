using System;
using System.Collections;

class WarningSuppression
{
    static void Main(string[] args)
    {
        // #pragma warning disable CS0618
        ArrayList list = new ArrayList();
        // #pragma warning restore CS0618

        list.Add("Item 1");
        list.Add(2);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}