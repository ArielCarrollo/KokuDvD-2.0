using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public int DirectionX;
    public int DirectionY;
    private Rigidbody2D _compRigidbody;
    private SpriteRenderer _comSpriterenderer;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _comSpriterenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speed*DirectionX, speed * DirectionY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Muro")
        {
            if (DirectionX == 1 && DirectionY == 1)
            {
                DirectionX = -1;
                DirectionY = 1;
                _comSpriterenderer.flipX = true;
            }
            else if (DirectionX == -1 && DirectionY == -1)
            {
                DirectionX = 1;
                DirectionY = -1;
                _comSpriterenderer.flipX = false;
            }
            else if (DirectionX == -1 && DirectionY == 1)
            {
                DirectionX = 1;
                DirectionY = 1;
                _comSpriterenderer.flipX = false;
            }
            else if (DirectionX == 1 && DirectionY == -1)
            {
                DirectionX = -1;
                DirectionY = -1;
                _comSpriterenderer.flipX = true;
            }
        }
        if (collision.gameObject.tag == "MuroV")
        {
            if (DirectionX == 1 && DirectionY == 1)
            {
                DirectionX = 1;
                DirectionY = -1;
                _comSpriterenderer.flipX = true;
            }
            else if (DirectionX == -1 && DirectionY == -1)
            {
                DirectionX = -1;
                DirectionY = 1;
                _comSpriterenderer.flipX = false;
            }
            else if (DirectionX == -1 && DirectionY == 1)
            {
                DirectionX = -1;
                DirectionY = -1;
                _comSpriterenderer.flipX = false;
            }
            else if (DirectionX == 1 && DirectionY == -1)
            {
                DirectionX = 1;
                DirectionY = 1;
                _comSpriterenderer.flipX = true;
            }
        }
    }
}
