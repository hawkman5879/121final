using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text hint;
    private int time = 350;
    private int nextUpdate = 1;
    public GameObject redBoat;
    public GameObject player;
    private int endGame = 5;
    private bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        hint.text = "You have " + time + " seconds to finish.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate && gameOver == false)
        {
            //Debug.Log(Time.time + ">=" + nextUpdate);
            // Change the next update (current second+1)
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            // Call your fonction
            timeUpdate();
        }
            if (Time.time >= nextUpdate && gameOver == true)
        {
            //Debug.Log(Time.time + ">=" + nextUpdate);
            // Change the next update (current second+1)
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            // Call your fonction
            overUpdate();
        }
            if (time <= 0)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
    }

        void timeUpdate()
        {
            time = time - 1;
            hint.text = "You have " + time.ToString() + " seconds to finish.";
        }
        public void OnTriggerEnter(Collider other)
        {
         if (other.tag == "EndGame")
            {
                hint.text = "You have won!";
                gameOver = true;
            }
        }
        private void overUpdate()
        {
            endGame = endGame - 1;
                if (endGame <= 0)
                    Application.LoadLevel(Application.loadedLevel);
        }
 }


