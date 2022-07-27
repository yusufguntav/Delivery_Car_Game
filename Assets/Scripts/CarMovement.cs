using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
  public float MoveSpeed;
  [SerializeField] float SteerSpeed;


    private void Update() {
    
    float SteerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
    transform.Rotate(0,0,-SteerAmount);

    float MoveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
    transform.Translate(0,MoveAmount,0); 
  }

}
