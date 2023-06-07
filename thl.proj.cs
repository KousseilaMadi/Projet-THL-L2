using System;
class THL
{



    public static void Main()
    {

        THL.gui();

        char ans;
        string mot;
        bool next = false;
        do
        {
            Console.WriteLine("\n");
            Console.Write(" ● Entrez Un Mot >>");
            mot = Console.ReadLine();
            if (mot == string.Empty)
            {
                Console.WriteLine(" ● Vous N'avais Rien Saisis...");
                continue;
            }

            if (THL.Appartiens(mot))
            { IN(mot); }
            else
            { OUT(mot); }

            Console.WriteLine("\t● Vous Voulez Inserer Un Autre Mot ?");

            do
            {
                Console.Write("\t● Enter (y)es ou (n)o :");
                ans = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                if (ans == 'y')
                { next = true; break; }
                if (ans == 'n')
                { next = false; break; }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t● Invalid Input !");
                Console.ForegroundColor = ConsoleColor.White;
            } while (ans != 'y' || ans != 'n');

        } while (next);

        Console.Write("\n\n\n");

        for (int i = 0; i < Console.WindowWidth / 2 - 25; i++)
        {
            Console.Write(" ");
        }

        Console.Write("● ● ⬤ Je Vous Remercie Pour Votre Tentatives ⬤ ● ●\n\n\n");


    }



    static void IN(string mot)
    {

        Console.Write(" ● Le Mot ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("'" + mot + "' ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Appartiens");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" à Ce Langage .");
    }
    static void OUT(string mot)
    {

        Console.Write(" ● Le Mot ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("'" + mot + "' ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("N'Appartiens PAS ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("à Ce Langage .");
    }


    static int state0(char ch)
    {
        switch (ch)
        {
            case 'b': return 1; break;
            case 'c': return 2; break;
            default: return -1;
        }
    }

    static int state1(char ch)
    {
        switch (ch)
        {
            case 'c': return 2; break;
            default: return -1;
        }
    }

    static int state2(char ch)
    {
        switch (ch)
        {
            case 'b': return 1; break;
            case 'c': return 2; break;
            default: return -1;
        }
    }

    public static bool Appartiens(string mot)
    {
        int i = 1;
        int etat = state0(mot[0]);
        if (etat != -1)
        {
            while (i < mot.Length)
            {
                if (etat == 1) { etat = state1(mot[i]); }
                if (etat == 2) { etat = state2(mot[i]); }
                i++;
            }
        }
        return (etat == -1) ? false : true;
    }








    static void gui()
    {

        Console.Clear();
        for (int i = 0; i < 5; i++)
        {
            for (int u = 0; u < Console.WindowWidth; u++)
            {
                if (i >= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("#");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        for (int u = 0; u < Console.WindowWidth; u++)
        {
            Console.Write("#");
        }
        for (int u = 0; u < Console.WindowWidth / 2 - 3; u++)
        {
            Console.Write("#");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("T.H.L");
        Console.ForegroundColor = ConsoleColor.White;
        for (int u = 0; u < Console.WindowWidth / 2 - 2; u++)
        {
            Console.Write("#");
        }
        for (int u = 0; u < Console.WindowWidth / 3; u++)
        {
            Console.Write("#");
        }
        for (int u = 0; u < Console.WindowWidth / 3; u++)
        {
            Console.Write(" ");
        }
        for (int u = 0; u < Console.WindowWidth / 3; u++)
        {
            Console.Write("#");
        }
        for (int u = 0; u < Console.WindowWidth / 4; u++)
        {
            Console.Write("#");

        }
        for (int u = 0; u < Console.WindowWidth / 2; u++)
        {
            Console.Write(" ");
        }
        for (int u = 0; u < Console.WindowWidth / 4 + 1; u++)
        {
            Console.Write("#");
        }
        Console.WriteLine("###");
        for (int u = 0; u < Console.WindowWidth / 2 - 14; u++)
        {
            Console.Write(" ");
        }
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine(" ● ⬤ Programme De l'AEF ⬤ ● ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("\n");
        Console.WriteLine("\n ⬤ La Grammaire de ce Language et Son AEF Sont Donnés\n   Au Professeur Dans Un Moment Précedent .\n\n ⬤ Dans Ce Programme vous Pouvez Inserer Des Mots et Voir \n ● Si Il Appartient au Language Donné Ou Non D'Aprés L'Algorithme De Son Automate .\n\n\n");
        Console.WriteLine(" ⬤ Le Language Est : ");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(" ● L =  {  Ω ⊂ { c, b }, Ω ne contiens pas 2b consécutifs } .\n\n");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }


}
