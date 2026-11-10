using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this destroys the game object once it completes its "fly", so there will no longer be a billion clones!
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        }
        // this next script also destroys the animals out of bounds. top is the food, lower is the animals.
        else if (transform.position.z < lowerBound) {
            Destroy(gameObject);
        }
    }
}
