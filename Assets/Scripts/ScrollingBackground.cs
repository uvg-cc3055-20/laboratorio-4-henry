using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    float scrollingSpeed = 5f;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector2.down * scrollingSpeed * Time.deltaTime);
        if (transform.position.y < -20.2f)
        {
            transform.position = new Vector3(transform.position.x,
            20.2f, transform.position.z);
        }
    }
}
