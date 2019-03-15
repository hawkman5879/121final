using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonGas : MonoBehaviour
{
    public GameObject Poison;
    public GameObject player;
    // Start is called before the first frame update
   void OnTriggerStay()
    {
        Debug.Log("Poison danger");
        Application.LoadLevel(Application.loadedLevel);
    }
}
