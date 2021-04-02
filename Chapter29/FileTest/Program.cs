using System;
using System.IO;
namespace Chapter29 {
    class Program {
        static void Main(string[] args) {
            string input_filename = "../../../Input.txt";
            string output_filename = "../../../Output.txt";

            string[] line_list = File.ReadAllLines(input_filename);
            
            FileStream fs = File.OpenWrite(output_filename);
            // Manually Truncate the file because File.OpenWrite Doesn't truncate the file first.
            fs.SetLength(0);
            StreamWriter streamWriter = new StreamWriter(fs);
            
            // Write last two lines to Example.txt:
            if (line_list.LongLength >= 2) {
                Console.WriteLine($"Writing last two lines of \"{input_filename}\" to \"{output_filename}\"");
                var end = line_list.LongLength - 1;
                streamWriter.WriteLine(line_list[end]);
                streamWriter.WriteLine(line_list[end - 1]);
            }
            else
                streamWriter.WriteLine($"Sorry, \"{input_filename}\" is empty.");
            

            streamWriter.Close();
            fs.Close();
            Console.WriteLine("Complete!");
        }
    }
}