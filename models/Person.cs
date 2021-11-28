using System;
using System.Collections.Generic;
public class Person {
    public String Name {get; set;}
    public String Lastname_1 { get; set; }
    public String Lastname_2 { get; set; }
    public String Lastname_3 { get; set; }
    private string[] NAMES = { "Kevin", "Andres", "Diego", "Alexandra", "Yamileth", "Cristian" };
    private string[] LASTNAMES = { "Cifuentes", "Perez", "Muñoz", "Perdomo", "Bermudez", "Corrales" };
    public List<Person> row = new List<Person>();
    public Person(){}
    public Person(string name, string lastname_1, string lastname_2, string lastname_3){
        this.Name = name;
        this.Lastname_1 = lastname_1;
        this.Lastname_2 = lastname_2;
        this.Lastname_3 = lastname_3;
    }

    //Crea la fila de los clientes
    public void generateClientRow(){
        var seed = Environment.TickCount;
        var random = new Random(seed);

        int numberOfClients = 0;

        while(numberOfClients<15){
            row.Add(new Person(NAMES[random.Next(0, 6)], LASTNAMES[random.Next(0, 6)], LASTNAMES[random.Next(0, 6)], LASTNAMES[random.Next(0, 6)]));
            numberOfClients++;
        }
    }
    
    //Ver fila de clientes
    public void viewClientRow(){
        Console.WriteLine();
        Console.WriteLine("Fila de clientes: ");
        int i = 1;
        foreach (var item in row)
        {
            Console.WriteLine(i + " " +item.Name + " " + item.Lastname_1 + " " + item.Lastname_2 + " " + item.Lastname_3);
            i++;
        }
    }
}