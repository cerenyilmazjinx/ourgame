using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundCollider;       
    private float groundHorizontalLength;       


    private void Awake()
    {
      
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }

  
    private void Update()
    {
        
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

    
    private void RepositionBackground()
    {
    
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}