using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetindicator : MonoBehaviour
{
    [SerializeField] Transform Target;

    void Update(){
        Target = FindObjectOfType<CreateObjects>().Box.transform;
        // Calculate distance
        var distance = Target.position - transform.position;
        // Calculate angle
        var angle = Mathf.Atan2(distance.y,distance.x) * Mathf.Rad2Deg;
        // Change rotation
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }
}
