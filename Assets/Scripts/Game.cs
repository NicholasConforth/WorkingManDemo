using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public bool keyAquired = false;
    public bool gameLost = false;
    public bool gameWin = false;
    public GameObject Key;
    public GameObject Door;
    int numOfKey = 0;
    public AudioSource pickup;
    public float timer = 2;
    public bool soundPlayed = false;
    public EdgeDetect edgeDetect;
    public GameObject winScreen;
    public GameObject loseScreen;

    public static Game Instance { get { return instance; } }
    public static Game instance;

    private void Awake()
    {
        instance = this;
        Door.SetActive(false);

    }

    void Update()
    {
        if(keyAquired)
        {
            Key.SetActive(false);
            Door.SetActive(true);

        }
        if(gameWin)
        {
            winScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        if(gameLost)
        {
            loseScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
}
