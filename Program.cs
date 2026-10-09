namespace Karta_Bohatera_2._0;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Karta Bohatera 2.0!");
        Console.WriteLine("");
        Console.Write("Podaj imie bohatera: ");
        string imieBohatera = Console.ReadLine();        
        
        Console.Write("Maksymalne Punkty Zycia: ");
        int MaxZycie = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj aktualne zycie Bohatera: ");
        int aktualneZycieBohatera = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj podstawowe obrazenia Broni: ");
        int podstawoweObrazenia = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj premie do sily (Dodaje sie do ataku): ");
        int podstawowePremieDoSily = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj mnozik ataku specjalnego: ");
        double mnozikataku = double.Parse(Console.ReadLine());
        
        Console.Write("Podaj Liczbe podstawowych atakow: ");
        int liczbaPodAtakowe = int.Parse(Console.ReadLine());
        
        
        const int plecakLiczbaMiejsc = 10;
        int liczbaPrzedmiotow = 0;
        bool przesteganieMiejscPlecaku = true;
        do
        {
            Console.WriteLine("Podaj liczbe przedmiotow w plecaku (Plecak ma 10 miejsc!)");
           liczbaPrzedmiotow = int.Parse(Console.ReadLine());
            
            if (plecakLiczbaMiejsc < liczbaPrzedmiotow)
            {
                przesteganieMiejscPlecaku = false;
                Console.Clear();
                Console.WriteLine("Podales za duzo liczbe przedmiotow!");
            }
            if(plecakLiczbaMiejsc>= liczbaPrzedmiotow)
                przesteganieMiejscPlecaku = true;
            
        } while (przesteganieMiejscPlecaku==false);

        
        double atakSpecjalny = mnozikataku*podstawoweObrazenia;
        double laczneObrazenia = liczbaPodAtakowe * (podstawoweObrazenia + podstawowePremieDoSily) + atakSpecjalny;
        Console.WriteLine("+==========================================+");
        Console.WriteLine("|             KARTA BOHATERA               |");
        Console.WriteLine("+==========================================+");
        Console.WriteLine("| Bohater: "+ imieBohatera+"\t \t \t   |");
        Console.WriteLine("| Zdrowie: "+ aktualneZycieBohatera+"/"+MaxZycie +" ("+aktualneZycieBohatera*100/MaxZycie+"% )"+" \t \t   |");
        Console.WriteLine("| Zwykly atak: "+ podstawoweObrazenia+"\t \t \t   |");
        Console.WriteLine("| Atak Specjalny: "+atakSpecjalny+"\t \t \t   |");
        Console.WriteLine("| Laczne zadane obrazenia: "+laczneObrazenia +"\t \t   |");
        Console.WriteLine("+==========================================+");
        
        bool zyje = true;
        if(aktualneZycieBohatera<=0)
            zyje = false;
        else if(aktualneZycieBohatera > 0)
            zyje = true;
        
        Console.WriteLine("| Zyje: "+zyje+"\t \t \t \t   |");
        
        
        bool pelneZycie = true;
        if(aktualneZycieBohatera== MaxZycie)
            pelneZycie = true;
        else if(aktualneZycieBohatera<MaxZycie)
            pelneZycie = false;
        
        Console.WriteLine("| Pelne Zycie: "+pelneZycie+"\t \t \t   |");

        bool mamMiejsceWplecaku = true;
        if(liczbaPrzedmiotow<plecakLiczbaMiejsc)
            mamMiejsceWplecaku = true;
        else
        {
            mamMiejsceWplecaku = false;
        }
        Console.WriteLine("| Miejsce w plecaku: "+ mamMiejsceWplecaku+"\t \t   |");
        Console.WriteLine("+==========================================+");
        
        
    }
}