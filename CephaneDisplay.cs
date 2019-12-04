using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CephaneDisplay : MonoBehaviour
{
    Text cephaneText;
    GameSession gameSession;

    // Start is called before the first frame update
    void Start()
    {
        cephaneText = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        cephaneText.text = gameSession.GetCephane().ToString();
    }
}
