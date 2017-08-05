using UnityEngine;
using System.Collections;

public class PlayerParametres : MonoBehaviour {
    //жизни игрока
    private int playerHealthPoint;
    public int PlayerHealthPoint
    {
        get { return playerHealthPoint; }
        set {
            if (value <= 0)
            {
                playerHealthPoint = 0;
                PlayerDeath();
            }
            else
                playerHealthPoint = value;
        }
    }

    //мана, энергия
    public int playerEnergy;
    public int maxPlayerEnergy;

    //счетчик временной для регенерации энергии
    public float timeRegenerationEnergy = 4;
    public float timeEnergy;

    //уровень игрока
    private int playerLevel;
    
    //опыт игрока
    private int playerExperience;
    private int[] maxExperience = new int[] {0, 1000, 3000, 8000, 15000, 25000, 40000}; //опыт до следующего уровня
    public int PlayerExperience
    {
        get { return playerExperience; }
        set
        {
            if (value == maxExperience[playerLevel])
            {
                playerExperience = 0;
                playerLevel += 1;
            }
            else
                playerLevel = value;
        }
    }

    // Use this for initialization
    void Awake () {
        playerLevel = 1;
        playerHealthPoint = 100 + 10 * playerLevel;
        maxPlayerEnergy = 100 + 10 * playerLevel;
	}
	
	// Update is called once per frame
	void Update () {
	    
        if (playerEnergy < maxPlayerEnergy)
        {
            timeEnergy += Time.time;
            if (timeEnergy >= timeRegenerationEnergy)
            {
                timeEnergy = 0;
                playerEnergy += 1;
            }
        }
        else
        {
            playerEnergy = maxPlayerEnergy;
        }

        
	}

    void PlayerDeath()
    {

    }
}
