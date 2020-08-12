using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWobble : MonoBehaviour
{
    public SineWave sineWave;
    bool lateStart = false;
    [SerializeField][Range(0.0f,0.2f)] float blurAmount;

    [SerializeField] float blurTime;
    float timer = 0.0f;
    bool timerStart = false;

    // Start is called before the first frame update
    void Start()
    {
        Strawberry.onHitStrawberry += BlurScreen;
    }

    void LateStart()
	{
        lateStart = true;
        sineWave.XAxis = true;
        sineWave.Amplitude = .0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!lateStart)
		{
            LateStart();
		}
        if(BlurTimerFinished())
		{
            BlurOff();
		}
    }

    public void BlurScreen()
	{
        sineWave.Amplitude = blurAmount;
        timerStart = true;
	}
    public void BlurOff()
	{
        sineWave.Amplitude = 0;
    }

    private bool BlurTimerFinished()
	{
        if (timerStart)
        {
            timer += Time.deltaTime;
            if (timer > blurTime)
            {
                timerStart = false;
                timer = 0;
                return true;
            }
            return false;
        }
        return true;
    }
}
