using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGun : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private GameObject projectileObject;
    [SerializeField] private float projectileSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
        //RaycastHit raycastHit;

        if(Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("strzal");
            projectileObject = Instantiate(projectilePrefab);
            projectileObject.transform.position = this.transform.position;
            projectileObject.GetComponent<Rigidbody>().AddForce(mainCamera.transform.forward * projectileSpeed);
        }
        
    }

}
