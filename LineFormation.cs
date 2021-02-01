using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FormationTest : MonoBehaviour
{
    public float offset;
    public int rowInt;

    public List<Transform> LineFormation(int numberInFormation)
    {
        foreach (Transform child in transform)  //destroy prevoius list of gameobjects so we do not add twice
        {
            Destroy(child.gameObject);
        }
        List<Transform> soldierPositions = new List<Transform>();
        for (int i = 0; i < numberInFormation; i++)
        {
            //create a list of children that can be accessed in the next loop
            GameObject position = new GameObject("position " + i.ToString());
            position.transform.parent = transform;
            soldierPositions.Add(position.transform);
        }

        int count = 0;
        float offsetX = offset;
        float offsetZ = -offset;

        foreach (Transform soldier in soldierPositions)
        {
            Vector3 position = gameObject.transform.position - gameObject.transform.position;   //zero out the position
            if (count == rowInt)    //if we have 7 soldiers in a row, start a new row
            {
                count = 0;
                offsetZ -= offset;  //add a new row
            }
            //alternate between placements of positive x and negative x
            if (count % 2 != 0) //number is odd
            {
                position.x -= offsetX;  //offset once to left
            }
            else
            {
                if (count == 0) //first soldier is always set to middle
                {
                    //do nothing so first soldier is naturally set to middle, reset the offset
                    offsetX = offset;
                }
                else    //every even numbered soldier goes to right of middle
                {
                    position.x += offsetX;
                    offsetX += offset;
                }
            }
            //position.x -= 17.1850166f;   //for some reason this work?
            //position.z += offsetZ - 2.78093147f - 2;

            position.z += offsetZ;
            soldier.transform.localPosition = position;
            count++;
        }
        return soldierPositions;
    }
}
