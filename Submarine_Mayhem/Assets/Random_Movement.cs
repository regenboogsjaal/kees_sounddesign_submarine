using UnityEngine;
using System.Collections;

//float MAX_STARTING_SPEED = 50;

public class Random_Movement : MonoBehaviour {

 void Start() {
         GetComponent<Rigidbody>().velocity = Random.insideUnitCircle * (0.5f + 0.5f * Random.value) * 50;
     }
}