using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organizer : MonoBehaviour
{
    [SerializeField] private GameObject square;

    [SerializeField] private GameObject content;
    // Start is called before the first frame update
    void Start()
    {
        PopulateSquares();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PopulateSquares()
    {
        //todo: destory all buttons
        for (int i = 0; i < 10; i++)
        {
            GameObject button = Instantiate(square, content.transform);
        }
        
    }
}
