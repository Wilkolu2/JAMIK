using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float visionRange = 3f;
    public bool isPurist = false;
    [SerializeField] private Transform[] waypoint = new Transform[2];
    private float playerDistance;
    private PlayerMovement playerMovement;
    private NavMeshAgent agent;
    private int waypointId = 0;
    private bool isPaused = false;

    public float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(this.transform.position, player.transform.position);

        if(isPaused)
        {
            isPurist = false;
            GetComponent<Rigidbody>().Sleep();
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<Collider>().enabled = false;
            
            if(timer > 0)
            {
                timer -= Time.deltaTime;
            }
            
            if(timer < 0)
            {
                isPaused = false;
            }
        }
        else if(isPaused == false)
        {
            GetComponent<Rigidbody>().WakeUp();
            GetComponent<NavMeshAgent>().enabled = true;
            GetComponent<Collider>().enabled = true;
        }

        if (waypointId == 0)
        {
            agent.SetDestination(waypoint[waypointId].position);
        }
        else if (waypointId == 1)
        {
            agent.SetDestination(waypoint[waypointId].position);
        }

        if ((playerMovement.currentMovementSpeed>0 && playerMovement.currentMovementSpeed<15f) && playerDistance <= visionRange)
        {
            isPurist = true;
        }

        if (playerDistance<=visionRange && isPurist)
        {
            GetComponent<Collider>().isTrigger = false;
            //agent.isStopped = false;
            agent.SetDestination(player.transform.position);            
        }
        else if(isPurist==false)
        {           
            GetComponent<Collider>().isTrigger = true;
            //agent.isStopped = true;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Waypoint1"))
        {
            waypointId = 1;
        }
        else if(other.gameObject.CompareTag("Waypoint2"))
        {
            waypointId= 0;
        }

        if(other.gameObject.CompareTag("Projectile"))
        {
            isPaused = true;
            timer = 5f;
        }
    }
}
