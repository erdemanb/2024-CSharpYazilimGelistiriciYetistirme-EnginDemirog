
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Degiskenler();
        Vatandas vatandas1 = new Vatandas();
        
        
        static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000; //Databaseden gelir.
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
}
//Pascal Case, public olduğunda fieldların da ilk harfi büyük olur. 
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}