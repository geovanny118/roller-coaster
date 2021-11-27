using System;
using System.Collections.Generic;

namespace EXCERCISE_ARP_5
{
    class Program
    {     
        static void Main(string[] args)
        {

            Person clients = new Person();
            clients.generateClientRow();
            clients.viewClientRow();
            
            Wagon rollerCoaster = new Wagon();
            rollerCoaster.fillWagon(clients.row);

            //LLenar lista de personas que intentaron entrar al tren, OJO SOLO SE USA HASTA QUE EL VAGO SE LLENE
            //while(Wango[4]==nul || client_row == null)

            // Lista de persona que intentaron usar la montaña rusa
            List<Person> TryList = new List<Person>(); 
            //TryList.Add(client_row[0]);

            //Metodo 
            //fillWagon(client_row);

            /*
            rollerCoaster[0] = new Wagon(client_row[0], client_row[1]);
            rollerCoaster[1] = new Wagon(client_row[2], client_row[3]);
            rollerCoaster[2] = new Wagon(client_row[4], client_row[0]);
            rollerCoaster[3] = new Wagon(client_row[1], client_row[2]);
            rollerCoaster[4] = new Wagon(client_row[3], client_row[4]);
            */

/*
            Console.WriteLine();
            Console.WriteLine("Roller Coaster Position: ");
            for(int i=0; i<5; i++){
                Console.WriteLine((i+1) + " " + rollerCoaster[i]?.Place_1?.Name + " " + rollerCoaster[i]?.Place_1?.Lastname_3 + " - " +rollerCoaster[i]?.Place_2?.Name + " " + rollerCoaster[i]?.Place_2?.Lastname_3);
            }
*/
            /*
            Console.WriteLine("Taller ARP 5");
            List<int> list_number = new List<int>();

            list_number.Add(1);
            list_number.Add(2);
            list_number.Add(3);
            list_number.Add(4);
            Console.WriteLine("hay: " + list_number.Count);
            foreach(var item in list_number){
                Console.WriteLine("old list: " + item);
            }

            int x = list_number[0];
            Console.WriteLine(x);
            list_number.RemoveAt(0);

            foreach (var item in list_number)
            {
                Console.WriteLine("new list: " + item);
            }

            Console.WriteLine(list_number.Equals(null));
            list_number.Clear();
            Console.WriteLine(list_number.Count);
            */
        }
    }
}
