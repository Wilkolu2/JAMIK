using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private Pause pause;
    // Start is called before the first frame update
    void Start()
    {
        pause = GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(pause.isPaused)
        {
            Debug.Log("musisz odpauzowac plytke");
        }
        else if(!pause.isPaused && !other.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("elegancja francja"); //cos sie dzieje np door(open);
        }
    }
    
}
