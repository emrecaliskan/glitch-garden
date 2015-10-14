using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource; 
	
	void Awake(){
		DontDestroyOnLoad(gameObject);
		Debug.Log ("Dont destroy on load: " + name);
	}

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();

	}
	
	void OnLevelWasLoaded(int level){
		Debug.Log ("Started");
		Debug.Log ("Level: " + level);
		AudioClip audioClip = levelMusicChangeArray[level];
		Debug.Log ("Playing clip: " + audioClip);
		
		if (audioClip){	// If there is an audio clip attached
			audioSource.clip = audioClip;
			audioSource.loop = false;
			audioSource.Play();
		}
	}
	
	public void changeVolume(float volume){
		if (volume >= 0f && volume <= 1f){
			audioSource.volume = volume;
		} else {
			Debug.Log ("Volume level out of range");
		}
	}
}
