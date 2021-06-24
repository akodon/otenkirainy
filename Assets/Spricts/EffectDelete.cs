using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BreakEffect", 0.5f);
        
    }
    void BreakEffect()
    {
        Destroy(gameObject);
    }

}
