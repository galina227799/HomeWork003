Console.Clear();
Console.Write("Введите число: ");
int Nom = int.Parse(Console.ReadLine());
int i = 1;
if(Nom < 0) {
   i = Nom;
   Nom = -1;
}
while(i<Nom+1){
    Console.Write($"{Math.Pow(i,3)}, ");
    i = i+1;
}