using System;

namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer gamingPC = new Computer.Builder()
                .SetCPU("Intel i9")
                .SetRAM(32)
                .SetStorage(1000)
                .SetGPU("NVIDIA RTX 4080")
                .Build();

            Computer officePC = new Computer.Builder()
                .SetCPU("Intel i5")
                .SetRAM(16)
                .SetStorage(512)
                .SetGPU("Integrated Graphics")
                .Build();

            Console.WriteLine("Gaming PC Configuration:");
            gamingPC.Display();

            Console.WriteLine("Office PC Configuration:");
            officePC.Display();
        }
    }
}
