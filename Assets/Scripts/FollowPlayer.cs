using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.transform.position;
    }
    void Update()
    {
        transform.position = target.transform.position + offset;
        
    }

    
}
