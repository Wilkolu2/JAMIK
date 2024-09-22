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
    [SerializeField] private GameObject[] item = new GameObject[500];
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

        Debug.Log(objectName);

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

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
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
        else if(Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[0].GetComponent<Outline>().enabled = false;
            item[0].GetComponent<Rigidbody>().useGravity = true;
            item[0].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel40"))
        {
            item[40].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel40"))
        {
            item[40].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel40"))
            {
                item[40].GetComponent<Outline>().enabled = false;
                item[40].GetComponent<Rigidbody>().useGravity = false;
                item[40].GetComponent<Collider>().isTrigger = true;
                item[40].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[40].GetComponent<Outline>().enabled = false;
            item[40].GetComponent<Rigidbody>().useGravity = true;
            item[40].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel41"))
        {
            item[41].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel41"))
        {
            item[41].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel41"))
            {
                item[41].GetComponent<Outline>().enabled = false;
                item[41].GetComponent<Rigidbody>().useGravity = false;
                item[41].GetComponent<Collider>().isTrigger = true;
                item[41].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[41].GetComponent<Outline>().enabled = false;
            item[41].GetComponent<Rigidbody>().useGravity = true;
            item[41].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel42"))
        {
            item[42].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel42"))
        {
            item[42].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel42"))
            {
                item[42].GetComponent<Outline>().enabled = false;
                item[42].GetComponent<Rigidbody>().useGravity = false;
                item[42].GetComponent<Collider>().isTrigger = true;
                item[42].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[42].GetComponent<Outline>().enabled = false;
            item[42].GetComponent<Rigidbody>().useGravity = true;
            item[42].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel43"))
        {
            item[43].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel43"))
        {
            item[43].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel43"))
            {
                item[43].GetComponent<Outline>().enabled = false;
                item[43].GetComponent<Rigidbody>().useGravity = false;
                item[43].GetComponent<Collider>().isTrigger = true;
                item[43].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[43].GetComponent<Outline>().enabled = false;
            item[43].GetComponent<Rigidbody>().useGravity = true;
            item[43].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel44"))
        {
            item[44].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel44"))
        {
            item[44].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel44"))
            {
                item[44].GetComponent<Outline>().enabled = false;
                item[44].GetComponent<Rigidbody>().useGravity = false;
                item[44].GetComponent<Collider>().isTrigger = true;
                item[44].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[44].GetComponent<Outline>().enabled = false;
            item[44].GetComponent<Rigidbody>().useGravity = true;
            item[44].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel45"))
        {
            item[45].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel45"))
        {
            item[45].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel45"))
            {
                item[45].GetComponent<Outline>().enabled = false;
                item[45].GetComponent<Rigidbody>().useGravity = false;
                item[45].GetComponent<Collider>().isTrigger = true;
                item[45].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[45].GetComponent<Outline>().enabled = false;
            item[45].GetComponent<Rigidbody>().useGravity = true;
            item[45].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel46"))
        {
            item[46].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel46"))
        {
            item[46].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel46"))
            {
                item[46].GetComponent<Outline>().enabled = false;
                item[46].GetComponent<Rigidbody>().useGravity = false;
                item[46].GetComponent<Collider>().isTrigger = true;
                item[46].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[46].GetComponent<Outline>().enabled = false;
            item[46].GetComponent<Rigidbody>().useGravity = true;
            item[46].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel47"))
        {
            item[47].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel47"))
        {
            item[47].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel47"))
            {
                item[47].GetComponent<Outline>().enabled = false;
                item[47].GetComponent<Rigidbody>().useGravity = false;
                item[47].GetComponent<Collider>().isTrigger = true;
                item[47].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[47].GetComponent<Outline>().enabled = false;
            item[47].GetComponent<Rigidbody>().useGravity = true;
            item[47].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel48"))
        {
            item[48].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel48"))
        {
            item[48].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel48"))
            {
                item[48].GetComponent<Outline>().enabled = false;
                item[48].GetComponent<Rigidbody>().useGravity = false;
                item[48].GetComponent<Collider>().isTrigger = true;
                item[48].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[48].GetComponent<Outline>().enabled = false;
            item[48].GetComponent<Rigidbody>().useGravity = true;
            item[48].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel49"))
        {
            item[49].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel49"))
        {
            item[49].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel49"))
            {
                item[49].GetComponent<Outline>().enabled = false;
                item[49].GetComponent<Rigidbody>().useGravity = false;
                item[49].GetComponent<Collider>().isTrigger = true;
                item[49].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[49].GetComponent<Outline>().enabled = false;
            item[49].GetComponent<Rigidbody>().useGravity = true;
            item[49].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel50"))
        {
            item[50].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel50"))
        {
            item[50].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel50"))
            {
                item[50].GetComponent<Outline>().enabled = false;
                item[50].GetComponent<Rigidbody>().useGravity = false;
                item[50].GetComponent<Collider>().isTrigger = true;
                item[50].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[50].GetComponent<Outline>().enabled = false;
            item[50].GetComponent<Rigidbody>().useGravity = true;
            item[50].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel51"))
        {
            item[51].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel51"))
        {
            item[51].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel51"))
            {
                item[51].GetComponent<Outline>().enabled = false;
                item[51].GetComponent<Rigidbody>().useGravity = false;
                item[51].GetComponent<Collider>().isTrigger = true;
                item[51].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[51].GetComponent<Outline>().enabled = false;
            item[51].GetComponent<Rigidbody>().useGravity = true;
            item[51].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel52"))
        {
            item[52].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel52"))
        {
            item[52].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel52"))
            {
                item[52].GetComponent<Outline>().enabled = false;
                item[52].GetComponent<Rigidbody>().useGravity = false;
                item[52].GetComponent<Collider>().isTrigger = true;
                item[52].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[52].GetComponent<Outline>().enabled = false;
            item[52].GetComponent<Rigidbody>().useGravity = true;
            item[52].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel53"))
        {
            item[53].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel53"))
        {
            item[53].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel53"))
            {
                item[53].GetComponent<Outline>().enabled = false;
                item[53].GetComponent<Rigidbody>().useGravity = false;
                item[53].GetComponent<Collider>().isTrigger = true;
                item[53].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[53].GetComponent<Outline>().enabled = false;
            item[53].GetComponent<Rigidbody>().useGravity = true;
            item[53].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel54"))
        {
            item[54].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel54"))
        {
            item[54].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel54"))
            {
                item[54].GetComponent<Outline>().enabled = false;
                item[54].GetComponent<Rigidbody>().useGravity = false;
                item[54].GetComponent<Collider>().isTrigger = true;
                item[54].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[54].GetComponent<Outline>().enabled = false;
            item[54].GetComponent<Rigidbody>().useGravity = true;
            item[54].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel55"))
        {
            item[55].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel55"))
        {
            item[55].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel55"))
            {
                item[55].GetComponent<Outline>().enabled = false;
                item[55].GetComponent<Rigidbody>().useGravity = false;
                item[55].GetComponent<Collider>().isTrigger = true;
                item[55].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[55].GetComponent<Outline>().enabled = false;
            item[55].GetComponent<Rigidbody>().useGravity = true;
            item[55].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel56"))
        {
            item[56].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel56"))
        {
            item[56].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel56"))
            {
                item[56].GetComponent<Outline>().enabled = false;
                item[56].GetComponent<Rigidbody>().useGravity = false;
                item[56].GetComponent<Collider>().isTrigger = true;
                item[56].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[56].GetComponent<Outline>().enabled = false;
            item[56].GetComponent<Rigidbody>().useGravity = true;
            item[56].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel57"))
        {
            item[57].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel57"))
        {
            item[57].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel57"))
            {
                item[57].GetComponent<Outline>().enabled = false;
                item[57].GetComponent<Rigidbody>().useGravity = false;
                item[57].GetComponent<Collider>().isTrigger = true;
                item[57].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[57].GetComponent<Outline>().enabled = false;
            item[57].GetComponent<Rigidbody>().useGravity = true;
            item[57].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel58"))
        {
            item[58].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel58"))
        {
            item[58].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel58"))
            {
                item[58].GetComponent<Outline>().enabled = false;
                item[58].GetComponent<Rigidbody>().useGravity = false;
                item[58].GetComponent<Collider>().isTrigger = true;
                item[58].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[58].GetComponent<Outline>().enabled = false;
            item[58].GetComponent<Rigidbody>().useGravity = true;
            item[58].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel59"))
        {
            item[59].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel59"))
        {
            item[59].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel59"))
            {
                item[59].GetComponent<Outline>().enabled = false;
                item[59].GetComponent<Rigidbody>().useGravity = false;
                item[59].GetComponent<Collider>().isTrigger = true;
                item[59].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[59].GetComponent<Outline>().enabled = false;
            item[59].GetComponent<Rigidbody>().useGravity = true;
            item[59].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel60"))
        {
            item[60].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel60"))
        {
            item[60].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel60"))
            {
                item[60].GetComponent<Outline>().enabled = false;
                item[60].GetComponent<Rigidbody>().useGravity = false;
                item[60].GetComponent<Collider>().isTrigger = true;
                item[60].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[60].GetComponent<Outline>().enabled = false;
            item[60].GetComponent<Rigidbody>().useGravity = true;
            item[60].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        
        //////////
        if (objectName.Equals("Barrel62"))
        {
            item[62].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel62"))
        {
            item[62].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel62"))
            {
                item[62].GetComponent<Outline>().enabled = false;
                item[62].GetComponent<Rigidbody>().useGravity = false;
                item[62].GetComponent<Collider>().isTrigger = true;
                item[62].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[62].GetComponent<Outline>().enabled = false;
            item[62].GetComponent<Rigidbody>().useGravity = true;
            item[62].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel63"))
        {
            item[63].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel63"))
        {
            item[63].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel63"))
            {
                item[63].GetComponent<Outline>().enabled = false;
                item[63].GetComponent<Rigidbody>().useGravity = false;
                item[63].GetComponent<Collider>().isTrigger = true;
                item[63].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[63].GetComponent<Outline>().enabled = false;
            item[63].GetComponent<Rigidbody>().useGravity = true;
            item[63].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel64"))
        {
            item[64].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel64"))
        {
            item[64].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel64"))
            {
                item[64].GetComponent<Outline>().enabled = false;
                item[64].GetComponent<Rigidbody>().useGravity = false;
                item[64].GetComponent<Collider>().isTrigger = true;
                item[64].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[64].GetComponent<Outline>().enabled = false;
            item[64].GetComponent<Rigidbody>().useGravity = true;
            item[64].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel65"))
        {
            item[65].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel65"))
        {
            item[65].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel65"))
            {
                item[65].GetComponent<Outline>().enabled = false;
                item[65].GetComponent<Rigidbody>().useGravity = false;
                item[65].GetComponent<Collider>().isTrigger = true;
                item[65].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[65].GetComponent<Outline>().enabled = false;
            item[65].GetComponent<Rigidbody>().useGravity = true;
            item[65].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel66"))
        {
            item[66].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel66"))
        {
            item[66].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel66"))
            {
                item[66].GetComponent<Outline>().enabled = false;
                item[66].GetComponent<Rigidbody>().useGravity = false;
                item[66].GetComponent<Collider>().isTrigger = true;
                item[66].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[66].GetComponent<Outline>().enabled = false;
            item[66].GetComponent<Rigidbody>().useGravity = true;
            item[66].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
       
        //////////
        if (objectName.Equals("Barrel68"))
        {
            item[68].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel68"))
        {
            item[68].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel68"))
            {
                item[68].GetComponent<Outline>().enabled = false;
                item[68].GetComponent<Rigidbody>().useGravity = false;
                item[68].GetComponent<Collider>().isTrigger = true;
                item[68].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[68].GetComponent<Outline>().enabled = false;
            item[68].GetComponent<Rigidbody>().useGravity = true;
            item[68].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel69"))
        {
            item[69].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel69"))
        {
            item[69].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel69"))
            {
                item[69].GetComponent<Outline>().enabled = false;
                item[69].GetComponent<Rigidbody>().useGravity = false;
                item[69].GetComponent<Collider>().isTrigger = true;
                item[69].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[69].GetComponent<Outline>().enabled = false;
            item[69].GetComponent<Rigidbody>().useGravity = true;
            item[69].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Barrel70"))
        {
            item[70].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel70"))
        {
            item[70].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel70"))
            {
                item[70].GetComponent<Outline>().enabled = false;
                item[70].GetComponent<Rigidbody>().useGravity = false;
                item[70].GetComponent<Collider>().isTrigger = true;
                item[70].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[70].GetComponent<Outline>().enabled = false;
            item[70].GetComponent<Rigidbody>().useGravity = true;
            item[70].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        ////////
        if (objectName.Equals("Barrel71"))
        {
            item[71].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel71"))
        {
            item[71].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel71"))
            {
                item[71].GetComponent<Outline>().enabled = false;
                item[71].GetComponent<Rigidbody>().useGravity = false;
                item[71].GetComponent<Collider>().isTrigger = true;
                item[71].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[71].GetComponent<Outline>().enabled = false;
            item[71].GetComponent<Rigidbody>().useGravity = true;
            item[71].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        ///////
        if (objectName.Equals("Barrel72"))
        {
            item[72].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Barrel72"))
        {
            item[72].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Barrel72"))
            {
                item[72].GetComponent<Outline>().enabled = false;
                item[72].GetComponent<Rigidbody>().useGravity = false;
                item[72].GetComponent<Collider>().isTrigger = true;
                item[72].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[72].GetComponent<Outline>().enabled = false;
            item[72].GetComponent<Rigidbody>().useGravity = true;
            item[72].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope73"))
        {
            item[73].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope73"))
        {
            item[73].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope73"))
            {
                item[73].GetComponent<Outline>().enabled = false;
                item[73].GetComponent<Rigidbody>().useGravity = false;
                item[73].GetComponent<Collider>().isTrigger = true;
                item[73].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[73].GetComponent<Outline>().enabled = false;
            item[73].GetComponent<Rigidbody>().useGravity = true;
            item[73].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope73"))
        {
            item[73].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope73"))
        {
            item[73].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope73"))
            {
                item[73].GetComponent<Outline>().enabled = false;
                item[73].GetComponent<Rigidbody>().useGravity = false;
                item[73].GetComponent<Collider>().isTrigger = true;
                item[73].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[73].GetComponent<Outline>().enabled = false;
            item[73].GetComponent<Rigidbody>().useGravity = true;
            item[73].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        } //////////
        if (objectName.Equals("Microscope74"))
        {
            item[74].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope74"))
        {
            item[74].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope74"))
            {
                item[74].GetComponent<Outline>().enabled = false;
                item[74].GetComponent<Rigidbody>().useGravity = false;
                item[74].GetComponent<Collider>().isTrigger = true;
                item[74].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[74].GetComponent<Outline>().enabled = false;
            item[74].GetComponent<Rigidbody>().useGravity = true;
            item[74].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope75"))
        {
            item[75].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope75"))
        {
            item[75].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope75"))
            {
                item[75].GetComponent<Outline>().enabled = false;
                item[75].GetComponent<Rigidbody>().useGravity = false;
                item[75].GetComponent<Collider>().isTrigger = true;
                item[75].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[75].GetComponent<Outline>().enabled = false;
            item[75].GetComponent<Rigidbody>().useGravity = true;
            item[75].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope76"))
        {
            item[76].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope76"))
        {
            item[76].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope76"))
            {
                item[76].GetComponent<Outline>().enabled = false;
                item[76].GetComponent<Rigidbody>().useGravity = false;
                item[76].GetComponent<Collider>().isTrigger = true;
                item[76].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[76].GetComponent<Outline>().enabled = false;
            item[76].GetComponent<Rigidbody>().useGravity = true;
            item[76].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope77"))
        {
            item[77].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope77"))
        {
            item[77].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope77"))
            {
                item[77].GetComponent<Outline>().enabled = false;
                item[77].GetComponent<Rigidbody>().useGravity = false;
                item[77].GetComponent<Collider>().isTrigger = true;
                item[77].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[77].GetComponent<Outline>().enabled = false;
            item[77].GetComponent<Rigidbody>().useGravity = true;
            item[77].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope78"))
        {
            item[78].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope78"))
        {
            item[78].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope78"))
            {
                item[78].GetComponent<Outline>().enabled = false;
                item[78].GetComponent<Rigidbody>().useGravity = false;
                item[78].GetComponent<Collider>().isTrigger = true;
                item[78].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[78].GetComponent<Outline>().enabled = false;
            item[78].GetComponent<Rigidbody>().useGravity = true;
            item[78].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope79"))
        {
            item[79].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope79"))
        {
            item[79].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope79"))
            {
                item[79].GetComponent<Outline>().enabled = false;
                item[79].GetComponent<Rigidbody>().useGravity = false;
                item[79].GetComponent<Collider>().isTrigger = true;
                item[79].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[79].GetComponent<Outline>().enabled = false;
            item[79].GetComponent<Rigidbody>().useGravity = true;
            item[79].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope80"))
        {
            item[80].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope80"))
        {
            item[80].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope80"))
            {
                item[80].GetComponent<Outline>().enabled = false;
                item[80].GetComponent<Rigidbody>().useGravity = false;
                item[80].GetComponent<Collider>().isTrigger = true;
                item[80].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[80].GetComponent<Outline>().enabled = false;
            item[80].GetComponent<Rigidbody>().useGravity = true;
            item[80].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope81"))
        {
            item[81].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope81"))
        {
            item[81].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope81"))
            {
                item[81].GetComponent<Outline>().enabled = false;
                item[81].GetComponent<Rigidbody>().useGravity = false;
                item[81].GetComponent<Collider>().isTrigger = true;
                item[81].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[81].GetComponent<Outline>().enabled = false;
            item[81].GetComponent<Rigidbody>().useGravity = true;
            item[81].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope82"))
        {
            item[82].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope82"))
        {
            item[82].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope82"))
            {
                item[82].GetComponent<Outline>().enabled = false;
                item[82].GetComponent<Rigidbody>().useGravity = false;
                item[82].GetComponent<Collider>().isTrigger = true;
                item[82].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[82].GetComponent<Outline>().enabled = false;
            item[82].GetComponent<Rigidbody>().useGravity = true;
            item[82].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope83"))
        {
            item[83].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope83"))
        {
            item[83].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope83"))
            {
                item[83].GetComponent<Outline>().enabled = false;
                item[83].GetComponent<Rigidbody>().useGravity = false;
                item[83].GetComponent<Collider>().isTrigger = true;
                item[83].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[83].GetComponent<Outline>().enabled = false;
            item[83].GetComponent<Rigidbody>().useGravity = true;
            item[83].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope84"))
        {
            item[84].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope84"))
        {
            item[84].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope84"))
            {
                item[84].GetComponent<Outline>().enabled = false;
                item[84].GetComponent<Rigidbody>().useGravity = false;
                item[84].GetComponent<Collider>().isTrigger = true;
                item[84].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[84].GetComponent<Outline>().enabled = false;
            item[84].GetComponent<Rigidbody>().useGravity = true;
            item[84].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope85"))
        {
            item[85].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope85"))
        {
            item[85].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope85"))
            {
                item[85].GetComponent<Outline>().enabled = false;
                item[85].GetComponent<Rigidbody>().useGravity = false;
                item[85].GetComponent<Collider>().isTrigger = true;
                item[85].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[85].GetComponent<Outline>().enabled = false;
            item[85].GetComponent<Rigidbody>().useGravity = true;
            item[85].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope86"))
        {
            item[86].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope86"))
        {
            item[86].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope86"))
            {
                item[86].GetComponent<Outline>().enabled = false;
                item[86].GetComponent<Rigidbody>().useGravity = false;
                item[86].GetComponent<Collider>().isTrigger = true;
                item[86].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[86].GetComponent<Outline>().enabled = false;
            item[86].GetComponent<Rigidbody>().useGravity = true;
            item[86].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope87"))
        {
            item[87].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope87"))
        {
            item[87].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope87"))
            {
                item[87].GetComponent<Outline>().enabled = false;
                item[87].GetComponent<Rigidbody>().useGravity = false;
                item[87].GetComponent<Collider>().isTrigger = true;
                item[87].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[87].GetComponent<Outline>().enabled = false;
            item[87].GetComponent<Rigidbody>().useGravity = true;
            item[87].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope88"))
        {
            item[88].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope88"))
        {
            item[88].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope88"))
            {
                item[88].GetComponent<Outline>().enabled = false;
                item[88].GetComponent<Rigidbody>().useGravity = false;
                item[88].GetComponent<Collider>().isTrigger = true;
                item[88].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[88].GetComponent<Outline>().enabled = false;
            item[88].GetComponent<Rigidbody>().useGravity = true;
            item[88].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope89"))
        {
            item[89].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope89"))
        {
            item[89].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope89"))
            {
                item[89].GetComponent<Outline>().enabled = false;
                item[89].GetComponent<Rigidbody>().useGravity = false;
                item[89].GetComponent<Collider>().isTrigger = true;
                item[89].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[89].GetComponent<Outline>().enabled = false;
            item[89].GetComponent<Rigidbody>().useGravity = true;
            item[89].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope90"))
        {
            item[90].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope90"))
        {
            item[90].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope90"))
            {
                item[90].GetComponent<Outline>().enabled = false;
                item[90].GetComponent<Rigidbody>().useGravity = false;
                item[90].GetComponent<Collider>().isTrigger = true;
                item[90].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[90].GetComponent<Outline>().enabled = false;
            item[90].GetComponent<Rigidbody>().useGravity = true;
            item[90].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope91"))
        {
            item[91].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope91"))
        {
            item[91].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope91"))
            {
                item[91].GetComponent<Outline>().enabled = false;
                item[91].GetComponent<Rigidbody>().useGravity = false;
                item[91].GetComponent<Collider>().isTrigger = true;
                item[91].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[91].GetComponent<Outline>().enabled = false;
            item[91].GetComponent<Rigidbody>().useGravity = true;
            item[91].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope92"))
        {
            item[92].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope92"))
        {
            item[92].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope92"))
            {
                item[92].GetComponent<Outline>().enabled = false;
                item[92].GetComponent<Rigidbody>().useGravity = false;
                item[92].GetComponent<Collider>().isTrigger = true;
                item[92].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[92].GetComponent<Outline>().enabled = false;
            item[92].GetComponent<Rigidbody>().useGravity = true;
            item[92].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope93"))
        {
            item[93].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope93"))
        {
            item[93].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope93"))
            {
                item[93].GetComponent<Outline>().enabled = false;
                item[93].GetComponent<Rigidbody>().useGravity = false;
                item[93].GetComponent<Collider>().isTrigger = true;
                item[93].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[93].GetComponent<Outline>().enabled = false;
            item[93].GetComponent<Rigidbody>().useGravity = true;
            item[93].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Microscope94"))
        {
            item[94].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Microscope94"))
        {
            item[94].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Microscope94"))
            {
                item[94].GetComponent<Outline>().enabled = false;
                item[94].GetComponent<Rigidbody>().useGravity = false;
                item[94].GetComponent<Collider>().isTrigger = true;
                item[94].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[94].GetComponent<Outline>().enabled = false;
            item[94].GetComponent<Rigidbody>().useGravity = true;
            item[94].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        
        //////////
        if (objectName.Equals("Bolec1"))
        {
            item[95].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Bolec1"))
        {
            item[95].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Bolec1"))
            {
                item[95].GetComponent<Outline>().enabled = false;
                item[95].GetComponent<Rigidbody>().useGravity = false;
                item[95].GetComponent<Collider>().isTrigger = true;
                item[95].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[95].GetComponent<Outline>().enabled = false;
            item[95].GetComponent<Rigidbody>().useGravity = true;
            item[95].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        } //////////
        if (objectName.Equals("Bolec2"))
        {
            item[96].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Bolec2"))
        {
            item[96].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Bolec2"))
            {
                item[96].GetComponent<Outline>().enabled = false;
                item[96].GetComponent<Rigidbody>().useGravity = false;
                item[96].GetComponent<Collider>().isTrigger = true;
                item[96].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[96].GetComponent<Outline>().enabled = false;
            item[96].GetComponent<Rigidbody>().useGravity = true;
            item[96].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        if (objectName.Equals("Bolec3"))
        {
            item[97].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("Bolec3"))
        {
            item[97].GetComponent<Outline>().enabled = false;
        }

        if (objectName != null && Input.GetKey(KeyCode.E) && isPaused == false && pauseGun.isReloading == false)
        {
            isPickingUp = true;
            if (objectName.Equals("Bolec3"))
            {
                item[97].GetComponent<Outline>().enabled = false;
                item[97].GetComponent<Rigidbody>().useGravity = false;
                item[97].GetComponent<Collider>().isTrigger = true;
                item[97].transform.position = pickUpPoint.position;
                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    objectName = raycastHit.collider.gameObject.name;
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) || (Input.GetKey(KeyCode.E) && pauseGun.isReloading == true))
        {
            isPickingUp = false;
            item[97].GetComponent<Outline>().enabled = false;
            item[97].GetComponent<Rigidbody>().useGravity = true;
            item[97].GetComponent<Collider>().isTrigger = false;
            objectName = null;
        }
        //////////
        //TestAmmo

        if (objectName.Equals("AmmoPack1"))
        {
            item[1].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack1"))
        {
            item[1].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack1"))
            {
                pauseGun.magazines++;
                item[1].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        ////
        if (objectName.Equals("AmmoPack2"))
        {
            item[2].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack2"))
        {
            item[2].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack2"))
            {
                pauseGun.magazines++;
                item[2].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        //////////
        if (objectName.Equals("AmmoPack3"))
        {
            item[3].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack3"))
        {
            item[3].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack3"))
            {
                pauseGun.magazines++;
                item[3].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack4"))
        {
            item[4].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack4"))
        {
            item[4].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack4"))
            {
                pauseGun.magazines++;
                item[4].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack5"))
        {
            item[5].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack5"))
        {
            item[5].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack5"))
            {
                pauseGun.magazines++;
                item[5].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack6"))
        {
            item[6].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack6"))
        {
            item[6].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack6"))
            {
                pauseGun.magazines++;
                item[6].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack7"))
        {
            item[7].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack7"))
        {
            item[7].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack7"))
            {
                pauseGun.magazines++;
                item[7].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack8"))
        {
            item[8].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack8"))
        {
            item[8].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack8"))
            {
                pauseGun.magazines++;
                item[8].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack9"))
        {
            item[9].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack9"))
        {
            item[9].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack9"))
            {
                pauseGun.magazines++;
                item[9].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack10"))
        {
            item[10].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack10"))
        {
            item[10].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack10"))
            {
                pauseGun.magazines++;
                item[10].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack11"))
        {
            item[11].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack11"))
        {
            item[11].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack11"))
            {
                pauseGun.magazines++;
                item[11].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack12"))
        {
            item[12].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack12"))
        {
            item[12].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack12"))
            {
                pauseGun.magazines++;
                item[12].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack13"))
        {
            item[13].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack13"))
        {
            item[13].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack13"))
            {
                pauseGun.magazines++;
                item[13].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack14"))
        {
            item[14].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack14"))
        {
            item[14].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack14"))
            {
                pauseGun.magazines++;
                item[14].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack15"))
        {
            item[15].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack15"))
        {
            item[15].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack15"))
            {
                pauseGun.magazines++;
                item[15].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack16"))
        {
            item[16].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack16"))
        {
            item[16].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack16"))
            {
                pauseGun.magazines++;
                item[16].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack17"))
        {
            item[17].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack17"))
        {
            item[17].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack17"))
            {
                pauseGun.magazines++;
                item[17].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack18"))
        {
            item[18].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack18"))
        {
            item[18].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack18"))
            {
                pauseGun.magazines++;
                item[18].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack19"))
        {
            item[19].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack19"))
        {
            item[19].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack19"))
            {
                pauseGun.magazines++;
                item[19].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack20"))
        {
            item[20].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack20"))
        {
            item[20].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack20"))
            {
                pauseGun.magazines++;
                item[20].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack21"))
        {
            item[21].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack21"))
        {
            item[21].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack21"))
            {
                pauseGun.magazines++;
                item[21].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack22"))
        {
            item[22].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack22"))
        {
            item[22].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack22"))
            {
                pauseGun.magazines++;
                item[22].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack23"))
        {
            item[23].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack23"))
        {
            item[23].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack23"))
            {
                pauseGun.magazines++;
                item[23].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack24"))
        {
            item[24].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack24"))
        {
            item[24].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack24"))
            {
                pauseGun.magazines++;
                item[24].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack25"))
        {
            item[25].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack25"))
        {
            item[25].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack25"))
            {
                pauseGun.magazines++;
                item[25].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack26"))
        {
            item[26].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack26"))
        {
            item[26].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack26"))
            {
                pauseGun.magazines++;
                item[26].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack27"))
        {
            item[27].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack27"))
        {
            item[27].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack27"))
            {
                pauseGun.magazines++;
                item[27].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack28"))
        {
            item[28].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack28"))
        {
            item[28].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack28"))
            {
                pauseGun.magazines++;
                item[28].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack29"))
        {
            item[29].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack29"))
        {
            item[29].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack29"))
            {
                pauseGun.magazines++;
                item[29].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack30"))
        {
            item[30].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack30"))
        {
            item[30].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack30"))
            {
                pauseGun.magazines++;
                item[30].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack31"))
        {
            item[31].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack31"))
        {
            item[31].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack31"))
            {
                pauseGun.magazines++;
                item[31].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack32"))
        {
            item[32].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack32"))
        {
            item[32].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack32"))
            {
                pauseGun.magazines++;
                item[32].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack33"))
        {
            item[33].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack33"))
        {
            item[33].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack33"))
            {
                pauseGun.magazines++;
                item[33].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack34"))
        {
            item[34].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack34"))
        {
            item[34].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack34"))
            {
                pauseGun.magazines++;
                item[34].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack35"))
        {
            item[35].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack35"))
        {
            item[35].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack35"))
            {
                pauseGun.magazines++;
                item[35].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack36"))
        {
            item[36].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack36"))
        {
            item[36].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack36"))
            {
                pauseGun.magazines++;
                item[36].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack37"))
        {
            item[37].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack37"))
        {
            item[37].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack37"))
            {
                pauseGun.magazines++;
                item[37].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack38"))
        {
            item[38].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack38"))
        {
            item[38].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack38"))
            {
                pauseGun.magazines++;
                item[38].SetActive(false);
                isPickingUp = false;
                objectName = null;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            objectName = null;
        }
        /////////
        if (objectName.Equals("AmmoPack39"))
        {
            item[39].GetComponent<Outline>().enabled = true;
        }
        else if (!objectName.Equals("AmmoPack39"))
        {
            item[39].GetComponent<Outline>().enabled = false;
        }
        if (objectName != null && Input.GetKey(KeyCode.E) && pauseGun.isReloading == false)
        {
            if (objectName.Equals("AmmoPack39"))
            {
                pauseGun.magazines++;
                item[39].SetActive(false);
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
