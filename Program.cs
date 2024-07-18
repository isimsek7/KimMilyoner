
int totalWrong = 0;
string a = ("a");
string b = ("b");
Console.WriteLine("------------------- BILGI YARISMASI---------------------");
Console.WriteLine("Eger yarismaci uc sorudan ikisine dogru cevap verirse 1 Milyon TL'lik odulu kazanacak!");
Console.WriteLine("Soru 1: Kizinca tukuren hayvan hangisidir \n {0}) Lama {1}) Deve",a,b);

Console.Write("Cevabinizi Giriniz: ");
string ans1= Console.ReadLine().ToLower();
if (ans1 == a)
{
    Console.WriteLine("Dogru Cevap!");
}
else
{
    totalWrong = totalWrong + 1;
    Console.WriteLine("Yanlis Cevap");
}
Console.WriteLine("Soru 2: Dunya'ya en yakin gezegen hangisidir? \n {0})Venus {1})Mars", a,b);
Console.Write("Cevabinizi Giriniz: ");
string ans2 = Console.ReadLine().ToLower();
if (ans2 == b)
{
    Console.WriteLine("Dogru Cevap!");
}
else
{
    totalWrong = totalWrong + 1;
    Console.WriteLine("Yanlis Cevap");
}
if (totalWrong < 2)
{
    Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? \n {0}) 7 {1}) 12 ",a,b);
    Console.Write("Cevabinizi Giriniz: ");
    string ans3 = Console.ReadLine().ToLower();
    if (ans3 == b)
    {
        Console.WriteLine("---------------- TEBRIKLER YARISMAYI KAZANDINIZ ---------------");
    }
    else
    {
        totalWrong = totalWrong + 1;
        Console.WriteLine("Yanlis Cevap");
    }
}
else
{
    Console.WriteLine("Yarismayi Kaybettiniz");
}
