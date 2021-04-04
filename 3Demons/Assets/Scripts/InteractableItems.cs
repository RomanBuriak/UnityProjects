using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems : MonoBehaviour
{
    private GameObject _item;

    // Start is called before the first frame update
    void Start()
    {
        _item = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Destroy(_item, 1f);
    }
}
