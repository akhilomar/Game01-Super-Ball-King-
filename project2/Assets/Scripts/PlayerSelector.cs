using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{

   public GameObject player1, player2, player3, player4, player5, player6, pButton3, pButton4;
   public int lvl;

   public void Start(){
        lvl = PlayerPrefs.GetInt("level");

        if(lvl == 0){
        pButton3.GetComponent<Button>().enabled = false;
        pButton3.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);

        pButton4.GetComponent<Button>().enabled = false;
        pButton4.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        }
        else if(lvl == 1){
            pButton3.GetComponent<Button>().enabled = true;
            pButton3.GetComponent<Image>().color = new Color(1, 1, 1, 1f);

            pButton4.GetComponent<Button>().enabled = false;
            pButton4.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        }
        else if(lvl == 2){
            pButton4.GetComponent<Button>().enabled = true;
            pButton4.GetComponent<Image>().color = new Color(1, 1, 1, 1f);
        }

        player5.GetComponent<Button>().enabled = false;
        player5.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);

        player6.GetComponent<Button>().enabled = false;
        player6.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
   }

   public void playerOne(){
        player1.gameObject.SetActive(true);
        player2.gameObject.SetActive(false);
        player3.gameObject.SetActive(false);
        player4.gameObject.SetActive(false);
   }
   
   public void playerTwo(){
       player1.gameObject.SetActive(false);
       player2.gameObject.SetActive(true);
       player3.gameObject.SetActive(false);
       player4.gameObject.SetActive(false);
   }
   public void playerThree(){
       player1.gameObject.SetActive(false);
       player2.gameObject.SetActive(false);
       player3.gameObject.SetActive(true);
       player4.gameObject.SetActive(false);
   }
   public void playerFour(){
       player1.gameObject.SetActive(false);
       player2.gameObject.SetActive(false);
       player3.gameObject.SetActive(false);
       player4.gameObject.SetActive(true);
   }
}
