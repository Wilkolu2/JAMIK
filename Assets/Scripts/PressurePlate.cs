using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private Pause pause;
    [SerializeField] private GameObject door;
    [SerializeField] private float rotation;
    private Vector3 startRot;
    // Start is called before the first frame update
    void Start()
    {
        startRot = door.transform.eulerAngles;
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
            door.transform.eulerAngles = new Vector3(0, rotation, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        door.transform.eulerAngles = startRot;
    }

}
