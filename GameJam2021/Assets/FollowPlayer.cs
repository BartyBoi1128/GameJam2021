using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;
    NavMeshAgent self;

    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        self.SetDestination(target.position);
    }
}
