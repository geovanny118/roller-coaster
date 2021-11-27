using System;
using System.Collections.Generic;
public class Wagon
{
    public Person  Place_1 { get; set; }
    public Person  Place_2 { get; set; }
    private const double PENALTYVALUE = 2500;
    public Wagon(){}
    public Wagon(Person place_1, Person place_2){
        this.Place_1 = place_1;
        this.Place_2 = place_2;
    }

    public void fillWagon(List<Person> client_row)
    {   
        //arreglo vagon
        Wagon[] rollerCoaster = new Wagon[5];

        // Lista de persona multadas
        List<Person> sanctionedList = new List<Person>();

        Console.WriteLine();
        Console.WriteLine("Roller Coaster Position: ");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine((i + 1) + " " + rollerCoaster[i]?.Place_1?.Name + " " + rollerCoaster[i]?.Place_1?.Lastname_3 + " - " + rollerCoaster[i]?.Place_2?.Name + " " + rollerCoaster[i]?.Place_2?.Lastname_3);
        }
    }

}