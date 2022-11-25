namespace pract1;
using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        string ubicacionArchivo = "C:\\Users\\jaime\\OneDrive\\Escritorio\\mparking-master\\Violations_2019.csv";
System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);
string separador = ",";
string linea;
int i=0;
int j=0;
archivo.ReadLine();
String StreetName = "";
ArrayList Streets = new ArrayList();
ArrayList AllStreets = new ArrayList();
int[] numeroderepes= new int[1000];
while((linea = archivo.ReadLine()) != null)
{
    String[] fila = linea.Split(separador);
    StreetName = fila[5];
    if (Streets.Contains(StreetName)){
        numeroderepes[i]++;
 }
 else{
 Streets.Add(StreetName);
 i++;
numeroderepes[i]++;
 }
    }
    int [] top5 = new int[5];
for(i=0;i<5;i++){
    int max=numeroderepes.Max();
   int top1 = Array.IndexOf(numeroderepes, max);
    top5[i]=top1;
   Array.Clear(numeroderepes,top1,1);
}
for(i=0;i<5;i++){
   Console.Write ("{0}\n",Streets[i]);
}
 }
    
    public static void PrintValues( IEnumerable myList ){
       foreach (Object obj in myList){
        Console.Write(" {0}", obj);
        Console.WriteLine(); 
    }
}
}