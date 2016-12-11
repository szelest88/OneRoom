using UnityEngine;
using System.Collections;

public class BarEntity : MonoBehaviour
{

    public GameObject stripe;
    public float progress = 1.0f;

    private float stripeScaleXInitial;

    void Start()
    {
        stripeScaleXInitial = stripe.transform.localScale.x;
    }

    private void Update()
    {
        progress = Mathf.Clamp(progress, 0f, 1f);

        {
            var stripePosition = stripe.transform.localPosition;
            stripe.transform.localPosition = new Vector3(
                -(stripeScaleXInitial - stripeScaleXInitial * progress) * 0.5f,
                stripePosition.y,
                stripePosition.z);
        }

        //{
        //    var stripeScale = stripe.transform.localScale;

        //    stripe.transform.localScale = new Vector3(
        //        stripeScaleXInitial * progress,
        //        stripeScale.y,
        //        stripeScale.z);
        //}
    }

}
