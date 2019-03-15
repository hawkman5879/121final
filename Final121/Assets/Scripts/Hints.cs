using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Hints : MonoBehaviour
{
    public Text hint;
    public GameObject gate;
    public GameObject door;
    public GameObject boat;
    // Start is called before the first frame update
    void Start()
    {
        hint.text = "Touch the Fire in the courtyard. " + "The Dust will lead the way. " + "The Key to the gate will be near the Cross, you must Jump. " + "If it looks dangerous, it is. If you fall, the Red Boat enjoys being clicked on with E." ;
    }

    // Update is called once per frame
    void Update()
    {
        hintChange(); 
    }
   
    void hintChange()
    {
        if (gate.activeSelf == false)
        {
            hint.text = "The Fire ahead will reveal the way. " + " The Dust will lead the way. " + "Not all Houses and Walls are Real. "; 
            if (door.activeSelf == false)
            {
                hint.text = "Fire no longer pains you. Walk up and break the docks chains with E. Find the Red Boat and escape.";
            }
        }
    }
}

