using UnityEngine;

public class ThePlayer : MonoBehaviour
{
    public GameObject sceneManager;    
    public AudioClip scoreUp;
    public AudioClip damage;
    public bool dead = false; 
    public float spedOfPlayer = 1800;
    public float speedOfDirection = 13;

 

    void FixedUpdate()
    {
        
        
       
    #if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER    
       float horizontalMove = Input.GetAxis("Horizontal");
       transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3 (Mathf.Clamp(gameObject.transform.position.x + horizontalMove, -2.5f, 2.5f), gameObject.transform.position.y, gameObject.transform.position.z), speedOfDirection * Time.deltaTime);
    #endif
         
          GetComponent<Rigidbody>().velocity = Vector3.forward * spedOfPlayer * Time.deltaTime;
         
       transform.Rotate(Vector3.left * GetComponent<Rigidbody>().velocity.z / 3);
       //Mobile Controls
       Vector2 touch = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10f)); 
       if(Input.touchCount > 0 && dead == false){
           transform.position = new Vector3(touch.x, transform.position.y, transform.position.z);
       }

    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "scoreup"){
            GetComponent<AudioSource>().PlayOneShot(scoreUp, 1.0f);
        }
        if(other.gameObject.tag == "triangle"){
            GetComponent<AudioSource>().PlayOneShot(damage, 1.0f);
            sceneManager.GetComponent<App_Initialize>().GameOver();
        }
    }
}
