using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIStartNewGame : MonoBehaviour {
    //Переменные для сложности и типа игры "Одна жизнь"
    bool oneLife;
    int difficult;

    //переменные для перехвата нажатия нужно кнопки и включенного тоггла в главном меню
    private Toggle oneLifeToggle;
    public void StartGame()
    {
        oneLifeToggle = GetComponent<Toggle>();
        if (oneLifeToggle == true)
        {
            SceneManager.LoadScene(1);
            oneLife = true;
        }

    }
}
