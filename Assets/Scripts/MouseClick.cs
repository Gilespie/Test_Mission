using UnityEngine;

public class MouseClick : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;
    [SerializeField] private GameObject m_Button;

    private void Awake()
    {
        if (m_Button != null)
        {
            m_Button.SetActive(false);
        }
    }

    private void OnMouseDown()
    { 
        if (m_Animator != null)
        {
            m_Animator.SetTrigger("Play");

            if(m_Button != null )
            {
                m_Button.SetActive(true);
            }
        }
    }
}