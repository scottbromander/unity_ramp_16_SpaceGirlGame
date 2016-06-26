using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public Text starText;
	private bool carryingStar = false;

	// Use this for initialization
	void Start () {
		UpdateStarText ();
	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Star")){
			carryingStar = true;
			UpdateStarText ();
			Destroy (hit.gameObject);
		}
	}

	private void UpdateStarText() {
		string starMessage = "No Star :(";
		if (carryingStar)
			starMessage = "Carrying Star :)";
		starText.text = starMessage;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
