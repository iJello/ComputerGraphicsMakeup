using UnityEngine;

public class UVShaderController : MonoBehaviour
{

    public MaterialPropertyBlock myMaterial;
    public Renderer render;
    public bool b1 = true;
    public bool b2 = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMaterial = new MaterialPropertyBlock();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        render.GetPropertyBlock(myMaterial);
        b1 = !b1;
        b2 = !b2;
        if(b1)
        {
            myMaterial.SetFloat("_b", 1f);
        }
        else
        {
            myMaterial.SetFloat("_b", 0f);
        }
        if(b2)
        
        {
            myMaterial.SetFloat("_b2", 1f);
        }
        else
        {
            myMaterial.SetFloat("_b2", 0f);
        }


        render.SetPropertyBlock(myMaterial);
    
            
        }
}
