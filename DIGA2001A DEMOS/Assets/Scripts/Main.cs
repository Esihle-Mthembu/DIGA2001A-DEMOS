using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Animal("Dog", 4, 0);

        //5
        Zombie zombie1 = new Zombie("Chuck", 1, 2);

        //6
        zombie1.setLegs(0);

        //7
        print(zombie1.getArms());

        //8
        print(zombie1.getLegs());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
