//#define TEST
using System;
using System.IO;
using System.Diagnostics;

namespace LoggingAndStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Hello out there";
            //File.WriteAllText("Hello.txt", text);
            //string readtext = File.ReadAllText("Hello.txt");
            //Console.WriteLine(readtext);
            //File.AppendAllText("Hello.txt", text);

            //string fileName = "lines.txt";

            //string[] lines =
            //{
            //    "Line 1",
            //    "Line 2",
            //    "Line 3"
            //};
            //File.WriteAllLines(fileName, lines);
            //string[] readLines = File.ReadAllLines(fileName);
            //foreach(var str in readLines)
            //{
            //    Console.WriteLine(str);
            //}

            //Debug.WriteLine("Debug - this is a debug item");
            //Trace.WriteLine("Trace - This is a trace item");

            //Console.WriteLine($"This is being logged at time {DateTime.Now}");
            //TextWriterTraceListener twt1 = new TextWriterTraceListener(File.Create("TraceOutput.txt"));
            //Trace.Listeners.Add(twt1);
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //    Debug.WriteLine($"Debug - the value of i i is {i}");
            //    Trace.WriteLine($"THe value of i is {i}");
            //    Debug.WriteLineIf(i == 2, $"\nReached  maximum value of i: {i} at {DateTime.Now}");
            //    Trace.Assert(i > 0, $"i is not grater than zero {i}");
            //}
            //Trace.Flush();
            //#if DEBUG
            //Console.WriteLine("This is Debug mode");
            //#endif


            //#if TEST
            //Console.WriteLine("This is a test");
            //#endif

            string path = @"LiveForever.txt";

            using(StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Live - Forever");
                sr.Close();
            }

            using(StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
                sr.Close();

            }

        }
    }
}
