using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    // Public references
    public Text ScoreTextRed;
    public Text ScoreTextYellow;
    public Text ScoreTextBlue;
    public Text ScoreTextGreen;

    // Private components
    internal static UiManager UIMinstance;
	private GameManager gameManager;

	void Awake()
	{
		UIMinstance = this;
	}

	void Start()
	{
		gameManager = GameManager.GMinstance;
	}


	public void UpdateScoreRed()
	{
		ScoreTextRed.text = "Points : " + gameManager.PointsRed;
	}
	public void UpdateScoreYellow()
	{
		ScoreTextYellow.text = "Points : " + gameManager.PointsYellow;
	}
	public void UpdateScoreBlue()
	{
		ScoreTextBlue.text = "Points : " + gameManager.PointsBlue;
	}
	public void UpdateScoreGreen()
	{
		ScoreTextGreen.text = "Points : " + gameManager.PointsGreen;
	}
}
