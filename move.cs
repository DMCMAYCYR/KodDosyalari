using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float hız;
    float i;
    private void Start()
    {
        Destroy(gameObject, 8);
    }
    private void FixedUpdate()
    {
        i = Random.Range(4, 16);
        transform.position += Vector3.left * i * Time.deltaTime;
    }
}
