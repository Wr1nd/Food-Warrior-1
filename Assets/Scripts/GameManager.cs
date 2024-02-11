using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public int highScore;

    public int lives;

    public List<GameObject> lifeImages;

    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            lifeImages[i].SetActive(i < lives);
        }
    }
}