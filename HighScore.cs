using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highSkorYaz;
    public GameObject skoruYaz;
    void Start()
    {
        skoruYaz.SetActive(false);
        
    }
    private void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "olArea")
        {
            skoruYaz.SetActive(true);
            highSkorYaz.text = PlayerPrefs.GetInt("highScore").ToString();
        }
    }


}
