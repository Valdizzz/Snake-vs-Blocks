using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject PrefabFood;
    public Transform ObjectTopRightBorder, ObjectBotLeftBorder;
    private GameObject _cloneFood;
    private List<GameObject> _foodList;
    private List<Vector3> _foodPos;

    private void Awake()
    {
        int random =  Random.Range(3,20);
        for (int i = 0; i < random; i++) 
        {
            GameObject coin = Instantiate(PrefabFood,transform);
            coin.transform.localPosition = CalculateLocalPosition(i);
        }
      //  SpawnFoodObject();
    }

    private Vector3 CalculateLocalPosition(int i)
    {
        return new Vector3((float)i, 0.5f, (float)i);
    }

    public void SpawnFoodObject()
    {

        _cloneFood = Instantiate(PrefabFood, transform);
        Vector3 positionClone = new Vector3(Random.Range(ObjectBotLeftBorder.localPosition.x, ObjectTopRightBorder.localPosition.x), 1, Random.Range(ObjectBotLeftBorder.localPosition.z, ObjectTopRightBorder.localPosition.z));
        _cloneFood.transform.localPosition = positionClone;
    }
}
