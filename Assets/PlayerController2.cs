using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController2 : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    //public NavMeshAgent agent2;
    public GameObject cube;
    Vector3 mycubePos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mycubePos = cube.transform.position;
        agent.SetDestination(mycubePos);
        //agent2.SetDestination(mycubePos);
    }
}
