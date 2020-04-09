using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    //Using this script makes it so that anything attached to this game object will have these behaviors 

    public Obstacle data;

    private GameObject model;

    // Start is called before the first frame update
    void Start()
    {
        model = data.model;

        var modelRend = model.GetComponent<Renderer>();
        modelRend.sharedMaterial.SetColor("_Color", data.color);

        print(data.name);
        print(data.description);
    }
}
