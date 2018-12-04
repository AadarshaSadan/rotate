using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiggred : MonoBehaviour {
    public Transform prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Enemy")
        {


            float X_postion = Random.Range(-4.0f, 4.0f);
            float Z_position = Random.Range(-4.0f, 4.0f);
            Debug.Log(X_postion);
            Debug.Log(Z_position);
            Vector3 position = new Vector3(X_postion, 0.48f, Z_position);
            // transform.position = Random.insideUnitCircle * 5;
            Instantiate(prefab, position, Quaternion.identity);
            FindObjectOfType<Total>().GameOverGame();
            Destroy(other.gameObject);
        }
    }
}
