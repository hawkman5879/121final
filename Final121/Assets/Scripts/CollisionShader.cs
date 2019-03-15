using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionShader : MonoBehaviour
{
    public Material Material1;
    public Material Material2;
    public Material Material3;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object;
    public GameObject fireEffect1;
    public GameObject fireEffect2;
    public GameObject waterEffect3;
    public GameObject boat;
    public GameObject falseWall;
    public GameObject Wildfire1;
    public GameObject Wildfire2;
    public GameObject Flamethrower1;
    public GameObject Flamethrower2;
    public GameObject IceLance1;
    public GameObject IceLance2;
   // public GameObject IceLance3;
    


    void Start()
    {
        // Object.GetComponent<MeshRenderer>().material = Material1;
        RenderSettings.skybox = Material3;

    }
    void Update()
    {
        OnOff();
        
        
    }
    void OnOff()
    {
        if (Input.GetKey("o"))
        {
            RenderSettings.skybox = Material1;
            fireEffect1.SetActive(true);
            fireEffect2.SetActive(true);
            waterEffect3.SetActive(false);
            boat.SetActive(false);
            //falseWall.SetActive(true);
            Wildfire1.SetActive(true);
            Wildfire2.SetActive(true);
            Flamethrower1.SetActive(true);
            Flamethrower2.SetActive(true);
            IceLance1.SetActive(false);
            IceLance2.SetActive(false);
           // IceLance3.SetActive(false);

        }
        if (Input.GetKey("p"))
        {
            RenderSettings.skybox = Material2;
            fireEffect1.SetActive(false);
            fireEffect2.SetActive(false);
            waterEffect3.SetActive(true);
            boat.SetActive(true);
            //falseWall.SetActive(false);
            Wildfire1.SetActive(false);
            Wildfire2.SetActive(false);
            Flamethrower1.SetActive(false);
            Flamethrower2.SetActive(false);
            IceLance1.SetActive(true);
            IceLance2.SetActive(true);
            //IceLance3.SetActive(true);
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        
        Debug.Log("Collision");
        Application.LoadLevel(Application.loadedLevel);
    }
}
