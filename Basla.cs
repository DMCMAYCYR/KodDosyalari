using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Basla : MonoBehaviour
{
    public Text yaz;
    void Start()
    {
        yaz.text = "HighScore:"+PlayerPrefs.GetInt("highScore").ToString();
    }

    public void baslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void cıkıs()
    {
        Application.Quit();
    }

   
}
