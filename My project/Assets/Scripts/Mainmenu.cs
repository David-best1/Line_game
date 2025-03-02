using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    [SerializeField] private Button start;
    [SerializeField] private GameObject menuStart;
    [SerializeField] public GameObject menuGame;

    private void Awake()
    {
        start.onClick.AddListener(startGame);
    }

    private void startGame()
    {
        menuStart.SetActive(false);
        menuGame.SetActive(true);
    }
}
