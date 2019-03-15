using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCollide : MonoBehaviour
{
    public GameObject house;
    public GameObject player;
    public GameObject fountain;


    // Update is called once per frame
    void OnTriggerStay()
    {
        //player.transform.position = new Vector3(-15, 0, -95);
        player.transform.position = fountain.transform.position;
        
    }
}