using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{

    [SerializeField] Text playerWelcome;
    string player;
    string welcome;
    int min = 1;
    int max;

    public void OnPressElijah()
    {
        PlayerPrefs.SetInt("PlayerMax", 1000);
        player = "Elijah";
        WelcomePlayer();
    }

    public void OnPressStefan()
    {
        PlayerPrefs.SetInt("PlayerMax", 100);
        player = "Stefan";
        WelcomePlayer();
    }

    public void OnPressAlex()
    {
        PlayerPrefs.SetInt("PlayerMax", 10);
        player = "Alex";
        WelcomePlayer();
    }

    void WelcomePlayer()
    {
        max = PlayerPrefs.GetInt("PlayerMax");
        welcome = "Welcome, " + player + "! Please pick a number between " + min + " and " + max + ". Keep it a secret though! I am going to try to guess it. When you are ready, press Enter to start!";
        playerWelcome.text = welcome;
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        GameObject SceneLoader = GameObject.Find("SceneLoader");
        SceneLoader.GetComponent<SceneLoader>();
        SceneLoader.GetComponent<SceneLoader>().LoadNextScene();
    }

 }
