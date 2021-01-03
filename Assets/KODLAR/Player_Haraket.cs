using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Haraket : MonoBehaviour
{
    Rigidbody cp;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float KarakterHiz=10f;
    public float egim;
    
    void Start()
    {
        
        cp = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        

        float hinput = SimpleInput.GetAxis("Horizontal") * KarakterHiz;
        float vinput= SimpleInput.GetAxis("Vertical") * KarakterHiz;
        cp.transform.Translate(hinput,0,vinput);
        cp.position = new Vector3
            (
             Mathf.Clamp(cp.position.x,minX,maxX),
             0.0f,
             Mathf.Clamp(cp.position.z,minZ,maxZ)
            );
        cp.rotation = Quaternion.Euler(0,0,cp.velocity.x*egim);


    }
    public void sol()
    {
        cp.velocity = new Vector3(-KarakterHiz,0,0);
    }
}
