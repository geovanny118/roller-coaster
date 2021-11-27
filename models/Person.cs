using System;
using System.Collections.Generic;
public class Person {
    public String Name {get; set;}
    public String Lastname_1 { get; set; }
    public String Lastname_2 { get; set; }
    public String Lastname_3 { get; set; }
    private string[] NAMES = { "kevin", "andres", "diego", "alexandra", "yamileth" };
    private string[] LASTNAMES = { "cifuentes", "perez", "muñoz", "perdomo", "bermudez" };
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

        row.Add(new Person(NAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)]));
        row.Add(new Person(NAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)]));
        row.Add(new Person(NAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)]));
        row.Add(new Person(NAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)]));
        row.Add(new Person(NAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)], LASTNAMES[random.Next(0, 4)]));
    }
    
    //ver fila de clientes
    public void viewClientRow(){
        Console.WriteLine("Client List: ");
        foreach (var item in row)
        {
            Console.WriteLine(item.Name + " " + item.Lastname_1 + " " + item.Lastname_2 + " " + item.Lastname_3);
        }
    }
}