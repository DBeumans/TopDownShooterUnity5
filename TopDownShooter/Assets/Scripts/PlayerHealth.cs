using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    private float damage = 10;
    public float currenthealth = 100;

    public float currentarmour = 100;
	void Start ()
    {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Hitted me");
            if(currentarmour >=1)
            {
                currentarmour = currentarmour - damage;
            }
            else
            {
                currentarmour = 0;
                if(currentarmour <= 0)
                {
                    currenthealth = currenthealth - damage;
                }
            }
            
        }
    }
    // Update is called once per frame
    void Update ()
    {
        if(currentarmour <=0)
        {
            Debug.Log("Your armour broke man get some muney");
        }
	    if(currenthealth <=0)
        {
            Debug.Log("YOU DIED NIGGA");
            Destroy(gameObject);
        }
	}
}
