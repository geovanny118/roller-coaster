using System;
using System.Collections.Generic;
public class Wagon
{
    public Person Place_1 { get; set; }
    public Person Place_2 { get; set; }
    public Wagon(){}
    public Wagon(Person place_1, Person place_2)
    {
        Place_1 = place_1;
        Place_2 = place_2;
    }

    //valor multa
    private const double PENALTYVALUE = 2500;

    //arreglo vagon
    public Wagon[] wagon = new Wagon[5];

    //numero de cada vagon (0-4)
    private int actualPosition = 0;

    //verifica si hay espacio disponible en la montaña rusa
    public Boolean availableSpace {get; set;} = true;

    //Asigna una persona a un lugar con espacio disponible segun el orden
    public void addClient(Person client)
    {          
        if(wagon[actualPosition] == null)
        {
            wagon[actualPosition] = new Wagon();
            wagon[actualPosition].Place_1 = new Person();
            wagon[actualPosition].Place_2 = new Person();
        }

        if(actualPosition<5){
            if(wagon[actualPosition].Place_1.Name == null){
                wagon[actualPosition].Place_1 = client;
            } 
            else if(wagon[actualPosition].Place_2.Name == null){
                wagon[actualPosition].Place_2 = client;
                actualPosition++;
            }  
        }

        if(actualPosition >= 5){
            availableSpace = false;
        } 
    }

    //Recibe un cliente y verifica si ya hay mas miembros de la familia dentro de la montaña rusa
    //Si hay MENOS de 2 miembros de la misma familia, puede entrar: return true
    //Si hay 2 miembros de la misma familia, no puede entrar: return false
    public Boolean canEnterWagon(Person client)
    {
        string lastname = client.Lastname_3;
        int amountPerFamily = 0;
        
        for(int i=0; i < wagon.Length; i++){
            if(wagon[i].Place_1.Lastname_3 == lastname){
                amountPerFamily++;
            }

            if (wagon[i].Place_2.Lastname_3 == lastname)
            {
                amountPerFamily++;
            }

            if (amountPerFamily == 2)
            {
                return false;
            }
        }

        return true;
    }

}