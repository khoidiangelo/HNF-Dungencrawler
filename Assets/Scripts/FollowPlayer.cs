using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Rendering.FilterWindow;
using static UnityEngine.GraphicsBuffer;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float Max_Offset;
    public float speed;

    private void Start()
    {
        offset = transform.position - target.transform.position;
    }
    void Update()
    {
        Vector3 current_target = target.position + offset + (new Vector3(Movement.Instance.Direction.x, Movement.Instance.Direction.y, 0))* 2f;
        Mathf.Clamp(current_target.x, target.position.x - Max_Offset, target.position.x + Max_Offset);
        Mathf.Clamp(current_target.y, target.position.y - Max_Offset, target.position.y + Max_Offset);
        Mathf.Clamp(current_target.z, target.position.z - Max_Offset, target.position.z + Max_Offset);
        //Vector3 current_target = target.position + offset;
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, current_target, step);


    }

    
}
