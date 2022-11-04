using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_angle : MonoBehaviour
{
    SpriteRenderer player;
    bool facingright = true;
    Animator animation1;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        animation1 = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        flipping();
        playeranimation();
    }
    void flipping()
    {
        if(facingright == true && Input.GetKeyDown(KeyCode.A))
        {
            player.flipX = true;
            facingright = false;
        }else if(facingright == false && Input.GetKeyDown(KeyCode.D))
        {
            player.flipX =false;
            facingright = true;
        }
    }
    void playeranimation()
    {
        float speed = Input.GetAxis("Horizontal");
        animation1.SetFloat("speed", Mathf.Abs(speed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animation1.SetTrigger("jump");
        }

    }
}
