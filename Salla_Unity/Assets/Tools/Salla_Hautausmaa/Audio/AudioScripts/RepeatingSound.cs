using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingSound : MonoBehaviour
{
	[Tooltip("What AudioClips do you want to play? Add them here.")]
	[SerializeField] private AudioClip[] audioClips;

	[Tooltip("How often do you want the sound to repeat? Seconds.")]
	[SerializeField] private float repeatInterval;
	[Tooltip("How much variation do you want each interval to have? Seconds.")]
	[SerializeField] private float variation;

	private float repeatTimer;
	private AudioSource a;

    void Start()
    {
		a = GetComponent<AudioSource>();

		SetInterval();
		Invoke("PlaySound", repeatTimer);
    }


	private void SetInterval()
	{
		variation = Random.Range(-variation, variation);
		repeatTimer = repeatInterval + variation;
	}


	private void PlaySound()
    {
		a.clip = audioClips[Random.Range(0, audioClips.Length)];
		a.Play();

		SetInterval();
		Invoke("PlaySound", repeatTimer);
    }
}
