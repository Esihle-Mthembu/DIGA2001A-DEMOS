using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Animal : MonoBehaviour
{
    private string _species;
    private int _numArms;
    private int _numLegs;

    //a:
    public Animal()
    {
        Debug.Log("Animal Created");
    }
    
    //b:
    public Animal(string animalSpecies, int legs, int arms)
    {
        _species = animalSpecies;
        _numArms = arms;
        _numLegs = legs;
    }
}
