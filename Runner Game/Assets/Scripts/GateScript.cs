using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateScript : MonoBehaviour
{
    public int gateScore;
    public Material greenMaterial;
    public Material redMaterial;
    public GameObject valueText;
    void Start()
    {
        gateScore = Random.Range(5, 15);
        valueText = transform.GetChild(0).gameObject;
        Renderer renderer = GetComponent<Renderer>();
        if (Random.Range(0, 2) == 0)
        {
            valueText.GetComponent<TextMeshPro>().text = "+" + gateScore;
            renderer.material = greenMaterial;
        }
        else
        {
            gateScore = -gateScore;
            valueText.GetComponent<TextMeshPro>().text = gateScore.ToString();
            renderer.material = redMaterial;
        }
    }
}
