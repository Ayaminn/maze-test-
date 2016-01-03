using UnityEngine;
using System.Collections;

public class wall : MonoBehaviour {
	Vector3 night;
	Vector3 deffault;

	bool upFlag = false;

	// Use this for initialization
	void Start () {

		deffault = transform.position;
		night = transform.position;

	}

	void OnCollisionEnter(Collision col){ 
		if(switchScene._swith.nig ==  true){
			night =new  Vector3 (deffault.x, deffault.y + 0.005f * 100, deffault.z);
			StartCoroutine ("Speed", 0.005f);

		}
	}

	IEnumerator Speed(float spd){

		upFlag = true;


		for (int i = 0; i < 100; i++){
			transform.position +=  new Vector3(0, spd, 0);

			yield return new WaitForSeconds (0.05f);
		}


		upFlag = false;
		yield return  null;
	}
	
	// Update is called once per frame
	void Update () {
		if(switchScene._swith.nig ==  false){
			gameObject.transform.position = new Vector3 (3.5f, 0.0f, -4.3f);
		}else{
			if(upFlag == false) {
				gameObject.transform.position = night;
			}
		}
	}
}
