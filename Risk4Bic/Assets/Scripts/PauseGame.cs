using UnityEngine;
using UnityEngine.InputSystem;

public class PauseGame : MonoBehaviour
{
    private InputAction m_MenuAction;
    public GameObject PauseMenu;
    private bool IsPauseMenuActive;
    void Update()
    {
        if (m_MenuAction.WasPressedThisFrame())
        {
            TogglePause();
        }
    }
    void Awake()
    {
        m_MenuAction = InputSystem.actions.FindAction("Player/Menu");
        IsPauseMenuActive = false;
    }
    public void TogglePause()
    {
        IsPauseMenuActive = !IsPauseMenuActive;
        PauseMenu.SetActive(IsPauseMenuActive);
    }
}
