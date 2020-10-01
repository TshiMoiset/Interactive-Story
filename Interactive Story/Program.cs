using System;

namespace Interaktive_story
{
    class Program
    {
        static void Main(string[] args)
        {
            string Svar1; //String gör att jag kan använda svar1 variabelna

            Console.ForegroundColor
                      = ConsoleColor.Magenta;    //Ger texten en röd färg.

            Typewrite("Vad händer len? Eyy bror, jag har baxat chok mycket parra igår, ska vi beställa kebab? jag är chok hungrig mannen.");
            Console.WriteLine();
            Svar1 = Console.ReadLine().ToLower(); //ToLower gör så att man kan svara med stora bokstäver

            if (Svar1 == "ja")
            {
                Console.WriteLine();
                Typewrite("Vill du han något att dricka?");
                Console.WriteLine();        //Ifall att man svarar ja kommer programmet gå till static void astaghfirullah
                astaghfirullah();
            }
            if (Svar1 == "nej")
            {
                Console.WriteLine();
                Typewrite("Yani, är du inte hungrig eller? WALLAH jag ska äta upp allt själv."); //Ifall att man svara nej kommer att svara så här
                Console.WriteLine();

            }
            if (Svar1 == "astaghfirullah")
            {
                Console.WriteLine();
                Typewrite("Llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch");   //Easter egg
                Console.WriteLine();

            }

            Console.ReadLine();

        }
        static void astaghfirullah()                //En ny void ifall att man svarar "Ja" om man villE äta. 
        {
            string Svar2;
            Svar2 = Console.ReadLine().ToLower();
            if (Svar2 == "ja")
            {
                Console.WriteLine();
                Typewrite("Ait bror, ska jag ta en cola till dig!");
                Console.WriteLine();

                nej();
            }
            if (Svar2 == "nej")
            {
                Console.WriteLine();
                Typewrite("Ait, bror men maten kommer om 30 min.");
                Console.WriteLine();

            }

            Console.ReadLine();

        }
        static void nej()           //Nu void ifall att man svarar nej till om man vill ha cola
        {
            string Svar3;
            Svar3 = Console.ReadLine().ToLower();

            if (Svar3 == "nej")
            {
                Console.WriteLine();
                Typewrite("Yani, vad vill du dricka? De har bara fanta, cola och 7up.");
                Console.WriteLine();

                fantacola7up();     //Programmet kommer att läsa static void "fantacola7up" om man inte vill ha cola
            }

            if (Svar3 == "ja")
            {
                Console.WriteLine();
                Typewrite("Ait bror, jag har beställt. Maten är här om 30 minuter.");
                Console.WriteLine();

            }

            Console.ReadLine();

        }
        static void fantacola7up()
        {

            string Svar4;
            Svar4 = Console.ReadLine().ToLower();
            if (Svar4 == "fanta")
            {
                Console.WriteLine();
                Typewrite("Ait bror, jag har beställt. Maten är här om 30 minuter");
                Console.WriteLine();

            }
            if (Svar4 == "cola")
            {
                Console.WriteLine();
                Typewrite("Ait bror, jag har beställt. Maten är här om 30 minuter");
                Console.WriteLine();

            }
            else if (Svar4 == "7up")
            {
                Console.WriteLine();
                Typewrite("Ait bror, jag har beställt. Maten är här om 30 minuter");
                Console.WriteLine();

            }

        }

        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
            }
        }


    }
}


