using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount ++;
    }

}

public class Player
{
    
    public static int playerCount = 0;

    public Player()
    {
        playerCount ++;
    }

}


public class Game
{
    void Start() {
        Enemy e1 = new Enemy();
        Enemy e2 = new Enemy();
        Enemy e3 = new Enemy();

        int x = Enemy.enemyCount;


    }
}

public static class Utitlities
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

public class UtilitiesExample : MonoBehaviour
{
    void Start() {
        int x = Utitlities.Add(2,2);

    }
}

public class PlayerManager : MonoBehaviour
{
    void Start() {
        int x = Player.playerCount;

    }
}