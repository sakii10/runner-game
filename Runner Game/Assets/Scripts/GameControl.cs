using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameControl : MonoBehaviour
{
    private int speed = 8;
    public GameObject leftGatePrefab;
    public GameObject rightGatePrefab;
    private int gateAmount = 6;
    private int gateZPosition = -40;
    private static int score;
    public GameObject scoreText;

    void Start()
    {
        scoreText.GetComponent<TextMeshPro>().text = "Score: " + score.ToString();
        for (int i = 0; i < gateAmount; i++)
        {
            leftGatePrefab.transform.position = new Vector3(
                -2.5f,
                2.5f,
                gateZPosition
            );
            rightGatePrefab.transform.position = new Vector3(
                2.5f,
                2.5f,
                gateZPosition
            );
            Instantiate(leftGatePrefab);
            Instantiate(rightGatePrefab);
            gateZPosition += 15;
        }
    }
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("a"))
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
            transform.Translate(5 * Time.deltaTime, 0, 0);

        transform.Translate(Input.acceleration.x / 3, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("End"))
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag.Equals("Gate"))
        {
            Destroy(collision.gameObject);
            score += collision.gameObject.GetComponent<GateScript>().gateScore;
            scoreText.GetComponent<TextMeshPro>().text = "Score: " + score.ToString();
        }
    }
}
