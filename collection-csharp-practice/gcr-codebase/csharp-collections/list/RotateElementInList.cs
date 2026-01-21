
class RotateElementList
{
    static void RotateElement(List<int> list, int k)
    {
        k = k % list.Count;

        list.Reverse(0, list.Count);
        list.Reverse(0, k);
        list.Reverse(k, list.Count - k);

    }
    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int k = 3;
        RotateElement(list, k);
    }
}