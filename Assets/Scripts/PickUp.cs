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
            Debug.Log(objectName);
        }
        else
        {
            objectName = null;
            Debug.Log(objectName);
        }

        if (objectName == null)
        {
            item[0].GetComponent<Outline>().enabled = false;
            item[0].GetComponent<Rigidbody>().useGravity = true;
            item[0].GetComponent<Collider>().isTrigger = false;
        }

        if (objectName.Equals("TestItem"))
        {
            item[0].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("TestItem"))
        {
            item[0].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E))
        {
            if(objectName.Equals("TestItem"))
            {
                item[0].GetComponent<Outline>().enabled = false;
                item[0].GetComponent<Rigidbody>().useGravity = false;
                item[0].GetComponent<Collider>().isTrigger = true;
                item[0].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                    Debug.Log(objectName);
                }
            }          
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            item[0].GetComponent<Outline>().enabled = false;
            item[0].GetComponent<Rigidbody>().useGravity = true;
            item[0].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }      
    }
}
