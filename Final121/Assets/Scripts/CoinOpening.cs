using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinOpening : MonoBehaviour
{
    public Component doorcollider;
    public GameObject Destruction;
   // public GameObject Effect;
   // public GameObject Dust;
    private bool isDestroyed = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void OnTriggerStay()
    {
        doorcollider.GetComponent<BoxCollider>().enabled = true;
        //Dust.SetActive(false);
        Destruction.SetActive(false);
       
        if (isDestroyed == false)
        {
            //Instantiate(Effect, transform.position, transform.rotation);
            isDestroyed = true;
        }
    }

}