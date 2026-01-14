using Unity.VisualScripting;
using UnityEngine;

public class bob : MonoBehaviour
{

    public float t = 0;
    public float speed = 0.01f;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += speed;

        if (t > 1)
        {
            t = 0;
        }

       // transform.position = Vector2.Lerp(,curve.Evaluate(t));
    }
}
