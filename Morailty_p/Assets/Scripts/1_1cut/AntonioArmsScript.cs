using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntonioArmsScript : MonoBehaviour
{
        public float speed;
    // Start is called before the first frame update
   /* void Start()
    {
         public Vector3 targetPosition = new Vector3(-2, -4, 0);
    transform.position = targetPositon;
    }
   */
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-1.5f, 0.7f, 0), Time.deltaTime * speed);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-4, 0, 0), Time.deltaTime * 4);
    }
}