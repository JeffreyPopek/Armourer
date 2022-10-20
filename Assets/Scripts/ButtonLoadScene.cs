using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene : MonoBehaviour
{
    [SerializeField] private int sceneToLoad;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);

    }

    public void loadSceneButton()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void tutorialScene()
    {
        if (!TutorialScenes.visitedLore)
        {
            SceneManager.LoadScene(9);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }

    public void exitGame()
    {
        Application.Quit(1);
    }
}
