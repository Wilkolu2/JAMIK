using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PauseGun : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private GameObject projectileObject;
    [SerializeField] private float projectileSpeed = 100f;
    [SerializeField] private PickUp pickUp;
    [SerializeField] private TMP_Text ammoText;
    public int maxAmmo;
    public int currentAmmo;
    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmmo > maxAmmo)
        {
            currentAmmo = maxAmmo;
        }
        ammoText.text = currentAmmo.ToString() + "/" + maxAmmo.ToString();

        if(Input.GetMouseButtonDown(0) && pickUp.isPickingUp==false && currentAmmo>0) 
        {
            currentAmmo--;
            projectileObject = Instantiate(projectilePrefab);
            projectileObject.transform.position = this.transform.position;
            projectileObject.GetComponent<Rigidbody>().AddForce(mainCamera.transform.forward * projectileSpeed);
        }
        
    }

}
