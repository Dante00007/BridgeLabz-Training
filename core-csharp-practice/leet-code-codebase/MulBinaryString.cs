
class MulBinaryString
{
    private static int MakeEqualLength(ref string str1, ref string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;
        if (len1 < len2)
        {
            str1 = str1.PadLeft(len2 - len1 + len1, '0');
            return len2;
        }
        else if (len1 > len2)
        {
            str2 = str2.PadLeft(len1 - len2 + len2, '0');
        }
        return len1;
    }
    private static string AddBitStrings(string first, string second)
    {
        string result = "";

        int length = MakeEqualLength(ref first, ref second);
        int carry = 0;


        for (int i = length - 1; i >= 0; i--)
        {
            int first_bit = int.Parse(first[i].ToString());
            int second_bit = int.Parse(second[i].ToString());

            int sum = (first_bit ^ second_bit ^ carry) + '0';

            result = (char)sum + result;

            carry = (first_bit & second_bit) | (second_bit & carry) | (first_bit & carry);
        }

        if (carry != 0)
        {
            result = '1' + result;
        }

        return result;
    }

    private static int MultiplySingleBit(string a, string b)
    {
        return int.Parse(a.ToString()) * int.Parse(b.ToString());
    }
    public static long Multiply(string a, string b)
    {
        int n = MakeEqualLength(ref a, ref b);

        if (n == 0) return 0;
        if (n == 1) return MultiplySingleBit(a, b);

        // lh->left half and rh->right half.
        int lh = n / 2; // represent floor value
        int rh = n - lh;// represent ceil value

        string al = a.Substring(0, lh);
        string ar = a.Substring(lh);

        string bl = b.Substring(0, lh);
        string br = b.Substring(lh);

        long P1 = Multiply(al, bl);
        long P2 = Multiply(ar, br);
        long P3 = Multiply(AddBitStrings(al, ar), AddBitStrings(bl, br));

        return P1 * (1L << (2 * rh)) + (P3 - P1 - P2) * (1L << rh) + P2;

    }
    static void Main()
    {
        string s1 = "1100";
        string s2 = "1010";

        Console.WriteLine(Multiply(s1, s2));//120
        s1 = "110";
        s2 = "1010";
        Console.WriteLine(Multiply(s1, s2));//60
    }
}