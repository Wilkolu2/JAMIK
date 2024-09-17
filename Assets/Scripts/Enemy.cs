using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Enemy : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && GetComponent<EnemyPathfinding>().isPurist)
        {
            
            Debug.Log("you dead");
            Destroy(this.gameObject);
            
        }
    }
}
