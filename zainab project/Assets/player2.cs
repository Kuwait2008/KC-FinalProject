using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;
using UnityEngine.UI;


public class player2 : MonoBehaviour
{
   
    public Rigidbody2D rb;
    public Text scoreText;
    public float jumpAmount = 8f;
    private int score;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jumpAmount);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrigger"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoedScene(SceneManager.GetActiveScene().buildIndex);
    }
}
