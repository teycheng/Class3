using UnityEngine;
using UnityEngine.InputSystem.iOS;
using UnityEngine.WSA;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    float speed = 7f;
    float maxX = 13;
    float minX = -13;
    int scoreP1 = 0;
    int scoreP2 = 0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent<Rigidbody>(); //works, just need to go through the process of finding component at startup
        Launch();
    }

    private void Update()
    {
        if(transform.position.x > maxX)
        {
            scoreP1++;
            Reset();
        }
        else if(transform.position.x < minX)
        {
            scoreP2++;
            Reset();
        }
    }

    private void Reset()
    {
        transform.position = Vector3.zero;
        Launch();
    }
    void Launch()
    {
        Vector3 movement = GetRandomBallDirection() * speed;
        rb.AddForce(movement, ForceMode.Impulse);
    }
    Vector3 GetRandomBallDirection()
    {
        float x = 1;
        float y = 1; 
        if(Random.Range(0,2) == 0 )
        {
            x = -1f;
        }        
        if(Random.Range(0,2) == 0 )
        {
            y = -1f;
        }
        Vector3 dir = new Vector3(x, y, 0);
        return dir;
    }
}