using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public int xDirection;
    public int yDirection;
    private Transform _componentTransform;
    private SpriteRenderer _componentSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Start is called before the first frame update
    void Awake()
    {
        _componentTransform = GetComponent<Transform>();
        _componentSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        _componentTransform.position = new Vector2(_componentTransform.position.x + xSpeed * xDirection * Time.deltaTime, _componentTransform.position.y + ySpeed * yDirection * Time.deltaTime);
        if (_componentTransform.position.x >= 13.84f)
        {
            xDirection = -1;
            _componentSpriteRenderer.flipX = true;
        }
        else if (_componentTransform.position.x <= -13.76f)
        {
            xDirection = 1;
            _componentSpriteRenderer.flipX = false;
        }
        if (_componentTransform.position.y >= 3.78f)
        {
            yDirection = -1;
            _componentSpriteRenderer.flipX = true;
        }
        else if (_componentTransform.position.y <= -3.78f)
        {
            yDirection = 1;
            _componentSpriteRenderer.flipX = false;
        }
    }
}
