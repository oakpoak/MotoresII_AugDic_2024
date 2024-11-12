using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Screen
{
    public string id;
    public GameObject screen;

}
public class ScreenManager : MonoBehaviour
{
    //Singleton
    private static ScreenManager _instance;
    public static ScreenManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ScreenManager>();
            }
            return _instance;
        }
    }
    public List<Screen> screens;

    public void OpenScreen(string _id)
    {
        for (int i = 0; i < screens.Count; i++)
        {
            screens[i].screen.SetActive(false);

        }
    }
}

