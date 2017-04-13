using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
    public int bulletSpeed = 10;
    public GameObject explosion;
    private Rigidbody2D rb2d;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        rb2d.velocity = transform.right * -bulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.transform.gameObject.layer == LayerMask.NameToLayer("Map")) {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
