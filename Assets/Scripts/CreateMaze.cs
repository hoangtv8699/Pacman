using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMaze : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D[] boxes = target.GetComponents<BoxCollider2D>();
        for(int i = 0; i < boxes.Length; i++)
        {
            GameObject tmp = new GameObject();
            tmp.AddComponent<BoxCollider2D>();
            tmp.GetComponent<BoxCollider2D>().offset = boxes[i].offset;
            tmp.GetComponent<BoxCollider2D>().size = boxes[i].size;
            tmp.transform.parent = gameObject.transform;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
