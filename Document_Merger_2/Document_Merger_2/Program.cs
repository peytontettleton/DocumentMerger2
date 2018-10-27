using System;

namespace Document_Merger_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
            }
            args[0] = Text1;
            args[1] = Text2;
            args[2] = Output3;

            String Output3 = Text1.Substring(0, first.Length - 4) + Text2.Substring(0, second.Length - 4);
            String Output3 + ".txt";

            StreamWriter sw = null;
            StreamReader sr1 = null;
            StreamReader sr2 = null;

            bool success = false;

            int count = 0;

            try
            {
                sw = new StreamWriter(Output3);
                sr1 = new StreamReader(Text1);
                sr2 = new StreamReader(Text2);

                String line = sr1.ReadLine();
                while (line != null)
                {
                    sw.WriteLine(line);
                    count += line.Length;
                    line = sr1.ReadLine();
                }
                line = sr2.ReadLine();
                while (line != null)
                {
                    sw.WriteLine(line);
                    count += line.Length;
                    line = sr2.ReadLine();
                }
                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
                if (sr1 != null)
                    sr1.Close();
                if (sr2 != null)
                    sr2.Close();


            }

        }
}
       


