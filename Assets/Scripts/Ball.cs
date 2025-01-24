using UnityEngine;
using UnityEngine.InputSystem.iOS;
using UnityEngine.WSA;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    float speed = 7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent<Rigidbody>(); //works, just need to go through the process of finding component at startup
        Launch();
    }

    public void Reset()
    {
        transform.position = Vector3.zero;
        Launch();
    }
    public void Launch()
    {
        Vector3 movement = GameManager.GetRandomBallDirection() * speed;
        rb.AddForce(movement, ForceMode.Impulse);
    }
    
}