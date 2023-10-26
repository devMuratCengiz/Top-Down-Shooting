using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bullet : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject explosionEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        

        if (collision.gameObject.tag == "Enemy")
        {
            GameObject effect = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Destroy(collision.gameObject);
            gameManager.UpdateScore();
        }

        // Eğer temas edilen nesnenin etiketi "Player" değilse, bu kodları çalıştırma.
        if (collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
    
}
