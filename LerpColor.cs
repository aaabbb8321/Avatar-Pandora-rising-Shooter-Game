using UnityEngine;

public class LerpColor : MonoBehaviour
{
    MeshRenderer cubeMeshRenderer;
    [SerializeField] [Range(0f, 1f)] float lerpTime;
    
    [SerializeField] Color[] myColour;
    int colourIndex = 0;
    float t = 0f;
    int len;
    // Start is called before the first frame update
    void Start()
    {
        cubeMeshRenderer = GetComponent<MeshRenderer>();
        len = myColour.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        cubeMeshRenderer.material.color = Color.Lerp(cubeMeshRenderer.material.color, myColour[colourIndex], lerpTime * lerpTime*Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime * lerpTime*Time.deltaTime);
        if(t>.9f)
        {
            t = 0f;
            colourIndex++;
            colourIndex = (colourIndex >= len) ? 0 : colourIndex;
        }
    }
}
