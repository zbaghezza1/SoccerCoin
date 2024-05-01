using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePiece : MonoBehaviour
{
    //serialize fields
    [SerializeField] private SpriteRenderer _renderer;
    //[SerializeField] private Sprite newSprite;
    private bool dragging, placed;

    private Vector2 offset, originalPos;
    private NoteSlot slot;
    public void Init(NoteSlot slot)
    {
        _renderer.sprite = slot.Renderer.sprite;//change sprite to respective slot sprite
        this.slot = slot;
    }
    void Awake()
    {
        originalPos = transform.position;
    }
    void Update()
    {
        if (placed) return;
        if (!dragging) return;

        var mousePos = GetMousePos();
        transform.position = mousePos - offset;
    }
    void OnMouseDown() //mouse drag
    {
        dragging = true;
        offset = GetMousePos() - (Vector2)transform.position; //move sprite to mouse
    }

    void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, slot.transform.position) < 3) //if piece is on slot
        {
            transform.position = slot.transform.position;
            slot.Placed();
            //_renderer.sprite = newSprite;
            placed = true;
        }
        else //go back to start
        {
            transform.position = originalPos;
            dragging = false;
        }

    }
    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
