using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Create new food")]
public class FoodObject : ScriptableObject
{
    public string foodName;
    public int totalCalories;
    public bool needsCooking;
}
