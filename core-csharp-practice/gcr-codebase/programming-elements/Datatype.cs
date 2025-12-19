class Datatype
{
    static void Main(string[] args)
    {
        // Range: 0 to 255. size: 1 byte or 8-bit
        byte b = 255;
        // Range: -32,768 to 32,767. size: 2 bytes or 16-bit
        short s = 32767;
        // Range: -2,147,483,648 to 2,147,483,647. size: 4 bytes or 32-bit
        int i = 2147483647;
        // Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807. size: 8 bytes or 64-bit
        long l = 9223372036854775807L;
        // Range: -3.4E38 to 3.4E38. size: 4 bytes or 32-bit        
        float f = 3.14F;
        // Range: -1.7E308 to 1.7E308. size: 8 bytes or 64-bit
        double d = 3.141592653589793D;
        // Range: 0 to 65,535. size: 2 bytes or 16-bit
        char ch = 'A';
        // Range: true or false. size: 1 bit
        bool bln = true;

        Console.WriteLine("byte: " + b);
        Console.WriteLine("short: " + s);
        Console.WriteLine("int: " + i);
        Console.WriteLine("long: " + l);
        Console.WriteLine("float: " + f);
        Console.WriteLine("double: " + d);
        Console.WriteLine("char: " + ch);
        Console.WriteLine("bool: " + bln);


        // Type Cast
        // byte to int
        byte b1 = 100;
        int i1 = b1;
        Console.WriteLine("byte to int: " + i1);

        // int to byte
        int i2 = 100;
        byte b2 = (byte)i2;
        Console.WriteLine("int to byte: " + b2);

        //int to float
        int i3 = 100;
        float f1 = i3;
        Console.WriteLine("int to float: " + f1.ToString());

        //float to int
        float f2 = 100.5f;
        int i4 = (int)f2;
        Console.WriteLine("float to int: " + i4);

        // float to double
        float f3 = 100.5f;
        double d1 = f3;
        Console.WriteLine("float to double: " + d1.ToString());

        // double to float
        double d2 = 100.5;
        float f4 = (float)d2;
        Console.WriteLine("double to float: " + f4.ToString());

    }
}