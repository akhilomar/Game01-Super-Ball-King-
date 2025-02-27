﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

[RequireComponent (typeof (Button))]
public class RewardedAdsButton : MonoBehaviour, IUnityAdsListener {
public App_Initialize seeenAd;

   
    private string gameId = "3583613";
   

    Button myButton;
    public string myPlacementId = "rewardedVideo";
    

    void Start () {                  
        

        myButton = GetComponent <Button> ();


        // Set interactivity to be dependent on the Placement’s status:
        myButton.interactable = Advertisement.IsReady (myPlacementId); 

        // Map the ShowRewardedVideo function to the button’s click listener:
        if (myButton) myButton.onClick.AddListener (ShowRewardedVideo);

        // Initialize the Ads listener and service:
        Advertisement.AddListener (this);
        Advertisement.Initialize (gameId, true);
       
    }
    
    // Implement a function for showing a rewarded video ad:
    void ShowRewardedVideo () {
        // player.GetComponent<AudioSource>().mute = true;
        Advertisement.Show (myPlacementId);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsReady (string placementId) {
        // If the ready Placement is rewarded, activate the button: 
        if (placementId == myPlacementId) {        
            myButton.interactable = true;
        }
    }

    public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) {
        
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            // StartCoroutine(StartGame(1.0f));
            if(seeenAd != null){
            seeenAd.RewardSeen();
            }
            // seeenAd.hasSeen = true;
        } else if (showResult == ShowResult.Skipped) {
             if(seeenAd != null){
            seeenAd.hasSeen = true;
             }
        } else if (showResult == ShowResult.Failed) {
            if(seeenAd != null){
            seeenAd.hasSeen = true;
            }
        }
    }

    public void OnUnityAdsDidError (string message) {
        // Log the error.
    }

    public void OnUnityAdsDidStart (string placementId) {
        // Optional actions to take when the end-users triggers an ad.
    } 
}