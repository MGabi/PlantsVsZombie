using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour {

    public static int score = 100;
    public static int[][] Matrix;
    public static float Countdown = 11.0f;
    public static int[] ZombieOnLane;


    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        ZombieOnLane = new int[5];
        for (int i = 0; i < 5; i++)
            ZombieOnLane[i] = 0;

        Matrix = new int[5][];
        for(int i=0;i<5;i++)
        {
            Matrix[i] = new int[10];
            for (int j = 0; j < 10; j++)
                Matrix[i][j] = 0;
        }
    }

}
