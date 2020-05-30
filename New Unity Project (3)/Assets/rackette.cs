using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rackette : MonoBehaviour
{
// Mouvement Speed  
public float speed = 150;
void FixedUpdate () {
 // Get Horizontal Input   
float h = Input.GetAxisRaw("Horizontal");


// Set Velocity(mouvement direction * speed)
GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed * Time.deltaTime;
}
}
