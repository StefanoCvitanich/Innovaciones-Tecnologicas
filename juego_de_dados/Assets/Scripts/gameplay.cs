using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.Analytics;

public class gameplay : MonoBehaviour
{

    public Text dadosPlayer;
    public Text dadosOponente;
    private int randomPlayer = 0;
    private int randomOpponent = 0;
    private string value;
    private int wins = 0;
	private int ties = 0;
    public Text victorias;

    // Use this for initialization
    void Start()
    {
		Advertisement.Initialize ("1395397", true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void rollDice()
    {

        randomPlayer = Random.Range(2, 12);

        value = randomPlayer.ToString();

        dadosPlayer.text = value;

        randomOpponent = Random.Range(2, 12);

        value = randomOpponent.ToString();

        dadosOponente.text = value;

		if (randomPlayer > randomOpponent) 
		{
			wins++;

			if (wins % 3 == 0) 
			{
				ShowAd();
			}
		}

		else if (randomPlayer == randomOpponent) 
		{
			ties++;

			if(ties %5 == 0)
				Analytics.CustomEvent ("Tie", new Dictionary<string, object>
				{ 
					{"ties", ties}
				});
		}
			

        victorias.text = "Victorias: " + wins.ToString();

    }

	private void ShowAd()
	{
		if (Advertisement.IsReady())
			Advertisement.Show();
	}
}