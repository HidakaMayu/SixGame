using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    GameObject[] target = null;
    NavMeshAgent nMesh;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Player");
        nMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nMesh.pathStatus != NavMeshPathStatus.PathInvalid && Player.hidden == true) //ƒvƒŒƒCƒ„[‚ª‰B‚ê‚Ä‚¢‚é‚Æ‚«‚Í’Ç‚í‚È‚¢
        {
            nMesh.SetDestination(target[0].transform.position);
        }
    }
}
