using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public int score;
    public int highScore;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI highScoreUI;
    public ThePlayer pro;
    bool check = false;
    public int increaser = 150;
    public int scoreIncreaser = 5;
    public int factor = 5;
    public App_Initialize Lcomplete;
    public int sceneNo = 0;


    void Start(){           
        highScore = PlayerPrefs.GetInt("highScore");
         if ((pro == null) && (GetComponent<ThePlayer>() != null)  )
         {
             pro = GetComponent<ThePlayer>();
         }
         else
         {
             Debug.LogWarning("Missing ThePlayer component. Please add one");
         }

         sceneNo = SceneManager.GetActiveScene().buildIndex;
        // Lcomplete = GetComponent<App_Initialize>();
        if(sceneNo == 0){
            increaser = 150;
        }
        if(sceneNo == 1){
            increaser = 200;
        }
        if(sceneNo == 2){
            increaser = 250;
        }
        
        if(sceneNo == 0 && PlayerPrefs.GetInt("level")!=1 && PlayerPrefs.GetInt("level")!=2){
               PlayerPrefs.SetInt("level", 0);
        }
        // else if(keyPresent == false){
        //     PlayerPrefs.SetInt("level", 0);
        // }


    }
    // Update is called once per frame
    void Update()
    {
        if(score == 60 && sceneNo == 0){
            if(PlayerPrefs.GetInt("level") < 1 ){
            PlayerPrefs.SetInt("level", 1);
            }
            Lcomplete.CompleteLevel();
            if(PlayerPrefs.GetInt("level") == 0){
            PlayerPrefs.SetInt("level", 1);
            }
            
        }
        else if(sceneNo == 1 && score == 70){
            Lcomplete.CompleteLevel();
          if(PlayerPrefs.GetInt("level") == 1){
            PlayerPrefs.SetInt("level", 2);
          }
        }
    
        // if(score == 70 && sceneNo == 2){
        //     Lcomplete.CompleteLevel();
        // }

        scoreUI.text = score.ToString();  
        highScoreUI.text = highScore.ToString();
        if (score > highScore){
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
        }     
        if(score == scoreIncreaser){
            check = true;
            factor+=5;
            scoreIncreaser += factor;       
            
        }
        if(pro != null && check == true){
            pro.spedOfPlayer += increaser;
            increaser += increaser;
            Debug.Log(pro.spedOfPlayer);
            check = false;
        }
    }

    void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "scoreup"){
            score++;
        }
            
    }
}
