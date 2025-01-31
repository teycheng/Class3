using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] UIManager ui;

    float maxX = 13;
    float minX = -13;
    int scoreP1 = 0;
    int scoreP2 = 0;

    void Start()
    {
        ball.Launch();
    }
    private void Update()
    {
        if (ball.transform.position.x > maxX)
        {
            scoreP1++;
            ball.Reset();
            ball.Launch();
        }
        else if (ball.transform.position.x < minX)
        {
            scoreP2++;
            ball.Reset();
            ball.Launch();
        }
        ui.UpdateScore(scoreP1,scoreP2);
    }

}
