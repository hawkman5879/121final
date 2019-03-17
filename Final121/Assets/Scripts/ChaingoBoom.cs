using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaingoBoom : MonoBehaviour
{
    public GameObject player;
    public GameObject chain1;
    public GameObject chain2;
    public GameObject explosion;
    public GameObject explosion1;
    public GameObject explosion2;
    public Component boatcollider;
    // Start is called before the first frame update
    void OnTriggerStay ()
    {
        chain1.SetActive(false);
        chain2.SetActive(false);
        explosion.SetActive(true);
        explosion1.SetActive(true);
        explosion2.SetActive(true);
        boatcollider.GetComponent<BoxCollider>().enabled = true;

    }
}
