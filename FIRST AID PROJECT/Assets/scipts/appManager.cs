using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appManager : MonoBehaviour
{
    public int layerNO1 = 1;                   
    public int TabNO = 1;

    public static appManager instance;
    private void Awake()                             //////used to make the singleton instance
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
