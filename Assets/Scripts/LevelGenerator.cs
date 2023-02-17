using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Transform Plane;
    public Transform Finish;
    public Player player;
    public GameObject[] BlocksPrefabs;
    public GameObject FirstPrefab;
    private float DistanceBetweenBlocks;
    
    [Min(1)]
    public int MinLength;
    [Min(2)]
    public int MaxLength;

    private void Awake()
    {
        int length = Random.Range(MinLength, MaxLength);
        Plane.localScale = new Vector3(1f, 1f, (float)length);
        float _length = Finish.position.z-length*2f;
        DistanceBetweenBlocks = _length/length;
        for (int i = 1; i <= length; i++)
        {
            int prefabIndex = Random.Range(0, BlocksPrefabs.Length);
            GameObject blockPrefab = i == 1 ? FirstPrefab: BlocksPrefabs[prefabIndex];
            GameObject block = Instantiate(blockPrefab,transform);
            block.transform.localPosition = CalculateBlockPosition(i);
            //DistanceBetweenBlocks = length*9f + length;

        }
        //Finish.localPosition = CalculateBlockPosition(length);
       

    }

    private Vector3 CalculateBlockPosition(int i)
    {

        return new Vector3(0, 0, DistanceBetweenBlocks * (float)i);
    }
}
