
Console.WriteLine("Merhaba");


//Variable Types

/*int sayi = 10; //tamsayı

double kdv = 1.18; //ondalıklı sayı

char gender = 'k'; //tek harf

string cinsiyet = "kadın"; //kelime veya cümle 

*/

//Veri tipi dönüşümü

Console.WriteLine("1.sayı: ");
string? sayi1 = Console.ReadLine(); // Konsolda string tipinde girilen inputu okur.
int sayi1int = Convert.ToInt32(sayi1); // String değer int e çevirildi


Console.Write("2.sayı: "); // WriteLine ve Write arasındaki fark: sadece Write yazıldığında alt satıra inmez.
string? sayi2 = Console.ReadLine();
int sayi2int = Convert.ToInt32(sayi2); // String değer int e çevirildi

var toplam = sayi1 + sayi2; // 1020 => toplama yapmaz.String değer olduğu için yan yana yazar.
Console.WriteLine(toplam);
var toplam2 = sayi1int + sayi2int; // Toplama işlemi başarıyla yapılır.
Console.WriteLine(toplam2);
