using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject player1, player2, player3, player4;
    public GameObject[] trianglePrefabs;
    private Vector3 spawnObstaclePosition;
    float distanceToHorizon;
    // Update is called once per frame  
    void Update()
    {   
        if(player1.activeSelf){
             distanceToHorizon = Vector3.Distance(player1.gameObject.transform.position, spawnObstaclePosition);
        }
        else if(player2.activeSelf){
             distanceToHorizon = Vector3.Distance(player2.gameObject.transform.position, spawnObstaclePosition);
        }
        else if(player3.activeSelf){
             distanceToHorizon = Vector3.Distance(player3.gameObject.transform.position, spawnObstaclePosition);
        }
        else if(player4.activeSelf){
             distanceToHorizon = Vector3.Distance(player4.gameObject.transform.position, spawnObstaclePosition);
        }

        if(distanceToHorizon < 120){
            SpawnTriangles();
        }
    }

    void SpawnTriangles(){
        spawnObstaclePosition = new Vector3(0, 0, spawnObstaclePosition.z + 30);
        Instantiate(trianglePrefabs[(Random.Range(0, trianglePrefabs.Length))], spawnObstaclePosition, Quaternion.identity);
    }
}
