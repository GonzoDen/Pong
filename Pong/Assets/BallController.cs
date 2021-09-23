using UnityEngine;

public class BallController : MonoBehaviour
{
    public float MaxSpeed = 40;

    public RigidBody rigidBody;

    void Start()
    {
        rigidBody.GetComponent<RigidBody>();    
    }

    void FixedUpdate()
    {
        if (rigidBody.velocity.magbitude > MaxSpeed)
        {
            rigidBody.velocity = rigidBody.velocity.normalized * MaxSpeed;
        }
    }
}
