Console.WriteLine("Välj en av alternativen");
Console.WriteLine("1. Geografi");
Console.WriteLine("2. Svergie");
Console.WriteLine("3. Historia");
Console.WriteLine("4. Språk");
Console.WriteLine("5. Sluta programmet");
string svar = "";
int l = int.Parse(Console.ReadLine());
string[] F = new string[4];
F[0] = "I vilket land ligger Berlin";
F[1] = "I vilken län ligger växjö";
F[2] = "Vem var ledaren av sovjet unionen under andra världskriget";
F[3] = "Skriver man Bättre eller Bätre";
string[] S = new string[4];
S[0] = "Tyskland";
S[1] = "Kronoberg";
S[2] = "Joseph Stalin" + "Stalin";
S[3] = "Bättre";
while (l != 5)  {
    switch (l)
    {
        case 1:
            Console.WriteLine(F[0]);
            svar = Console.ReadLine();
            if (svar == S[0])   {
                Console.WriteLine("Du hade rätt");
            }   else    {
                Console.WriteLine("Du svarade fel");
            }
            break;
        case 2:
            Console.WriteLine(F[1]);
            svar = Console.ReadLine();
            if (svar == S[1])   {
                Console.WriteLine("Du hade rätt");
            }   else    {
                Console.WriteLine("Du svarade fel");
            }
            break;
        case 3:
            Console.WriteLine(F[2]);
            svar = Console.ReadLine();
            if (svar == S[2])   {
                Console.WriteLine("Du hade rätt");
            }   else    {
                Console.WriteLine("Du svarade fel");
            }
            break;
        case 4 : 
            Console.WriteLine(F[3]);
            svar = Console.ReadLine();
            if (svar == S[3])   {
                Console.WriteLine("Du har rätt");
            }  else     {
                Console.WriteLine("Du svarade fel");
            }
            break;
        default :
            Console.WriteLine("Välj ett av alternativen");
            break;
    }
    Console.WriteLine();
    Console.WriteLine("1. Geografi");
    Console.WriteLine("2. Svergie");
    Console.WriteLine("3. Historia");
    Console.WriteLine("4. Språk");
    Console.WriteLine("5. Sluta programmet");
    l = int.Parse(Console.ReadLine());
}