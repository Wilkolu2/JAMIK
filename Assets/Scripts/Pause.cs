using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().Sleep();
        isPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPaused==false)
        {
            GetComponent<Rigidbody>().WakeUp();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Projectile"))
        {
            isPaused = false;
            GetComponent<Rigidbody>().WakeUp();
        }
    }
}
