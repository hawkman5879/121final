using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSama : MonoBehaviour
{
    // private bool played = false;
    // public Animation hinge;
    public GameObject Gate;
    public GameObject Effect;
    public AudioSource boom;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        Gate.SetActive(false);
        {
            boom.Play();
            Instantiate(Effect, transform.position, transform.rotation);
        }
    }
}
