using UnityEngine;

public class GodzillaChangeLayer : MonoBehaviour
{
    public GameObject Down;
    public GameObject Mid;
    public GameObject Top;
    private Rigidbody2D rb;
    public GameObject GodjillaLevel;
    public GameObject Godgilla;

    public string layer6 = "Down"; 
    public string layer7 = "Mid"; 
    public string layer8 = "Top";

    private int currentLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentLayer = Godgilla.layer;
    }

    
    void Update()
    {
        if (GodjillaLevel.transform.position.y >= Top.transform.position.y) 
        {
            ChangeLayer(LayerMask.NameToLayer(layer8));
           
        }
        else if (GodjillaLevel.transform.position.y <= Top.transform.position.y && GodjillaLevel.transform.position.y >= Mid.transform.position.y)
        {
            ChangeLayer(LayerMask.NameToLayer(layer7));
        }
        else
        {
            ChangeLayer(LayerMask.NameToLayer(layer6));
        }

        void ChangeLayer(int newLayer)
        {
            // Check if layer changes 
            if (newLayer != currentLayer)
            {
                // if yes, change layer
                currentLayer = newLayer;

                // change Godzilla layer
                gameObject.layer = newLayer;

                // change godzilla children layer
                foreach (Transform child in transform)
                {
                    child.gameObject.layer = newLayer;
                }
            }
        }

    }
}


