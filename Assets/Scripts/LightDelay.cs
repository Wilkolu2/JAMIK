using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDelay1 : MonoBehaviour
{
  
    Light Light;
    public float minTime;
    public float maxTime;
    public float timer;
   
    // Start is called before the first frame update
    void Start()
    {
        Light = GetComponent<Light>(); 
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        LightBlinking();
    }

    void LightBlinking()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            Light.enabled = !Light.enabled;
            timer = Random.Range(minTime,maxTime);
        }
    }
}
