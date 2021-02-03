using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScrollar : MonoBehaviour
{
    [SerializeField] float backgroundScrollSpeed = 0.5f;
    Material meMaterial;
    Vector2 offset;
    void Start()
    {
        meMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(0f, backgroundScrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        meMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
