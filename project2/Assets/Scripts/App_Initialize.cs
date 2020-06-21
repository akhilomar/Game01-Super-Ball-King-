using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class App_Initialize : MonoBehaviour 
{    
    public GameObject inMenuUI;
    public GameObject inGameUI;
    public GameObject gameOverUI;
    public GameObject playerSelection;
    public GameObject levelSelection;
    public GameObject player1, player2, player3, player4;
    private bool hasGameStarted = false;  
    public bool hasSeen = false;
    public GameObject adButton;
    public GameObject restartButton;
    public bool isGameOver = false;
    public GameObject CompleteLevelUI;
    public GameObject playerLogo;
  

    void Awake(){
        Shader.SetGlobalFloat("_Curvature", 2.0f);
        Shader.SetGlobalFloat("_Trimming", 0.1f);
        Application.targetFrameRate = 60;
        // player.GetComponent<AudioSource>().mute = false;
     
        
    }

    // Start is called before the first frame update
    public void Start()
    {       
        if(player1.activeSelf){
            player1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player2.activeSelf){
            player2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player3.activeSelf){
            player3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player4.activeSelf){
            player4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        inMenuUI.gameObject.SetActive(true);
        inGameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
        playerSelection.gameObject.SetActive(false);
        if(inMenuUI == null){
            inMenuUI = GameObject.FindWithTag("InMenuUI");
        }
        if(inGameUI == null){
            inGameUI = GameObject.FindWithTag("InGameUI");
        }
        if(gameOverUI == null){
            gameOverUI = GameObject.FindWithTag("GameOverUI");
        }
        if(playerSelection == null){
            playerSelection = GameObject.FindWithTag("PlayerSelection");
        }

        if(player1 == null){
            player1 = GameObject.FindWithTag("Player");
        }
        if (player2 == null){
            player2 = GameObject.FindWithTag("Player"); 
        }
        if (player3 == null){
            player3 = GameObject.FindWithTag("Player"); 
        }
        if (player4 == null){
            player4 = GameObject.FindWithTag("Player"); 
        }

        if(adButton == null){
            adButton = GameObject.FindWithTag("Adbutton");
        }
        if(restartButton == null){
            restartButton = GameObject.FindWithTag("RestartButton");
        }
        
    }
 
    public void PlayButton(){
    if (hasGameStarted == true){
        StartCoroutine(StartGame(1.0f));
    }
    else{
         StartCoroutine(StartGame(0.0f));
    }
    }
    public void PauseButton(){
          playerLogo.GetComponent<Button>().enabled = false;
        if(player1.activeSelf){
            player1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player2.activeSelf){
            player2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player3.activeSelf){
            player3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player4.activeSelf){
            player4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        hasGameStarted = true;
        inMenuUI.gameObject.SetActive(true);
        inGameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
        playerSelection.gameObject.SetActive(false);
    }
    public void GameOver(){
        if(player1.activeSelf){
            player1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player2.activeSelf){
            player2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player3.activeSelf){
            player3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(player4.activeSelf){
            player4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        
        hasGameStarted = true;
        isGameOver = true;
        inMenuUI.gameObject.SetActive(false);
        inGameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(true);  
        playerSelection.gameObject.SetActive(false); 
        if (hasSeen == true){
            adButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            adButton.GetComponent<Button>().enabled = false;
            adButton.GetComponent<Animator>().enabled = false;
            restartButton.GetComponent<Button>().enabled = true;
            restartButton.GetComponent<Animator>().enabled = true;
            restartButton.GetComponent<Image>().color = new Color(1, 1, 1, 1f);
        }
        // else if(hasSeen == false){
        //     restartButton.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        //     restartButton.GetComponent<Button>().enabled = false;
        //     restartButton.GetComponent<Animator>().enabled = false;
        //     adButton.GetComponent<Animator>().enabled = true;
        // }
    }    
    
    public void RestartGame(){
        
        SceneManager.LoadScene(0); //Start scene from index inside LoadScene(0)
        // hasSeen = false;   
        isGameOver = false;
        
    }

    public void PlayerSelection(){
        inMenuUI.gameObject.SetActive(false);
        inGameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
        playerSelection.gameObject.SetActive(true);
    }
    public void LevelSelection(){
        inMenuUI.gameObject.SetActive(false);
        inGameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
        playerSelection.gameObject.SetActive(false);
        levelSelection.gameObject.SetActive(true);
    }

    public void RewardSeen(){
        // player.GetComponent<AudioSource>().mute = false;
        if(hasSeen == false ){
            hasSeen = true;
            StartCoroutine(StartGame(1.0f));
        }
        isGameOver = false;
    }

    IEnumerator StartGame(float waitTime){
        
        inMenuUI.gameObject.SetActive(false);
        inGameUI.gameObject.SetActive(true);
        gameOverUI.gameObject.SetActive(false);
        playerSelection.gameObject.SetActive(false);
        yield return new WaitForSeconds(waitTime);
        if(player1.activeSelf){
            player1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            player1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        }
        else if(player2.activeSelf){
            player2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            player2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        }
        else if(player3.activeSelf){
            player3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            player3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        }
        else if(player4.activeSelf){
            player4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            player4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        }
    }

    public void CompleteLevel(){
        CompleteLevelUI.SetActive(true);
        if(player1.activeSelf){
            // player1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            player1.SetActive(false);
        }
         if(player2.activeSelf){
            // player2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            player2.SetActive(false);
        }
         if(player3.activeSelf){
            // player3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            player3.SetActive(false);
        }
         if(player4.activeSelf){
            // player4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            player4.SetActive(false);
        }
    }
    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
