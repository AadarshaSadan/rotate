using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSpwan : MonoBehaviour {

    public GameObject[] objectsToSpwan;
    public float spwanRadius = 10.0f;
    public int numberofObjects = 10;
    public bool randomOrientation = false;
    public bool orientToSurface = false;

   

	// Use this for initialization
	void Start ()
    {

        for(int i=0;i<numberofObjects;i++)
        {
            GameObject objectToSpwan = objectsToSpwan[UnityEngine.Random.Range(0, objectsToSpwan.Length)];

            Vector2 spwanPositionV2 = Random.insideUnitCircle * spwanRadius;

            Vector2 spwanPosition= new Vector3(spwanPositionV2.x, 0.0f, spwanPositionV2.y);

          //  Instantiate(objectToSpwan, transform.position + spwanPosition, Quaternion.identity);
            //Vector3 tranformOffsetSpawnPosition = transform.position + spwanPosition;

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
