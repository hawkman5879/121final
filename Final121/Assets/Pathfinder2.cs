using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject Flame;
    //public GameObject Dust;
    public GameObject SandSwirl1;
    public GameObject SandSwirl2;
    public GameObject SandSwirl3;
    public GameObject SandSwirl4;
    public GameObject SandSwirl5;
    public GameObject SandSwirl6;
    public GameObject SandSwirl7;
    //public GameObject Gate;
    //public GameObject coin;
    // Update is called once per frame
    void OnTriggerStay()
    {
        SandSwirl1.SetActive(true);
        SandSwirl2.SetActive(true);
        SandSwirl3.SetActive(true);
        SandSwirl4.SetActive(true);
        SandSwirl5.SetActive(true);
        SandSwirl6.SetActive(true);
        SandSwirl7.SetActive(true);
    }
}
