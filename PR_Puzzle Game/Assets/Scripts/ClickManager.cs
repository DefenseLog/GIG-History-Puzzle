using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public InventoryObject inventory;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if(hit.collider != null)
            {
                var item = hit.collider.GetComponent<Item>();
                if (item)
                {
                    inventory.AddItem(item.item, 1);
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
