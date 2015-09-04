using UnityEngine;
using System.Collections;

public class FaderEffect : MonoBehaviour {


    public bool IsActive;
    [Tooltip("Interval / Sekunds ")]
    public float FaderInterval;
    float nextActionTime = 0;
    public float FadeSpeed;
    [Range(0,1)]
    public float Min;
    [Range(0, 1)]
    public float Max;


	void Update () {

        if(IsActive)
            FaderAnimationPlay();
	}


    void FaderAnimationPlay()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += FaderInterval;
            float randomAlpha = Random.Range(Min, Max);
            float lerp = Mathf.PingPong(Time.time, FadeSpeed) / FadeSpeed;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, Mathf.Lerp(Min, Max, lerp));
        }
    }

      
}
