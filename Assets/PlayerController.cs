
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;

    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update ()
    {
        //Calculate movement velocity as a 3D vector
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMove; 
        Vector3 moveVertical = transform.forward * zMove;

        //final movement vector
        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        //apply movement
        motor.Move(velocity);
    }
}
