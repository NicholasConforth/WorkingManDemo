using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
	[Header("Ping")]
	//public GameObject pingSphere;
	public Vector3 maxPingSize = Vector3.one * 1000;
	public Vector3 minPingSize = Vector3.one * 10;
	public float pingTime = 10;
	[Space(5)]

	public float moveSpeed = 5;
	public bool blindness = false;
	public GameObject pauseMenu;

    private void Awake()
    {
		//pingSphere.transform.localScale = minPingSize;
    }

    void Update()
	{

		Vector3 move = Vector3.zero;
		if (Input.GetKey(KeyCode.W)) move.z++;
		if (Input.GetKey(KeyCode.D)) move.x++;
		if (Input.GetKey(KeyCode.A)) move.x--;
		if (Input.GetKey(KeyCode.S)) move.z--;
		transform.position += transform.rotation * move * moveSpeed * Time.deltaTime;


		if (Input.GetKeyDown(KeyCode.Space)) StartCoroutine("Ping");

	}

	public IEnumerator Ping()
    {
		float timeElapsed = 0;

		while (timeElapsed < pingTime/2)
		{
			//pingSphere.transform.localScale = Vector3.Lerp(transform.localScale, maxPingSize, timeElapsed / (pingTime/2));
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		while (timeElapsed < pingTime)
		{
			//pingSphere.transform.localScale = Vector3.Lerp(transform.localScale, minPingSize, timeElapsed / pingTime);
			timeElapsed += Time.deltaTime;
			yield return null;
		}

		//pingSphere.transform.localScale = minPingSize;
	}
}
