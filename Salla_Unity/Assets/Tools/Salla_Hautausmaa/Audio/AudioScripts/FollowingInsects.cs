using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingInsects : MonoBehaviour
{

	[SerializeField] private Transform playerHead;
	[SerializeField] private float startTimer = 0f;
	[SerializeField] private float followDelay = 3f;
	[SerializeField] private GameObject[] insects;


	private void Start()
	{
		StartCoroutine(SpawnInsects());
	}

	void Update()
    {
		if (playerHead != null)
			this.transform.position = Vector3.Lerp(this.transform.position, playerHead.position, Time.deltaTime / followDelay);
    }

	private IEnumerator SpawnInsects()
	{
		yield return new WaitForSeconds(startTimer);

		for (int i = 0; i < insects.Length; i++)
		{
			insects[i].SetActive(true);
		}
	}
}
