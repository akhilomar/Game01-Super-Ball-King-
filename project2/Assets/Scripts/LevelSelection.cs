using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{

   public GameObject level2;
   public GameObject level3;
   public GameObject level4;
   public GameObject level5;
   public GameObject level6;
   public int lvl;

   public void Start(){
    lvl = PlayerPrefs.GetInt("level");
    Debug.Log(lvl);
    if(lvl == 0){ 
     level2.GetComponent<Button>().enabled = false;
     level2.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);
     
    level3.GetComponent<Button>().enabled = false;
    level3.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

    level4.GetComponent<Button>().enabled = false;
    level4.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

    level5.GetComponent<Button>().enabled = false;
    level5.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

    level6.GetComponent<Button>().enabled = false;
    level6.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);
     
    }
    else if(lvl == 1){
        level2.GetComponent<Button>().enabled = true;
        level2.GetComponent<Image>().color = new Color(1, 1, 1, 1f);

        level3.GetComponent<Button>().enabled = false;
        level3.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

        level4.GetComponent<Button>().enabled = false;
        level4.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

        level5.GetComponent<Button>().enabled = false;
        level5.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

        level6.GetComponent<Button>().enabled = false;
        level6.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);
    }
    else if(lvl == 2){
        level2.GetComponent<Button>().enabled = true;
        level2.GetComponent<Image>().color = new Color(1, 1, 1, 1f);

        level3.GetComponent<Button>().enabled = true;
        level3.GetComponent<Image>().color = new Color(1, 1, 1, 1f);

        level4.GetComponent<Button>().enabled = false;
        level4.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

        level5.GetComponent<Button>().enabled = false;
        level5.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);

        level6.GetComponent<Button>().enabled = false;
        level6.GetComponent<Image>().color = new Color(1, 1, 1, 0.7f);
    }
   }
   public void levelOne(){
       SceneManager.LoadScene(0);
   }
   public void levelTwo(){
       SceneManager.LoadScene(1);
   }
   public void levelThree(){
       SceneManager.LoadScene(2);
   }

}
