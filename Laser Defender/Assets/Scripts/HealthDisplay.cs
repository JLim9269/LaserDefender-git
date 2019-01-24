using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour {

    // Configuration Parameters
    TextMeshProUGUI playerHealth;
    Player player;

	// Use this for initialization
	void Start ()
    {
        playerHealth = GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerHealth.text = player.GetHealth().ToString();
	}
}
