using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public List<GameObject> objlist;
    
    // Use this for initialization
    void Start () {
        objlist.Add(obj);
        objlist.Add(obj2);
        objlist.Add(obj3);

        for(int i = 0; i != 20; i++)
        {
            GameObject test = Instantiate(obj);
            test.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            objlist.Add(test);

        }
        InvokeRepeating("Spawn", 0.1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        for (int i = 0; i != objlist.Count; i++)
        {
            float x = Random.Range(5f, 10f);
            float y = Random.Range(5f, 10f);
            float z = Random.Range(5f, 10f);
            float val = Random.Range(1f, 5f);
            objlist[i].transform.localScale = new Vector3(val, val, val);
            Instantiate(objlist[i], objlist[i].transform.TransformVector(x, y, z), Quaternion.identity);
        }
    }
}
