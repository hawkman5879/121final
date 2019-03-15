using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCollide : MonoBehaviour
{
    public GameObject door;
    public GameObject player;


    // Update is called once per frame
    void OnTriggerStay()
    {
            player.transform.position = new Vector3 (14.11f, 27.990f, -319.1f);
    }
}
