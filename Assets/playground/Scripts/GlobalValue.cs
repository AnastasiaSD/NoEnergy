
using UnityEngine;

public static class GlobalValue 
{
    public static int Coins = 0;
    public static bool[] KeyID = new bool[100];
    public static bool MagicIsDie = false;

    public static void AddScore(int points)
    {
        Coins += points;
    }
}
