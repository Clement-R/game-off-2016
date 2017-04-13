using UnityEngine;
using System.Collections;

public class WeaponFire : MonoBehaviour {
    public GameObject bullet;

    private CameraShake shake;

    void Start() {
        shake = Camera.main.GetComponent<CameraShake>();
    }

	void Update () {
        if(Input.GetMouseButton(0)) {
            Instantiate(bullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 90));
            shake.shakeDuration = 0.5f;
        }
	}
}
