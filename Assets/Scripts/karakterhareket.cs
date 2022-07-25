using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterhareket : MonoBehaviour
{
    public float yatayhareket;
    public int harekethizi;
    public int ziplamahizi;
    public int ziplamahakki;

    Rigidbody2D rb;
    public bool karakteryerde = true;
    public bool faceright = true;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ziplamahakki = 0;
    }

 
    void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket * harekethizi * 100 * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && (karakteryerde == true || ziplamahakki > 0))

        {
            rb.velocity = Vector2.up * ziplamahizi * 100 * Time.deltaTime;
            karakteryerde = false;
            ziplamahakki -= 1;
        }

        if (yatayhareket>0 && faceright == false)
        {
            turn();
        }
        if(yatayhareket <0 && faceright == true)
        {
            turn();
        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="zemin")
        {
            karakteryerde = true;
            ziplamahakki = 2;
        }
    }

    void turn()
    {
        faceright = !faceright;
        Vector2 yeniscale = transform.localScale;
        yeniscale.x *= -1;
        transform.localScale = yeniscale;
    }

}
