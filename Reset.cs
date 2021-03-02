using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Reset : MonoBehaviour
{
    string appID = "ca-app-pub-7993224500204628~6921870108";
    string instertitialID = "ca-app-pub-7993224500204628/3230037104";
    private InterstitialAd gecisReklam;

   
    private void Start()
    {
        MobileAds.Initialize(appID);

        gecisReklam = new InterstitialAd(instertitialID);
        AdRequest YeniReklam = new AdRequest.Builder().Build();
        gecisReklam.LoadAd(YeniReklam);


        
    }
    public void Restart()
    {
        if (gecisReklam.IsLoaded())
        {
            gecisReklam.Show();
        }
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AnaMenuDon()
    {
        SceneManager.LoadScene(0);
    }

}
