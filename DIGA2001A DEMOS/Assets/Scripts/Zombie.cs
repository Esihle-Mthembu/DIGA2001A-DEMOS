using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Zombie : MonoBehaviour
{
    private string _name;
    private int _arms;
    private int _legs;

    //1:
    public Zombie(string zombieName, int arms, int legs)
    {
        _name = zombieName;
        _arms = arms;
        _legs = legs;
    }

    //2:
    public void setLegs(int newLegs)
    {
        _legs = newLegs;
    }

    //3:
    public int getArms()
    {
        return _arms;
    }

    //4:
    public int getLegs()
    {
        return _legs;  
    }
}
