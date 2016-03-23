using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    private float _speed;
    public float damage = 10;


    void Start()
    {

        Destroy(gameObject, 0.40f);
      
       
    }
	void Update ()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Geraakt");

            Destroy(other.gameObject);
            Destroy(gameObject);   
        }

    }
    public void SetSpeed(float value)
    {
        _speed = value;
    }
}
