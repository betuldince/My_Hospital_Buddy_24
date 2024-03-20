using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator animator;
    public int state = 3;
    private bool isAnimating = false;
    AnimatorStateInfo animStateInfo;

    
    public GameObject book;
 


    
    private void Start()
    {
        animStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        
    }

    void Update()
    {
        Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);


        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            isAnimating = false;
          
           
        }

        if (!isAnimating)
        {
            switch (state)
            {
                case 1:
                    book.SetActive(false);
                    animator.SetTrigger("act1");
                     
                    break;
                case 2:
                    book.SetActive(false);
                    animator.SetTrigger("act2");
                    
                    break;
                case 3:
                    book.SetActive(true);
                    animator.SetTrigger("act3");
                     
                    break;
                case 4:
                    book.SetActive(false);
                    animator.SetTrigger("act4");
                    break;
                case 5:
                    book.SetActive(false);
                    animator.SetTrigger("act5");
                    break;
                default:
                    break;
            }
            isAnimating = true;
        }
    }

    // Function to be called when an animation ends
    public void AnimationEnd()
    {
        isAnimating = false;
    }
}
