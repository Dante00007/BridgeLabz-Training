using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreams
{
    static void Main(string[] args)
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out))
        {
            Thread readerThread = new Thread(new ParameterizedThreadStart(ReadThread));
            readerThread.Start(pipeServer.GetClientHandleAsString());

            try
            {
                using (StreamWriter sw = new StreamWriter(pipeServer))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine("Message through pipe!");
                }
            }
            catch (IOException ex) { Console.WriteLine(ex.Message); }
            readerThread.Join();
        }
    }

    static void ReadThread(object pipeHandle)
    {
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, (string)pipeHandle))
        using (StreamReader sr = new StreamReader(pipeClient))
        {
            Console.WriteLine("Thread received: " + sr.ReadLine());
        }
    }
}