using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyupdate : MonoBehaviour
{
    public Material bgMaterial;
    public float scrollSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.left;
        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;

    }
}
