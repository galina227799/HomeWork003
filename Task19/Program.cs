Console.Clear();
Console.Write("Введите число: ");
string Nom = Console.ReadLine();
int LenghtNom = Nom.Length;
int j;
for ( j = 0; j < LenghtNom/2; j++)
{
    if(Nom[j]!= Nom[LenghtNom-j-1]){
        Console.WriteLine("Не является полиндромом");
        return;
    } 
}
Console.WriteLine("Является полиндромом");