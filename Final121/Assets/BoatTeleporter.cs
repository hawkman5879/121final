using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatTeleporter : MonoBehaviour
{
    public GameObject boat;
    public GameObject player;
    

    // Update is called once per frame
   void OnTriggerStay()
    {
        if (Input.GetKeyDown("e"))
        {
            player.transform.position = new Vector3(-91, 2, -345);

        }

    }
}
