using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

	[SerializeField] GameObject puckPrefab;
	[SerializeField] Transform stickEnd;
	int generatedFlag=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (OVRInput.Get(OVRInput.Button.One) && generatedFlag==0)
        {
        	Shoot();
        	generatedFlag = 1;
        } else if (OVRInput.Get(OVRInput.Button.One) && generatedFlag==1){

        } else {
        	generatedFlag = 0;
        }
    }

    void Shoot(){
        // Debug.Log(stickEnd.position);
        // OVRDebugConsole.Log(stickEnd.position);
    	Instantiate(puckPrefab, stickEnd.position, stickEnd.rotation);
        //Instantiate(puckPrefab, new Vector3( 0.0f, 0.0f, -9.5f), stickEnd.rotation);   
    }
}
