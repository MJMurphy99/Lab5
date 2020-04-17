using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class myAgent : MonoBehaviour
{

    // Start is called before the first frame update

    public static Vector3[] path = new Vector3[0];

    private LineRenderer lr;
    NavMeshAgent myAgentAI;
    
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        myAgentAI = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        path = myAgentAI.path.corners;
        if (path != null && path.Length > 1)
        {
            lr.positionCount = path.Length;
            for (int i = 0; i < path.Length; i++)
            {
                lr.SetPosition(i, path[i]);
            }
        }
        
    }
}
