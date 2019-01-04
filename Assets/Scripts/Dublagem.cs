using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dublagem : MonoBehaviour {

	public void MuteDublagem () {
		//AudioListener.pause = true;
		AudioListener.volume = 0;
	}
	public void DesmuteDublagem () {
		//AudioListener.pause = true;
		AudioListener.volume = 2;
	}
}