using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject game;

    // Start is called before the first frame update
    void Start()
    {
        game.SetActive(false);
        menu.SetActive(true);
    }

    private void StartGame()
    {
        game.SetActive(true);
        menu.SetActive(false);
    }
}
