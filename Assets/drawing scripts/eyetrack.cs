using UnityEngine;

public class eyetrack : MonoBehaviour
{

    public float t = 0;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //find mouse position

        //move transform position towards mouse, limit it to stay in the eye, curve it so it doesnt snap
    }
}
