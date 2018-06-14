using UnityEngine;

public class Nodes : MonoBehaviour {

    private Color startColor;
    public Color hoverColor;
    private Renderer rend;

	
	void Start ()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
	}

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
