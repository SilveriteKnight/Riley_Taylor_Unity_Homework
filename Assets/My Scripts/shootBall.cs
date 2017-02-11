using UnityEngine;
using System.Collections;

public class shootBall : MonoBehaviour {

	public GameObject projectile;
	public float speed = 20;
	private GameObject clone;
	public float padding = 1;
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			clone = Instantiate(projectile, transform.position + (Vector3.forward * padding), transform.rotation) as GameObject;
			clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * speed);
		}
	}
}