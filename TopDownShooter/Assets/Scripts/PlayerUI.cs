using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerUI : MonoBehaviour {


    private int counter;
    public Text counterText;
    public int EnemyInScene;
    public GameObject[] EnemyObjecten;
    // Use this for initialization
    void Start ()
    {

        EnemyObjecten = GameObject.FindGameObjectsWithTag("Enemy");
        EnemyInScene = EnemyObjecten.Length;

    }
	
	// Update is called once per frame
	void Update ()
    {
        EnemyObjecten = GameObject.FindGameObjectsWithTag("Enemy");
        EnemyInScene = EnemyObjecten.Length;
        UpdateCounterUI();
    }

    void UpdateCounterUI()
    {

        counterText.text = "Enemies Left: " +  + EnemyInScene;

    }

}
