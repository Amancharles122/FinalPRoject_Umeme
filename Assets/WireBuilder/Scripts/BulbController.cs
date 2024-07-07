using UnityEngine;
using System.Collections;
using UnityEngine.Events;


public class BulbController : MonoBehaviour
{

    public UnityEvent conditionAchieved;
    public GameObject pointA, plugA, pointB, plugB, pointC, plugC, pointD, plugD;

    // Use this for initialization
    void Start()
    {
        //conditionAchieved.Invoke();
      


    }

    //public void SwitchOnBulb()
    //{

    //}

    // Update is called once per frame
    void Update()
    {

        bool pointATouching = AnyCollisionDetection.IsTouching(pointA, plugA); //start
        bool pointBTouching = AnyCollisionDetection.IsTouching(pointB, plugB); //end
        bool pointCTouching = AnyCollisionDetection.IsTouching(pointC, plugC); //start
        bool pointDTouching = AnyCollisionDetection.IsTouching(pointD, plugD);

        if (pointATouching)
        {
            print("point A is touching");
        }
        else if (pointBTouching)
        {
            print("point B is touching");
        }
        //else if (pointCTouching)
        //{
        //    print("point C is touching");
        //}
        //else if (pointDTouching)
        //{
        //    print("point D is touching");
        //}


        //if (pointATouching & pointBTouching)
        //{
        //    conditionAchieved.Invoke();

        //}
        //else if (pointATouching && pointBTouching)
        //{
        //    conditionAchieved.Invoke();

        //}



        //if ((pointATouching & pointBTouching) & (pointCTouching & pointDTouching))
        //{
        //    print("point A&B&C&D is touching");
        //    conditionAchieved.Invoke();
        //}


    }
}
