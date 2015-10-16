using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		if(musicManager){
			float volume = PlayerPrefsManager.GetMasterVolume();
			musicManager.changeVolume(volume);
		} else {
			Debug.Log ("No music manager found in Start scene. Can't set volume.");
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
