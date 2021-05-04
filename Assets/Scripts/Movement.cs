using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;

    [SerializeField]
    private float RotateSpeed;

    // Public references
    public GameObject ButtonRed;
    public GameObject ButtonYellow;
    public GameObject ButtonBlue;
    public GameObject ButtonGreen;

    // Private references
    private GameManager gameManager;
    private UiManager uiManager;



	void Start()
	{
        gameManager = GameManager.GMinstance;
        uiManager = UiManager.UIMinstance;
	}

	void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Time.deltaTime * MoveSpeed, 0, 0);
            transform.Rotate(0, -Time.deltaTime * RotateSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Time.deltaTime * MoveSpeed, 0, 0);
            transform.Rotate(0, Time.deltaTime * RotateSpeed, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, Time.deltaTime * MoveSpeed);
        }
    }

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject == ButtonRed)
		{
            Debug.Log("+5 points to red");
            gameManager.PointsRed += 5;
            uiManager.UpdateScoreRed();
        }
        else if (collision.gameObject == ButtonYellow)
        {
            Debug.Log("+5 points to yellow");
            gameManager.PointsYellow += 5;
            uiManager.UpdateScoreYellow();
        }
        else if (collision.gameObject == ButtonBlue)
        {
            Debug.Log("+5 points to blue");
            gameManager.PointsBlue += 5;
            uiManager.UpdateScoreBlue();
        }
        else if (collision.gameObject == ButtonGreen)
        {
            Debug.Log("+5 points to green");
            gameManager.PointsGreen += 5;
            uiManager.UpdateScoreGreen();
        }

        if(collision.gameObject.tag == "Enemy")
		{
            Debug.Log("Player died, restart the level");
            SceneManager.LoadScene(0);
		}
    }
}
