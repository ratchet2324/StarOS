using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;


namespace StarOS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("StarOS booted successfully. Type a line of text to get it echoed back.");
            //Desktop.startGUI();
        }
        
        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
