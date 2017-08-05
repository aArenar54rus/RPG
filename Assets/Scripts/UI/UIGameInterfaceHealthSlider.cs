using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIGameInterfaceHealthSlider : MonoBehaviour {
    //создаем переменные, в которых будут ссылки на слайдер ХП и скрипт, отвечающий за персонажа
    private Slider healthSlider;
    private PlayerParametres player;

    void Awake()
    {
        // получаем при запуске уровня эти самые слайдер и скрипт
        healthSlider = GetComponent<Slider>();
        player = FindObjectOfType<PlayerParametres>();
    }

    void Update()
    {
        //значение слайдера приравниваем к значению количества жизней персонажа
        healthSlider.value = player.PlayerHealthPoint;
    }
}
