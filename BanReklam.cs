using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BanReklam : MonoBehaviour
{
    private BannerView bannerReklam;
    string bannerID = "ca-app-pub-7993224500204628/3617049915";

    string appID = "ca-app-pub-7993224500204628~6921870108";

    public AdPosition position;
   
    void Start()
    {
        MobileAds.Initialize(appID);

        bannerReklam = new BannerView(bannerID, AdSize.Banner, position);

        AdRequest yeniReklam = new AdRequest.Builder().Build();

        bannerReklam.LoadAd(yeniReklam);


    }
    void Update()
    {
        bannerReklam.Show();
    }
}
