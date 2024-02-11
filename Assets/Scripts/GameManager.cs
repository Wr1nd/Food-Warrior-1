using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;

    void Awake()
    {
        score = 0;
    }

    void Update()
    {
        print(score);
    }
}