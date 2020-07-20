using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public FoodObject food;

    void Start()
    {
        Debug.Log($"Name: {food.foodName}");
        Debug.Log($"Calories: {food.totalCalories}");
        Debug.Log($"needsCooking: {food.needsCooking}");
    }
}
