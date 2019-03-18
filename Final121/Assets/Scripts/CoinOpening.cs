using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(AudioSource))]
public class CoinOpening : MonoBehaviour
{
    public AudioSource coinCollect;

    public Component doorcollider;
    public GameObject Destruction;
   // public GameObject Effect;
   // public GameObject Dust;
    private bool isDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void OnTriggerStay()
    {
        doorcollider.GetComponent<BoxCollider>().enabled = true;
        coinCollect.Play();
        Destruction.SetActive(false);
        if (isDestroyed == false)
        {
            //Instantiate(Effect, transform.position, transform.rotation);
            isDestroyed = true;
           
        }
    }

}