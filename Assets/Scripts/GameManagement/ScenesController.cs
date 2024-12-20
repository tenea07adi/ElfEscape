using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public static ScenesController _instance;

    private Dictionary<int, string> gameLevels = new Dictionary<int, string>();

    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
        InitLevelsList();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(gameLevels[0]);
    }

    public void LoadLevel(int lvl)
    {
        SceneManager.LoadScene(gameLevels[lvl]);
    }

    private void InitLevelsList()
    {
        gameLevels.Add(0, "MenuScene");
        gameLevels.Add(1, "SampleScene");
    }
}
