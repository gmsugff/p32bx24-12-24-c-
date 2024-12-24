using System.Drawing;

namespace p32bx_24_12_24_122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввидите 1- игровой,2-офис:");
            CharacterBuilder Builder;
           int num =Convert.ToInt32(Console.ReadLine());
            if(num == 1) 
            { 
              Builder = new gaming();
            CharacterDirector director = new CharacterDirector(Builder);
            director.BuildCharacter();
            accessories warrior = director.GetCharacter();
            Console.WriteLine(warrior);

            
            
            }
            if (num == 2)
            {
                 Builder = new office();
            CharacterDirector director2 = new CharacterDirector(Builder);
            director2.BuildCharacter();
            accessories holyMagician = director2.GetCharacter();
            Console.WriteLine(holyMagician);
            }
           
        }

        public class accessories
        {
            public string ProcessorType { get; set; }
            public int TheaAmountOfRAM { get; set; }
            public int TheSizeOfTheHardDisk { get; set; }
            public int TheChipOfTheGraphicsCard { get; set; }
            

            public override string ToString()
            {
                return $"TheaAmountOfRAM: {TheaAmountOfRAM} ГБ\n" +
                       $"TheSizeOfTheHardDisk: {TheSizeOfTheHardDisk} ГБ\n" +
                       $"TheChipOfTheGraphicsCard: NVIDIA RTX{TheChipOfTheGraphicsCard}\n";
            }
        }

        public abstract class CharacterBuilder
        {
            protected accessories character = new accessories();
            public abstract void SetProcessorType();
            
            public abstract void Set();

            public accessories GetResult()
            {
                return character;
            }
        }

        public class gaming : CharacterBuilder
        {
            public override void SetProcessorType()
            {
                character.ProcessorType = "Intel Core i9 14900 kf";
            }

            public override void Set()
            {
                character.TheaAmountOfRAM = 64;
                character.TheSizeOfTheHardDisk = 2000;
                character.TheChipOfTheGraphicsCard = 4090;
            }

            
        }

        public class office : CharacterBuilder
        {
            public override void SetProcessorType()
            {
                character.ProcessorType = "Intel Core i9 4300 kf";
            }

            public override void Set()
            {
                character.TheaAmountOfRAM = 4;
                character.TheSizeOfTheHardDisk = 500;
                character.TheChipOfTheGraphicsCard = 2060;
            }
        }

        class CharacterDirector
        {
            private CharacterBuilder builder;

            public CharacterDirector(CharacterBuilder builder)
            {
                this.builder = builder;
            }

            public void BuildCharacter()
            {
                builder.SetProcessorType();
                builder.Set();
                
            }

            public accessories GetCharacter()
            {
                return builder.GetResult();
            }
        }
    }
}
