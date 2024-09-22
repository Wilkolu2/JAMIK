using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject bolec1;
    [SerializeField] private GameObject bolec2;
    [SerializeField] private GameObject bolec3;

    [SerializeField] private GameObject maszyna1;
    [SerializeField] private GameObject maszyna2;
    [SerializeField] private GameObject maszyna3;

    public int bolce;
    // Start is called before the first frame update
    void Start()
    {
        bolce = 0;
        maszyna1.SetActive(true);
        maszyna2.SetActive(false);
        maszyna3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(bolce == 3)
        {           
            SceneManager.LoadScene("MainMenu");
        }

        if(bolce == 1)
        {
            maszyna1.SetActive(false);
            maszyna2.SetActive(true);
        }

        if(bolce == 2)
        {
            maszyna2.SetActive(false);
            maszyna3.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == bolec1)
        {
            Destroy(bolec1);
            bolce++;
        }
        else if(other.gameObject == bolec2)
        {
            Destroy(bolec2);
            bolce++;
        }
        else if (other.gameObject == bolec3)
        {
            Destroy(bolec3);
            bolce++;
        }
    }
}
