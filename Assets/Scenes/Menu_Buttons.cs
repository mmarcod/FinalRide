using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    //method to use to load Scene1
    public void Main_Menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void LoadStartGame()
    {
        SceneManager.LoadScene("StartGame");
    }
    public void LoadYarraBoard()
    {
        SceneManager.LoadScene("YarraBoard");
    }
    public void LoadHiddenPassage()
    {
        SceneManager.LoadScene("HiddenPassage");
    }
    public void LoadMenuScene()
    {
        //loads the scene1 using the method calledLoad Scene
        SceneManager.LoadScene("MenuScene");
    }
}