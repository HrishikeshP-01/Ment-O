using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPlaced : MonoBehaviour
{
    public string selection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        selection = collision.GetComponent<DialogProperties>().dtype;
        Debug.Log(selection);
        
    }
}
