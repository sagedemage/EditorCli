using System.Text;

class Program
{
    static void Main(string[] args)
    {
        switch(args.Length) {
            case 3: 
                if (args[0] == "write")
                {
                    try {
                        StreamWriter sw = new StreamWriter(args[2], true, Encoding.ASCII);

                        sw.WriteLine(args[1]);
                        sw.Close();
                    }
                    catch (Exception e) {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally {
                        Console.WriteLine("Wrote text to the file.");
                    }
                }
                else {
                    Console.WriteLine("Flag does not exist");
                }
                break;
            case 2:
                if (args[0] == "read")
                {
                    try {
                        StreamReader sr = new StreamReader(args[1]);
                        string line = sr.ReadLine()!;
                        while (line != null) {
                            Console.WriteLine(line);
                            line = sr.ReadLine()!;
                        }
                        sr.Close();
                    }
                    catch(Exception e) {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                }
                else {
                    Console.WriteLine("Flag does not exist");
                }
                break;
            case 1:
                Console.WriteLine("Missing second argument for file name");
                break;
            case 0:
                Console.WriteLine("Options:");
                Console.WriteLine("    read <filename>      read a file");
                Console.WriteLine("    write <text> <filename>     write text to a file");
                break;
            default:
                Console.WriteLine("There are too many arguments provided");
                break;
        }
    }
}




