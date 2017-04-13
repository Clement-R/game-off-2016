using UnityEngine;
using System.Collections;

public class AutoDestroyAnimation : MonoBehaviour {
    void Start() {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
}
