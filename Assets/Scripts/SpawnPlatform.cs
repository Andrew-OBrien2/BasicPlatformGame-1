using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    //we need the locations of all spawn positions
    public GameObject[] spawnLocations = new GameObject[7];
    public GameObject[] groundObjs = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        spawnGround();
    }

    private void spawnGround()
    {
        for (int i = 0; i < spawnLocations.Length; i++)
        {
            //this is exclusive; up to not including
            int randomNum = Random.Range(0, groundObjs.Length);
            GameObject groundToSpawn = Instantiate(groundObjs[randomNum]);
            groundToSpawn.transform.position = new Vector2(spawnLocations[i].transform.position.x, spawnLocations[i].transform.position.y);

            //Instantiate(groundToSpawn, spawnLocations[i].transform);
        }
    }
}
