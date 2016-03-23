using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    GameObject _playerGameObject;
    
    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent> ();
        _playerGameObject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            _navMeshAgent.SetDestination(_playerGameObject.transform.position);
        }
        else
        {
            //nothing
            Debug.Log(" nothing ");
            
        }
           
    }
}

