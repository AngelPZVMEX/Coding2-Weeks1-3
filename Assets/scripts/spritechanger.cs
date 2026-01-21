using UnityEngine;
using UnityEngine.InputSystem;

public class spritechanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pickarandomcolor();
    
    }

    // Update is called once per frame
    void Update()
    {
        //if( Keyboard.current.anyKey.wasPressedThisFrame == true)
        // {
        //     Pickarandomcolor();
        // }

        //get mouse position
       Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over sprite?
       if(spriteRenderer.bounds.Contains(mousePos))
        {
//y: use col var
spriteRenderer.color = col;
        }
        else
        {
 //n set to white
 spriteRenderer.color=Color.white;
        }
        

       

    }

    void Pickarandomcolor()
    {
 spriteRenderer.color = Random.ColorHSV();
    }
}
