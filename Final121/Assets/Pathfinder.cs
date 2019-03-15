using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject Flame;
    public GameObject Dust;
    public GameObject SandSwirl1;
    public GameObject Gate;
    public GameObject coin;
    // Update is called once per frame
    void OnTriggerStay()
    {
        Dust.SetActive(true);
    }
    void Update()
    {
    }
}
