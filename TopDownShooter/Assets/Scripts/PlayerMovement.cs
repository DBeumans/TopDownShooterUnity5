using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10;

    private Rigidbody _rigidbody;
    private Vector3 _direction;
    
    void Awake()
    {
        // get reference to rigidbody componenet
        _rigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        // Fetch input
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        _direction = new Vector3(x, 0f, z);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;

        if (plane.Raycast(ray, out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            Vector3 adjustedHeightPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(adjustedHeightPoint);
        }

    }

    void FixedUpdate()
    {
        
        // move rigidbody using MovePosition()
        Vector3 velocity = _direction.normalized * movementSpeed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);


    }

}
