using UnityEngine;
using System.Collections;

public class  switchScene : MonoBehaviour {
	public GameObject unityChan;
	public Material sun;
	public Material night;
	public bool nig = false;
	public GameObject white;
	public GameObject sunblack;
	public GameObject nigblack;
	public bool nigw = false;
	public bool sunw = false;

	public static  switchScene _swith;
	void Awake ()
	{

		_swith = this;
//		if (instance == null) {
//			
//			
//			DontDestroyOnLoad (gameObject);
//		}
//		else {
//			
//			Destroy (gameObject);
//		}
		
	}

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		 if(Input.GetKeyDown(KeyCode.A)){
			    if(nig == false){
				nigw = true;
				RenderSettings.skybox = night;
				nig = true;
			}else{
				nigw = true;
				RenderSettings.skybox = sun;
				nig = false;
			}
		}
		if (nigw == true && white.transform.position.x > -3.5f){
			white.transform.localPosition += new Vector3 (-0.05f, 0, 0);
			nigblack.transform.localPosition += new Vector3 (0.05f, 0, 0);
		} else if (sunw == true && white.transform.position.x > -3.5f){
			white.transform.position += new Vector3 (-0.005f, 0, 0);
			sunblack.transform.position += new Vector3 (0.005f, 0, 0);
		}
	}
}
