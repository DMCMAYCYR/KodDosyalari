using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class zıpla : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    float zıplaBekle;

    public Text zıplaSure;
  
   
    void Start()
    {
        zıplaBekle = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (zıplaBekle<=0 && Input.GetMouseButtonDown(0))
        {
            
           rb2d.velocity = Vector2.up * velocity;
           zıplaBekle = 0.8f;
        }
        if (zıplaBekle <= 0)
        {
            zıplaSure.text = "JUMP";
        }
        else
        {
            zıplaSure.text = "JUMP LOADING"; 
        }
        zıplaBekle -= Time.deltaTime;
    }
}
