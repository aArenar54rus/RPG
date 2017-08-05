using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIGameInterfaceEnergySlider : MonoBehaviour {

    //создаем переменные, в которых будут ссылки на слайдер ХП и скрипт, отвечающий за персонажа
    private Slider energySlider;
    private PlayerParametres player;

    void Awake()
    {
        // получаем при запуске уровня эти самые слайдер и скрипт
        energySlider = GetComponent<Slider>();
        player = FindObjectOfType<PlayerParametres>();
    }

    void Update()
    {
        //значение слайдера приравниваем к значению количества жизней персонажа
        energySlider.value = player.playerEnergy;
        energySlider.maxValue = player.maxPlayerEnergy;
    }
}
