using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sun") && other.transform.localScale.x < 10)
        {
            other.transform.localScale += this.transform.localScale;
            //this.gameObject.SetActive(false);
            Destroy(this);
            
        }
        else if (other.gameObject.CompareTag("Sphere"))
        {
            if(other.transform.localScale.x > this.transform.localScale.x && other.transform.localScale.x < 4)
            {
                other.transform.localScale += other.transform.localScale;
                //this.gameObject.SetActive(false);
                Destroy(this);
            }
            else
            {
                this.transform.localScale += other.transform.localScale;
                //other.gameObject.SetActive(false);
                Destroy(other);
            }
            
            
        }
        if(this.transform.localScale.x > 20)
        {
            Destroy(this);
        }
    }

}
