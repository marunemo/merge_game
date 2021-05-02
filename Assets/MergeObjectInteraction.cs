using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeObjectInteraction : MonoBehaviour {

    public GameObject nextMerge;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name[2].Equals(this.gameObject.name[2])) {
            if(this.transform.position.y > col.transform.position.y)
                Instantiate(nextMerge,
                            new Vector2(0, (col.transform.position.y + this.transform.position.y) / 2),
                            Quaternion.Euler(0, 0, Random.Range(-360, 360)));
            Destroy(this.gameObject);
        }
    }
}