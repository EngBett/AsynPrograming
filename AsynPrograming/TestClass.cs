using System;

namespace AsynPrograming
{
    public class TestClass
    {
        public TestClass()
        {
            
        }

        public void GuidLoop()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(new Guid().ToString());
            }
        }

        public void AnotherLoop()
        {
            
        }
    }
}