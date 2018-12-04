using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDialogo : MonoBehaviour {
	public AudioClip audioM;
	public AudioClip audioF;
	public int medicoS;
	public int pacienteS;

	void Awake(){
		medicoS = PlayerPrefs.GetInt ("selecionadoMedico");
		pacienteS = PlayerPrefs.GetInt ("selecionadoPaciente");
		if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
			GetComponent<AudioSource> ().clip = audioF;
			GetComponent<AudioSource> ().Play();
		}
		if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
			GetComponent<AudioSource> ().clip = audioM;
			GetComponent<AudioSource> ().Play();
		}
		print (medicoS);
		print (pacienteS);
	}	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
