using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminMove : MonoBehaviour
{
    public GameObject zeminSpawn;
    public float yuksek;
    public float alcak;
    public float time;
    int i;
    void Start()
    {
        StartCoroutine(objecıkar());
    }

    public IEnumerator objecıkar()
    {
        while (true)
        {
            i = Random.Range(1,2);
           Instantiate(zeminSpawn, new Vector3(5, Random.Range(yuksek, alcak), 2), Quaternion.identity);
           yield return new WaitForSeconds(i);
        }
    }
}
