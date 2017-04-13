using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {
    // animate the game object from -1 to +1 and back
    public float minimum = 225;
    public float maximum = 0;
    // starting value for the Lerp    
    static float t = 0;

    private SpriteRenderer sprite;
    private Color32 baseColor;

    // Use this for initialization
    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        baseColor = sprite.color;
    }

    // Update is called once per frame
    void Update() {
        baseColor = sprite.color;
        // animate the position of the game object...
        float alpha = Mathf.Lerp(minimum, maximum, t);

        // .. and increate the t interpolater
        t += 0.5f * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f) {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }

        sprite.color = new Color32(baseColor.r, baseColor.g, baseColor.b, (byte)alpha);
    }
}
