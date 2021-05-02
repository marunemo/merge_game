using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject target;

    public Transform lmax, rmax;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 pos = new Vector3(Input.mousePosition.x / Screen.width * (rmax.position.x - lmax.position.x) + lmax.position.x, 3, 0);
            Instantiate(target, pos, Quaternion.Euler(0, 0, Random.Range(-360, 360)));
        }
    }
}
