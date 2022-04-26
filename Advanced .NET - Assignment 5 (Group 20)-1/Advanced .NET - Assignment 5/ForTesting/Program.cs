using System;
using Problem2;
using Problem3;
using Assignment5;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Case @case = new Case(10, 10, 10, 4, 4);
            CPU cpu = new CPU(3.6, Manufacturer.AMD, "AM4", 24, 8);
            Memory memory = new Memory(2400, 2400, MemoryType.DDR4, 16);
            GPU gpu = new GPU(3, 1.9, 8, 24);
            Motherboard motherboard = new Motherboard(4, 200, 3, FormFactor.ATX, 6, cpu, memory, gpu);
            ComputerDirector director = new ComputerDirector();
            ComputerBuilder builder = new ComputerBuilder();
            builder.AddCase(@case).AddMotherboard(motherboard);




            var computer = new ComputerBuilder().AddCase(@case).AddMotherboard(motherboard).Build();
            var computer2 = director.Construct(builder);
            Console.WriteLine(computer.Show());
            Console.WriteLine(computer2.Show());
            */

            
            Mailbox myMailbox = new Mailbox(new MailingInformation("Cameron", "234 Albion Road"));
            Mail newMail = new Mail(new MailingInformation("Cameron", "234 Albion Road"), new MailingInformation("Cameron", "234 Albion Road"), 5, 5, MailType.Package, false);
            Dispatcher dispatcher = new Dispatcher();
            dispatcher.AddMailbox(myMailbox);
            dispatcher.Handle(newMail);
            Console.WriteLine(myMailbox.GetSize());
        }
    }
}
