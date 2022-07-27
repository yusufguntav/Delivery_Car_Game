using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] float offset = 1;
    void LateUpdate()
    {
        transform.position = Player.transform.position - new Vector3(0,0,offset);
    }
}
