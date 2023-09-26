using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class walkeffect : MonoBehaviour
{
    public GameObject poof;
    [SerializeField] private bool isThiscool = true;
   
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Instantiate(poof, transform.position, Quaternion.identity);
        }
    }
}
