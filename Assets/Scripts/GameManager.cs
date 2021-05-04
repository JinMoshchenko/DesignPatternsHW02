using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Public references
    public GameObject Player;
    public GameObject Enemy;
    public Transform EnemyCont;

    // Private components
    private float Timer = 2;
    internal int PointsRed;
    internal int PointsYellow;
    internal int PointsBlue;
    internal int PointsGreen;
    internal static GameManager GMinstance;

    void Awake()
    {
        // Don't destroy this reference after reload the scene
        if (GMinstance == null)
        {
            GMinstance = this;
            //DontDestroyOnLoad(GMinstance);
            // in my case I need to destroy it because it contains the latest data, so I will comment it
            Debug.Log("Uncomment DontDestroyOnLoad and it will work");
        }
    }

    void Start()
    {
        Cursor.visible = false;
        PointsRed = 0;
        PointsYellow = 0;
        PointsBlue = 0;
        PointsGreen = 0;
    }

	void Update()
	{
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            Instantiate(Enemy, EnemyCont);
            Enemy.transform.position = new Vector3(Random.Range(-5, 5), Enemy.transform.position.y, Random.Range(-5, 5));

            Debug.Log("Prototype instantiated");

            Timer = 2;
        }
	}
}
