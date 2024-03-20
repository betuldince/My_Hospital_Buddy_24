using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator1;
    public Animator animator3;

 

    public int state = 3;
    private bool isAnimating = false;
    AnimatorStateInfo animStateInfo;
 

    
    private void Start()
    {
        animStateInfo = animator1.GetCurrentAnimatorStateInfo(0);
        
    }

    void Update()
    {
        /*
        Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);

        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {

        }
        */
        
 
 
    }

    // Function to be called when an animation ends
    public void AnimationEnd()
    {
        animator1.Rebind();
        animator3.Rebind();

 
    }
    public void Animation1Play()
    {
        animator1.SetBool("play",true);
    }
    public void Animation3Play()
    {
        animator3.SetBool("play", true);
    }
}
