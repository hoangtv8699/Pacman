using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostMove : MonoBehaviour
{
    public GameObject target;
    public Transform[] waypoints;
    public float speed = 0.3f;
    
    int cur = 0;
    Transform targetTransform;
    NavMeshAgent agent;
    private void Start()
    {
        
        agent = gameObject.GetComponent<NavMeshAgent>();
        targetTransform = target.transform;
    }

    private void Update()
    {
        if (targetTransform.position == transform.position)
        {
            targetTransform.position = target.transform.position;
        }
        agent.SetDestination(targetTransform.position);
    }
    private void FixedUpdate()
    {


        /*
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        
        else cur = (cur + 1) % waypoints.Length;
        */

        Vector2 dir = waypoints[cur].position - transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pacman")
            Destroy(collision.gameObject);
    }
}
