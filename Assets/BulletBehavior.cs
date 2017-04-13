using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
    

    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.tag != "Player") {
            
        }
    }
}
