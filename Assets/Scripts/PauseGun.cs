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
    [SerializeField] private TMP_Text magazinesText;
    [SerializeField] private Image reloadCircle;
    [SerializeField] private float reloadTimer = 2f;
    [SerializeField] private PlayerMovement player;
    public bool isReloading = false;
    public int maxAmmo;
    public int currentAmmo;
    public int magazines;
    // Start is called before the first frame update
    void Start()
    {
        magazines = 0;
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {

        ammoText.text = currentAmmo.ToString() + "/" + maxAmmo.ToString();
        magazinesText.text = "x" + magazines.ToString();

        if(Input.GetMouseButtonDown(0) && pickUp.isPickingUp==false && currentAmmo>0 && isReloading==false && player.isDead==false) 
        {
            currentAmmo--;
            projectileObject = Instantiate(projectilePrefab);
            projectileObject.transform.position = this.transform.position;
            projectileObject.GetComponent<Rigidbody>().AddForce(mainCamera.transform.forward * projectileSpeed);
        }
        
        if(Input.GetKeyDown(KeyCode.R) && magazines > 0 && isReloading == false && player.isDead==false)
        {
            isReloading = true;  
        }

        if(isReloading)
        {
            reloadCircle.fillAmount = reloadTimer / 2f;
            reloadTimer -= Time.deltaTime;
            if(reloadTimer <= 0)
            {
                magazines--;
                currentAmmo = maxAmmo;
                reloadTimer = 2f;
                isReloading = false;
            }
        }
    }

}
