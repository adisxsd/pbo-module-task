
namespace modulpraktikum
{
    public class Processor
    {
        public string merk;
        public string tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    public class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core i3";
        }
    }
    public class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5";
        }
    }
    public class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core i7";
        }
    }
    public class VGA
    {
        public string merk;
    }
    public class Nvidia : VGA
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    public class Amd : VGA
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }
    public class Laptop
    {
        public string merk;
        public string tipe;
        Processor processor;
        VGA vga;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }

        public class ASUS : Laptop
        {
            public ASUS()
            {
                base.merk = "Asus";
            }
        }
        public class ACER : Laptop
        {
            public ACER()
            {
                base.merk = "ACER";
            }
        }
        public class Lenovo : Laptop
        {
            public Lenovo()
            {
                base.merk = "Lenovo";
            }
        }
        public class Ideapad : Lenovo
        {
            public Ideapad()
            {
                base.tipe = "Idepad";
            }
        }
        public class Legion : Lenovo
        {
            public Legion()
            {
                base.tipe = "Legion";
            }
        }
        public class Predator : ACER
        {
            public Predator()
            {
                base.tipe = "Predator";
            }
            public void BermainGame()
            {
                Console.WriteLine($"Laptop {merk} {tipe} sedang bermain game");
            }
        }
        public class swift : ACER
        {
            public swift()
            {
                base.tipe = "Swift";
            }
        }
        public class Vivobook : ASUS
        {
            public Vivobook()
            {
                base.tipe = "Vivobook";
            }
            public void Ngoding()
            {
                Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
            }
        }
        public class ROG : ASUS
        {
            public ROG()
            {
                base.tipe = "ROG";
            }
        }
        
        internal class program
        {
            
            static void Main(string[] args)
            {
            
                Laptop laptop2 = new Ideapad();
                laptop2.vga = new Amd();
                laptop2.processor = new Ryzen();

                Laptop laptop1 = new Vivobook();
                laptop1.vga = new Nvidia();
                laptop1.processor = new Corei5();

                Predator predator = new Predator();
                predator.vga = new Amd();
                predator.processor = new Corei7();

                Console.WriteLine("SOAL 1");
                laptop2.LaptopDinyalakan();
                laptop2.LaptopDimatikan();

                Console.WriteLine("SOAL 2");
                //laptop1.Ngoding();

                Console.WriteLine("SOAL 3");
                Console.WriteLine("-Laptop 1-");
                Console.WriteLine($"VGA            : {laptop1.vga.merk}");
                Console.WriteLine($"Merk Processor : {laptop1.processor.merk}");
                Console.WriteLine($"Tipe Processor : {laptop1.processor.tipe}");

                Console.WriteLine("SOAL 4");
                predator.BermainGame();

                Console.WriteLine("SOAL 5");
                ACER acer = new Predator();
                //acer.Bermaingame();
            }
        }
        

    }
}