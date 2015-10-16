using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	
	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		Debug.Log ("Volume slider vaule: " + volumeSlider.value);
		Debug.Log ("Difficulty slider vaule: " + difficultySlider.value);
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.changeVolume(volumeSlider.value);
	}
	
	public void SaveAndExit(){
		Debug.Log (difficultySlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		levelManager.LoadLevel("01a Start");
	}
	
	public void SetDefaults(){
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2f;
	}
}
