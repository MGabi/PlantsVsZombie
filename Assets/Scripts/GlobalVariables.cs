using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour {

    public static int score = 50;
    public static int[][] Matrix;
    public static float Countdown = 61.0f;
    public static int[] ZombieOnLane;
    public static bool spawningFinished = false;
    public static int totalZombies = 0;

    public static bool ExistsZombie(string plant,Transform plantTransf)
    {
        
            if (ZombieOnLane[(int)plantTransf.position.y] > 0)
                return true;
            else return false;
       
        

    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        ZombieOnLane = new int[5];
        for (int i = 0; i < 5; i++)
            ZombieOnLane[i] = 0;

        Matrix = new int[5][];
        for(int i=0;i<5;i++)
        {
            Matrix[i] = new int[15];
            for (int j = 0; j < 15; j++)
                Matrix[i][j] = 0;
        }
    }

}
