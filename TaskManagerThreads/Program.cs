using System.Diagnostics;
using System.Net.Mime;

class Program
{
   static void Main(string[] args)
   {
      
      while (true)
      {
         Console.WriteLine(@"
1.Show all processes
2.Kill process
3.Create a process
4.See process detail
Choose one:");

         string choice = Console.ReadLine();
         if (choice == "1")
         {
            foreach (Process process in Process.GetProcesses())
            {
               Console.WriteLine(process.ProcessName);
            }
         }
         else if (choice == "2")
         {
            Console.Write("Enter the name of the process that you want to kill:");
            string processName = Console.ReadLine();
            var process = Process.GetProcessesByName(processName);
            process[0].Kill();            
         }
         else if (choice == "3")
         {
            Console.Write("Enter the name of the process that you want to start:");
            string processName = Console.ReadLine();
            var app1 = new ProcessStartInfo
            {
               FileName = processName,
               UseShellExecute = true,
            };
            try
            {
               Process.Start(processName);
            }
            catch
            {
               Console.WriteLine("Application couldn't start.");
            }
         }
         else if (choice == "4")
         {
            Console.Write("Enter the name of the process that you want to see details:");
            string processName = Console.ReadLine();
            var process = Process.GetProcessesByName(processName);
            Console.WriteLine($"Process name: {process[0].ProcessName}");
            Console.WriteLine($"Process id: {process[0].Id}");
            Console.WriteLine($"Machine name: {process[0].MachineName}");
            Console.WriteLine($"Handle count: {process[0].Handle}");
            
            
         }
         



      }
   }



}

