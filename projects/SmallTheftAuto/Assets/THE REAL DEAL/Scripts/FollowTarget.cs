using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform Target;
    
    void Update()
    {
        Vector3 result = Vector3.Lerp(transform.position, Target.position, 0.1F);
        result.z = transform.position.z;
        transform.position = result;
    }
    
}
