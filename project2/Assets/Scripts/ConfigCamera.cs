using UnityEngine;

public class ConfigCamera : MonoBehaviour
{
    public GameObject player1, player2, player3, player4;


    // Update is called once per frame
    void Update()
    {
        if(player1.activeSelf){
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0, gameObject.transform.position.y, player1.gameObject.transform.position.z-10), Time.deltaTime * 100);
        }
        else if(player2.activeSelf){
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0, gameObject.transform.position.y, player2.gameObject.transform.position.z-10), Time.deltaTime * 100);
        }
        else if(player3.activeSelf){
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0, gameObject.transform.position.y, player3.gameObject.transform.position.z-10), Time.deltaTime * 100);
        }
        else if(player4.activeSelf){
            gameObject.transform.position = Vector4.Lerp(gameObject.transform.position, new Vector3(0, gameObject.transform.position.y, player4.gameObject.transform.position.z-10), Time.deltaTime * 100);
        }
    }
}
