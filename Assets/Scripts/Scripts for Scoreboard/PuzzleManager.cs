using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private NoteSlot slotPrefabs;
    [SerializeField] private Transform slotParent, pieceParent;
    [SerializeField] private NotePiece piecePrefab;
    
    private void Start()
    {
        
        Spawn();
    }
    void Spawn() //create both piece and slot
    {
        var spawnedSlot = Instantiate(slotPrefabs, slotParent.GetChild(0).position, Quaternion.identity);

        var spawnedPiece = Instantiate(piecePrefab, pieceParent.GetChild(0).position, Quaternion.identity);
        spawnedPiece.Init(spawnedSlot);
    }
}
