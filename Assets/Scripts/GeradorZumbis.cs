using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
    public GameObject Zumbi;
    private float contador = 0;
    public float TempoGeraZumbis = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        if (contador < TempoGeraZumbis) return;
        
        Instantiate(Zumbi, this.gameObject.transform.position, this.gameObject.transform.rotation);
        contador = 0;
    }
}
