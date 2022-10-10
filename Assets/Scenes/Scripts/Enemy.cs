using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject target = null;
    NavMeshAgent nMesh;
    // Start is called before the first frame update
    void Start()
    {
        nMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nMesh.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            nMesh.SetDestination(target.transform.position);
        }
    }
}
