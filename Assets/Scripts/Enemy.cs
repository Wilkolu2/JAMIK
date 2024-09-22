using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;

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
            player.isDead = true;
            Debug.Log("you dead");
            Destroy(this.gameObject);
            
        }
    }
}
