using UnityEngine;
using System.Collections;

public class Sphere3 : MonoBehaviour {
	Rigidbody body1;
	private Vector3 cor;
	int counter =0 ;
	// Use this for initialization
	void Start () {
		cor.x = 4f;
		cor.y = 0f;
		cor.z = 10f;
		body1 = GetComponent<Rigidbody>();
		body1.AddForce(cor, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Sphere2" || col.gameObject.name == "Sphere1" || col.gameObject.name == "Sphere4" )
		{
			counter = counter + 1;
			if(counter == 3){
				Destroy(gameObject);
			}
		}
	}
	void Update () {
		
	}
}
