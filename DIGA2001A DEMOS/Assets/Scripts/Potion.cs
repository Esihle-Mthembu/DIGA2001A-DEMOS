using UnityEngine;

public class Potion : MonoBehaviour
{
    public string potionName;
    public int potency;
    public float volume;

    public void Drink()
    {
        Debug.Log("You drink a" + potionName + ". Potency: " + potency + ", Volume: " + volume);
    }
}
