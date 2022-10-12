using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject target = null;
    NavMeshAgent nMesh;
    void Start()
    {
        nMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.hidden == true)
        {
            nMesh.SetDestination(this.transform.position);
        }
        else if(nMesh.pathStatus != NavMeshPathStatus.PathInvalidÅ@&& Player.hidden == false)
        {
            nMesh.SetDestination(target.transform.position);
        }
    }
}
