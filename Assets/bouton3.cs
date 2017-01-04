using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bouton3 : MonoBehaviour {

	public GameObject pannel1;
	public GameObject pannel2;
	public GameObject pannel3;
	public GameObject pannel4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 2; i++) {
			pannel1.SetActive(false);
			pannel2.SetActive(false);
			pannel3.SetActive(true);
			pannel4.SetActive(false);
			this.gameObject.GetComponent<bouton3> ().enabled = false;
		}
	
	}
}
