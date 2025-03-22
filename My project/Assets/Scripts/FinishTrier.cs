using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish_Trier : MonoBehaviour
{
    [SerializeField] private Button Restart;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] public GameObject finishMenu;
    [SerializeField] public GameObject startMenu;



    private void Awake()
    {
        Restart.onClick.AddListener(FinishGame);
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        FinishTrigger();
    }

    private void FinishGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //startMenu.SetActive(false);
        //finishMenu.SetActive(false);
    }

    private void FinishTrigger()
    {
        gameMenu.SetActive(false);
        finishMenu.SetActive(true);
    }
}
