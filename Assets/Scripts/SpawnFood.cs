using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject PrefabFood;

    private GameObject _cloneFood;
   // private List<GameObject> _foodList;
   // private List<Vector3> _foodPos;
    private float[] roadX = new float[] { -4.7f, -1.9f, 1f, 4f }; // можно записать сюда позиции блоков по оси x
    public LevelGenerator LevelGenerator;
    

    private void Start()
    {
        int random =  Random.Range(20,120);
        for (int i = 0; i < random; i++) 
        {
            GameObject coin = Instantiate(PrefabFood,transform);
            coin.transform.localPosition = CalculateLocalPosition(i);
        }
      //  SpawnFoodObject();
    }

    private Vector3 CalculateLocalPosition(int i)
    {
        int index = Random.Range(0, 4);

        return new Vector3(roadX[index], 0.5f, Random.Range(i, LevelGenerator.Finish.position.z));
    }

    public void SpawnFoodObject()
    {
        int index = Random.Range(1,4);
        _cloneFood = Instantiate(PrefabFood, transform);
        Vector3 positionClone = new Vector3 (roadX[index],0.5f, Random.Range(1f, LevelGenerator.Finish.position.z));
        _cloneFood.transform.localPosition = positionClone;
    }
}
