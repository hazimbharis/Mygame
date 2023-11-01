using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{

    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {   
        for(int i = 0; i < 10; i++) {
            for(int j = 0; j < 10; j++) {
                Instantiate(myPrefab, new Vector3(64*i, 0, 64*j), Quaternion.identity);
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
