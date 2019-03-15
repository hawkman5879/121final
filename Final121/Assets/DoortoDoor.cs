using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoortoDoor : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject player;
    
    void OnTriggerStay()
    {
        player.transform.position = door2.transform.position;
    }
}
