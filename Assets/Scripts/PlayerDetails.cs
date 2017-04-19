using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerDetails : MonoBehaviour {

	private static string playerName;
	private static int playerBalance;
	private static int playerFinalScore;

    private static string filePath;

	public void readData(){
        filePath = Directory.GetCurrentDirectory();
        filePath = Directory.GetParent(filePath).FullName;
        filePath = filePath + "//UserData//userdetails.txt";
		using(StreamReader sr = File.OpenText(filePath))
        {
            string s = string.Empty;
            while((s = sr.ReadLine()) != null)
            {

            }
        }

	}

	public void saveData(){
	
	}

    public int getPlayerFinalScore()
    {
        return playerFinalScore;
    }

    public void setPlayerFinalScore(int score){
		playerFinalScore = score;
	}

	public int getPlayerBalance(){
		return playerBalance;
	}

	public void setPlayerBalance(int balance){
		playerBalance = balance;
	}

	public string getPlayerName(){
		return playerName;
	}

    public void setPlayerName(string name)
    {
        playerName = name;
    }
}
