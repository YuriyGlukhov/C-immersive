using System;
using System.CodeDom.Compiler;

namespace C_Uber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fist_number;
            int forresult;
            int[] calculating_array = new int[args.Length];
            if (args.Length > 1)
            {
                    for (int i = 0; i < calculating_array.Length; i++)
                    {

                    

                        if (int.TryParse(args[i], out fist_number))
                        {
                            fist_number = int.Parse(args[i]);
                            
                            if (i == 0)
                            calculating_array[i] = fist_number;


                        }

                        else
                        {
                            if (args[i] == "+")
                            {
                                forresult = int.Parse(args[i + 1]);
                                int totalresult = calculating_array[i - 1] + forresult;
                                calculating_array[i + 1] = totalresult;

                            }
                            if (args[i] == "-")
                            {
                                forresult = int.Parse(args[i + 1]);
                                int totalresult = calculating_array[i - 1] - forresult;
                                calculating_array[i + 1] = totalresult;

                            }
                            if (args[i] == "*")
                            {
                                forresult = int.Parse(args[i + 1]);
                                int totalresult = calculating_array[i - 1] * forresult;
                                calculating_array[i + 1] = totalresult;
                        }
                            if (args[i] == "/")
                            {
                                forresult = int.Parse(args[i + 1]);
                                int totalresult = calculating_array[i - 1] / forresult;
                                calculating_array[i + 1] = totalresult;   
                            }

                        }
                        
                    

                    }
                  
                int total_result = calculating_array[calculating_array.Length - 1];

                Console.WriteLine("Result = " + total_result);


            }
            else
            {
                Console.WriteLine("Need numbers");
            }
         
        }
    }
}
