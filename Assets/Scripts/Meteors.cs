using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteors : MonoBehaviour {

    public GameObject meteors;
    public float spawnTime = 0f;
    public float elapsedTime = 0f;
   
    // Use this for initialization
    void Start () {
        meteors.gameObject.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            float random = Random.Range(-7f, 7f);
            Instantiate(meteors, new Vector3(random, 5, 0),
            Quaternion.identity);
            elapsedTime = 0f;
        }

    }
}
