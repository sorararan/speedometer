using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour {
    private static GameObject wall = (GameObject)Resources.Load ("Prefabs/Wall");

    public static void execute() {
        for( int i = 1; i < 10; i++ ){
            Instantiate(wall, new Vector3(Random.Range(-25f, 25f), 0.5f, i * 50f), Quaternion.identity);
            Instantiate(wall, new Vector3(Random.Range(-25f, 25f), 0.5f, i * 50f), Quaternion.identity);
            Instantiate(wall, new Vector3(Random.Range(-25f, 25f), 0.5f, i * 50f), Quaternion.identity);
            Instantiate(wall, new Vector3(Random.Range(-25f, 25f), 0.5f, i * 50f), Quaternion.identity);
            Instantiate(wall, new Vector3(Random.Range(-25f, 25f), 0.5f, i * 50f), Quaternion.identity);
        }
    }
}
