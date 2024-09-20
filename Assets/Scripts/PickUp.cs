using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float range = 1f;
    [SerializeField] private string objectName;
    [SerializeField] private Transform pickUpPoint;
    [SerializeField] private GameObject[] item = new GameObject[5];
    [SerializeField] private PauseGun pauseGun;
    public bool isPickingUp = false;
    public bool isPaused;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


        Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
        RaycastHit raycastHit;
      

        if (Physics.Raycast(ray, out raycastHit, range))
        {
            objectName = raycastHit.collider.gameObject.name;  
            if(raycastHit.rigidbody.IsSleeping()==true)
            {
                isPaused = true;
            }
            else if (raycastHit.rigidbody.IsSleeping() == false)
            {
                isPaused = false;
            }

        }
        else
        {
            objectName = null;
        }

        if (objectName == null)
        {
            for(int i = 0; i < item.Length; i++)
            {
                item[i].GetComponent<Outline>().enabled = false;
                item[i].GetComponent<Rigidbody>().useGravity = true;
                item[i].GetComponent<Collider>().isTrigger = false;
            }

           
        }
        //TestItem
        if (objectName.Equals("TestItem"))
        {
            item[0].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("TestItem"))
        {
            item[0].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false)
        {
            isPickingUp = true;
            if(objectName.Equals("TestItem"))
            {
                item[0].GetComponent<Outline>().enabled = false;
                item[0].GetComponent<Rigidbody>().useGravity = false;
                item[0].GetComponent<Collider>().isTrigger = true;
                item[0].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }          
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            isPickingUp = false;
            item[0].GetComponent<Outline>().enabled = false;
            item[0].GetComponent<Rigidbody>().useGravity = true;
            item[0].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }

        //TestAmmo
        if (objectName.Equals("TestAmmo"))
        {
            item[1].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("TestAmmo"))
        {
            item[1].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E))
        {
            if (objectName.Equals("TestAmmo"))
            {
                pauseGun.currentAmmo += pauseGun.maxAmmo;
                Destroy(item[1]);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {        
            objectName = null;
        }
    }
}
