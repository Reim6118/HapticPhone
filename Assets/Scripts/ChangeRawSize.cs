using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Video;

public class ChangeRawSize : MonoBehaviour
{
    public RawImage rawimage;
    private int rawImageOriginHeight;
    private int rawImageOriginWidth;

    // Start is called before the first frame update
    void Start()
    {
        RectTransform rt = rawimage.GetComponent<RectTransform>();
        rawImageOriginWidth = Mathf.RoundToInt(rt.rect.width);
        rawImageOriginHeight = Mathf.RoundToInt(rt.rect.height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
