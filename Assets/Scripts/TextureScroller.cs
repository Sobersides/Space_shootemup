using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour {
    private MeshRenderer renderer;
    public float speed = 5;


    // Start is called before the first frame update
    void Start() {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update() {
        var offset = renderer.material.mainTextureOffset;
        offset.y += speed * Time.deltaTime;
        renderer.material.SetTextureOffset("_MainTex", offset);
    }
}
