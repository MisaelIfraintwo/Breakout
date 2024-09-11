using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    public Vector2 velocidadInicial;
    private Rigidbody2D pelotaRb;
    bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        pelotaRb= GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {   if (!isMoving)
        {
            pelotaRb.velocity = velocidadInicial;
            isMoving = true;
        }
        Victory();
        Victory2();
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Break")) { Destroy(collision.gameObject); }
        if (collision.gameObject.CompareTag("breack2")) { Destroy(collision.gameObject); }

        if (collision.gameObject.CompareTag("Lose")) { GameOver(); }
    }
    void Victory ()
    {
        GameObject[] Bricks = GameObject.FindGameObjectsWithTag("Break");
        if(Bricks.Length == 0) {SceneManager.LoadScene("Nivel2"); }
        
    }
    void Victory2()
    {
        GameObject[] Brick = GameObject.FindGameObjectsWithTag("breack2");  //escribi mal la tag 
        if (Brick.Length == 0) {SceneManager.LoadScene("Final"); } }
    void GameOver() 
    {
        SceneManager.LoadScene("GameOver");
    }
}
   

