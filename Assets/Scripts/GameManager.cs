using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ball ball;
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
        if (transform.position.x > maxX)
        {
            scoreP1++;
            ball.Reset();
        }
        else if (transform.position.x < minX)
        {
            scoreP2++;
            ball.Reset();
        }
    }

    public Vector3 GetRandomBallDirection()
    {
        float x = 1;
        float y = 1;
        if (Random.Range(0, 2) == 0)
        {
            x = -1f;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1f;
        }
        Vector3 dir = new Vector3(x, y, 0);
        return dir;

    }
}
