using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text healtText;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        healtText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        healtText.text = player.GetHealth().ToString();
    }
}
