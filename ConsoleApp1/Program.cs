
/* 
    indeksty 0-4 wyniki poszczegulne egzaminów
    indeks 5 dodatkowe zadnaie
    indeks 6 wynik egzaminu ?

*/
double[] uczenJeden = { 90, 86, 87, 98, 100 , 84}; // Dane Sophii
double[] uczenDwa = { 92, 89, 81, 96, 90 , 45};   // Dane Andrew
double[] uczenTrzy = { 90, 85, 87, 98, 68 , 65};  // Dane Emmy
double[] uczenCztery = { 90, 95, 87, 88, 96 , 87}; // Dane Logana

string[] imiona = {"albert kowal","mati lepiuk","pablo nod","kilo oma"};


string ocenaLitera(int punkty)
{
    if(punkty < 60) return "F";
    if(punkty < 63) return "D-";
    if(punkty < 67) return "D";
    if(punkty < 70) return "D+";
    if(punkty < 73) return "C-";
    if(punkty < 77) return "C";
    if(punkty < 80) return "C+";
    if(punkty < 83) return "B-";
    if(punkty < 87) return "B";
    if(punkty < 90) return "B+";
    if(punkty < 93) return "A-";
    if(punkty < 97) return "A";
    return "A+";
}

string ocenaKoncowa(double[] uczen, string imie)
{
    double suma = 0;

    for(int i = 0; i < 5; i++)
    {
        suma+=uczen[i];
    }
    
    double oceanLiczbowa = suma/5;
    double oceanLiczbowaCalkowita = oceanLiczbowa + (uczen[5]*0.1);
    double extraCredits = uczen[5]*0.1;

    string tytuly = "Student \t Exam Score \t Overall \t Grade \t Extra Credit \n";
    string komunikat = tytuly+$"{imie} \t {oceanLiczbowa} \t\t {oceanLiczbowaCalkowita} \t\t {ocenaLitera((int)oceanLiczbowa)} \t {extraCredits} \n";
    return komunikat;
}


System.Console.WriteLine(ocenaKoncowa(uczenJeden,imiona[0]));
System.Console.WriteLine(ocenaKoncowa(uczenDwa,imiona[1]));
System.Console.WriteLine(ocenaKoncowa(uczenTrzy,imiona[2]));
System.Console.WriteLine(ocenaKoncowa(uczenCztery,imiona[3]));


Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine("a" == "a ");