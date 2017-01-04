using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bouton5 : MonoBehaviour {

	public GameObject pannel1;
	public GameObject pannel2;
	public GameObject pannel3;
	public GameObject pannel4;
	public GameObject pannel5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 2; i++) {
			pannel1.SetActive(false);
			pannel2.SetActive(false);
			pannel3.SetActive(false);
			pannel4.SetActive(false);
			pannel5.SetActive(true);
			this.gameObject.GetComponent<bouton5> ().enabled = false;
		}
	
	}
}
