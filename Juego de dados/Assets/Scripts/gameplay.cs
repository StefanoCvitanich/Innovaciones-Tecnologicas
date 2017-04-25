using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplay : MonoBehaviour {

	public Text dadosPlayer;
	public Text dadosOponente;
	private int randomPlayer = 0;
	private int randomOpponent = 0;
	private string value;
	private int wins = 0;
	public Text victorias;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void rollDice() {
	
		randomPlayer = Random.Range (2,12);

		value = randomPlayer.ToString ();

		dadosPlayer.text = value;

		randomOpponent = Random.Range (2, 12);

		value = randomOpponent.ToString ();

		dadosOponente.text = value;

		if (randomPlayer > randomOpponent)
			wins++;

		victorias.text = "Victorias: " + wins.ToString ();
	}
}
