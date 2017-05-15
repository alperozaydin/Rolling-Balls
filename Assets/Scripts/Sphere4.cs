using UnityEngine;
using System.Collections;

public class Sphere4 : MonoBehaviour {
	Rigidbody body1;
	private Vector3 cor;
	int counter = 0;
	// Use this for initialization
	void Start () {
		cor.x = 8f;
		cor.y = 0f;
		cor.z = -6f;
		body1 = GetComponent<Rigidbody>();
		body1.AddForce(cor, ForceMode.Impulse);
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Sphere2" || col.gameObject.name == "Sphere3" || col.gameObject.name == "Sphere1" )
		{
			counter = counter + 1;
			if(counter == 3){
				Destroy(gameObject);
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
