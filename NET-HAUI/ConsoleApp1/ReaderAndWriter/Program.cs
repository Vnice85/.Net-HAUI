using System;
using System.Data;
using System.IO;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {

        //string sourceFilePath = "old.txt";
        //string targetFilePath = "new.txt";
        //try
        //{
        //    File.Copy(sourceFilePath, targetFilePath, true);
        //    Console.WriteLine("copy thanh cong");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error: " + ex.Message);
        //}


        try
        {
            FileStream fs = new FileStream("Old.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            fs.Position = 0;
            string content = sr.ReadToEnd();
            fs.Close();
            fs = new FileStream("New.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs)
            {
                AutoFlush = true
            };
            sw.Write(content);
            fs.Close();
            Console.WriteLine("THANH CONG");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
