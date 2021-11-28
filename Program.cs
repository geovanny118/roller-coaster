using System;
using System.Collections.Generic;

namespace EXCERCISE_ARP_5
{
    class Program
    {     
        static void Main(string[] args)
        {
            //valor multa
            const double PENALTYVALUE = 2500;

            Person clients = new Person();
            clients.generateClientRow();
            clients.viewClientRow();

            //Lista de clientes con multa
            List<Person> sanctionedList = new List<Person>();

            //Lista de personas que intentaron ingresar 
            List<Person> triedList = new List<Person>();

            Wagon rollerCoaster = new Wagon();
            rollerCoaster.setWagon();

            //Mientras halla espacio disponible en la montaña rusa, puede agregar personas
            while(rollerCoaster.availableSpace){
                //verifica si una persona puede pasar al vagon (solo si no hay dos familiares en los vagones)
                if(rollerCoaster.canEnterWagon(clients.row[0])){
                    //ingresa persona al vagon
                    rollerCoaster.addClient(clients.row[0]);
                }else{
                    //si la persona no puede pasar al vago, se agrega a una lista de sancionados
                    sanctionedList.Add(clients.row[0]);
                }
                //Se agrega a la lista de intentos
                triedList.Add(clients.row[0]);
                //saca la persona que ingreso de la fila de espera
                clients.row.RemoveAt(0);
            }

            Console.WriteLine();
            Console.WriteLine("Montaña Rusa LLena!!!");

            Console.WriteLine();
            Console.WriteLine("Pasajeros en la montaña Rusa:");
            Console.WriteLine("Puesto 1 - Puesto 2");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rollerCoaster.wagon[i].Place_1.Name + " " + rollerCoaster.wagon[i].Place_1.Lastname_3 + " - " + rollerCoaster.wagon[i].Place_2.Name + " " + rollerCoaster.wagon[i].Place_2.Lastname_3);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de clientes sancionados:");
            foreach (var sanctioned in sanctionedList)
            {
                Console.WriteLine(sanctioned.Name + " " + sanctioned.Lastname_3);
            }

            Console.WriteLine();
            Console.WriteLine("Total pasajeros con multa:" + sanctionedList.Count);

            Console.WriteLine();
            Console.WriteLine("Total valor multa del dia:" + (sanctionedList.Count * PENALTYVALUE));

            Console.WriteLine();
            Console.WriteLine("Lista de clientes que no ingresaron:");
            foreach (var personOutside in clients.row)
            {
                Console.WriteLine(personOutside.Name + " " + personOutside.Lastname_3);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de personas que intentaron ingresar a la montaña rusa (los que ingresaron y los que fueron sancionados antes de llenar todos los vagones)");
            foreach (var personTried in triedList)
            {
                Console.WriteLine(personTried.Name + " " + personTried.Lastname_3);
            }

/*
            Console.WriteLine();
            Console.WriteLine("hay puesto disponible; " + rollerCoaster.availableSpace);
            if(rollerCoaster.availableSpace){
                //rollerCoaster.addClient(clients.row[0]); //vagon 1 posicion 1
                //rollerCoaster.addClient(clients.row[1]); //vagon 1 posicion 2
                //rollerCoaster.addClient(clients.row[2]); //vagon 2 posicion 1
                //rollerCoaster.addClient(clients.row[3]); //vagon 2 posicion 2
                //rollerCoaster.addClient(clients.row[4]); //vagon 3 posicion 1
                //rollerCoaster.addClient(clients.row[5]); //vagon 3 posicion 2
                //rollerCoaster.addClient(clients.row[6]); //vagon 4 posicion 1
                //rollerCoaster.addClient(clients.row[7]); //vagon 4 posicion 2
                //rollerCoaster.addClient(clients.row[8]); //vagon 5 posicion 1
                //rollerCoaster.addClient(clients.row[9]); //vagon 5 posicion 2
            }
            Console.WriteLine("hay puesto disponible; " + rollerCoaster.availableSpace);

            Console.WriteLine();
            Person p1 = new Person("Geovanny", "Rojas", "Lopez", "Perdomo");
            Person p2 = new Person("Luis", "Fernando", "Molina", "Perez");
            Console.WriteLine("Puede entrar: " + "familia "+ p1.Lastname_3 + " " + rollerCoaster.canEnterWagon(p1)); 
            Console.WriteLine("Puede entrar: " + "familia "+ p2.Lastname_3 + " " + rollerCoaster.canEnterWagon(p2)); 

            Console.WriteLine();
            Console.WriteLine("Roller Coaster Position: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rollerCoaster.wagon[i].Place_1.Name + " " + rollerCoaster.wagon[i].Place_1.Lastname_3 + " - " + rollerCoaster.wagon[i].Place_2.Name + " " + rollerCoaster.wagon[i].Place_2.Lastname_3);
            }
            
*/
            //LLenar lista de personas que intentaron entrar al tren, OJO SOLO SE USA HASTA QUE EL VAGO SE LLENE
            //while(Wango[4]==nul || client_row == null)

            // Lista de persona que intentaron usar la montaña rusa
            //List<Person> TryList = new List<Person>(); 
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
